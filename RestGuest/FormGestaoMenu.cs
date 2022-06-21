using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGuest
{
    public partial class FormGestaoMenu : Form
    {
        RestGuestContainer restGuest = new RestGuestContainer();

        public FormGestaoMenu()
        {
            InitializeComponent();

            cbPesquisa.SelectedIndex = 0;
            popularCheckbox(null);
            clearTexbox();
            modoCriar(false, false);

        }

        private void btImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "imagem"; // Default file name
            dlg.Filter = "jpg files (*.jpg)|*.jpg";
            dlg.FilterIndex = 1; // Default filter index
                                 // Show save file dialog box e process save file dialog box results
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(dlg.FileName);
                long fileSize = fi.Length; //The size of the current file in bytes.file 
                if (fi.Length > 1048576)
                {
                    MessageBox.Show("Por favor escolha uma imagem ate 1 MB!", "Gestão de Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                pbImagem.Image = Image.FromFile(dlg.FileName);
                
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (btAdicionar.Text == "Novo Item de Menu")
            {
                clearTexbox();
                modoCriar(true, false);
                btAdicionar.Text = "Guardar/Cancelar";
                tbNome.Focus();
            }
            else
            {
                if (isTextBoxEmpty())
                {
                    if (MessageBox.Show("Preencha todos os campos antes de guardar!", "Guardar Item de Menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                    {
                        modoCriar(false, false);
                        popularCheckbox(null);
                        btAdicionar.Text = "Novo Item de Menu";
                    }

                    return;
                }

                var result = MessageBox.Show("Deseja guardar os dados do item de menu?", "Guardar Item de Menu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
                else if (result == DialogResult.Cancel)
                {
                    modoCriar(false, false);
                    popularCheckbox(null);
                    btAdicionar.Text = "Novo Restaurante";
                    return;
                }

                Categoria categoria = cbCategoria.SelectedItem as Categoria;
                ItemMenu itemMenu = new ItemMenu();
                itemMenu.Nome = tbNome.Text;
                itemMenu.Ingredientes = tbIngredientes.Text;
                itemMenu.Preco = Double.Parse(mtbPreco.Text);
                itemMenu.Categoria = categoria;

                ImageConverter _imageConverter = new ImageConverter();
                itemMenu.Fotografia = (byte[])_imageConverter.ConvertTo(pbImagem.Image, typeof(byte[]));

                restGuest.ItemMenus.Add(itemMenu);

                restGuest.SaveChanges();

                modoCriar(false, false);
                popularCheckbox(null);
                btAdicionar.Text = "Novo Item de Menu";
            }
        }

        private void popularCheckbox(IEnumerable<ItemMenu> pesquisa)
        {
            cbItemsMenu.Items.Clear();
            btRemover.Enabled = false;
            if(pesquisa == null)
                pesquisa = restGuest.ItemMenus.ToList();

            foreach (var item in pesquisa)
            {
                cbItemsMenu.Items.Add(item);
                if (item.Ativo)
                {
                    cbItemsMenu.SetItemChecked(cbItemsMenu.Items.Count - 1, true);
                }
            }

            cbItemsMenu.ClearSelected();
            clearTexbox();
            btEditar.Enabled = false;
            btRemover.Enabled = false;
        }

        private bool isTextBoxEmpty()
        {
            if (tbNome.Text.Trim() == "" || tbIngredientes.Text.Trim() == "" || mtbPreco.Text.Trim() == "")
                return true;
            return false;
        }

        private void clearTexbox()
        {
            tbNome.Text = "";
            tbIngredientes.Text = "";
            mtbPreco.Text = "";
            pbImagem.Image = pbImagem.InitialImage;
        }

        private void modoCriar(bool modo, bool editar)
        {
            if (!editar)
                btEditar.Enabled = false;
            else
                btEditar.Enabled = true;

            tbNome.Enabled = modo;
            tbIngredientes.Enabled = modo;
            mtbPreco.Enabled = modo;
            btImagem.Enabled = modo;
            cbCategoria.Enabled = modo;
            btImagem.Enabled = modo;

            cbItemsMenu.Enabled = !modo;
            cbPesquisa.Enabled = !modo;
            tbPesquisa.Enabled = !modo;
            btPesquisa.Enabled = !modo;
        }

        private void FormGestaoMenu_Shown(object sender, EventArgs e)
        {
            var list = restGuest.Categorias.ToList();

            if (list.Count == 0)
            {
                MessageBox.Show("Precisa de adicionar categorias antes de poder aceder aos items de menu!", "Gestão de Items de Menu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            foreach (var item in list)
            {
                if (item.Ativo)
                {
                    cbCategoria.Items.Add(item);
                }
            }            
        }

        private void cbItemsMenu_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cbItemsMenu.SelectedIndex == -1)
                return;

            ItemMenu item = cbItemsMenu.SelectedItem as ItemMenu;

            if (cbItemsMenu.GetItemChecked(cbItemsMenu.SelectedIndex))
                item.Ativo = false;
            else
                item.Ativo = true;

            restGuest.SaveChanges();
        }

        private void cbItemsMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            btEditar.Enabled = false;
            if (!(cbItemsMenu.SelectedItem is ItemMenu itemMenu))
                return;
            btEditar.Enabled = true;
            btRemover.Enabled = true;

            tbNome.Text = itemMenu.Nome;
            tbIngredientes.Text = itemMenu.Ingredientes;
            mtbPreco.Text = itemMenu.Preco.ToString();
            cbCategoria.SelectedItem = itemMenu.Categoria;

            if(itemMenu.Fotografia.Length != 0)
                pbImagem.Image = (Bitmap)((new ImageConverter()).ConvertFrom(itemMenu.Fotografia));
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            ItemMenu itemMenu = cbItemsMenu.SelectedItem as ItemMenu;

            var restaurantes = itemMenu.Restaurantes;
            var pedidos = itemMenu.ItemMenuPedidos;

            if (restaurantes.Count() != 0 || pedidos.Count() != 0)
            {
                MessageBox.Show("Items de menu associados a restaurantes ou com faturas no sistema não podem ser removidos", "Remover Item de Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Deseja remover o item?", "Remover Item de Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            restGuest.ItemMenus.Remove(itemMenu);
            restGuest.SaveChanges();
            popularCheckbox(null);
        }

        private bool isTexboxEmpty()
        {
            if (tbNome.Text.Trim() == "" || tbIngredientes.Text.Trim() == "" || mtbPreco.Text.Trim() == "€   .")
                return true;
            return false;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (cbItemsMenu.SelectedItem == null)
                return;

            if(btEditar.Text == "Editar")
            {
                modoCriar(true, true);
                btEditar.Text = "Guardar/Cancelar";
                btAdicionar.Enabled = false;
                btRemover.Enabled = false;
            }
            else
            {
                if (isTexboxEmpty())
                {
                    MessageBox.Show("Preencha todos os campos antes de guardar!", "Guardar Item de Menu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ItemMenu itemMenu = cbItemsMenu.SelectedItem as ItemMenu;

                var result = MessageBox.Show("Deseja guardar as alterações do item?", "Editar Item de Menu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
                else if (result == DialogResult.Cancel)
                {
                    modoCriar(false, false);

                    btEditar.Text = "Editar";
                    btAdicionar.Enabled = true;
                    popularCheckbox(null);
                    cbCategoria.SelectedItem = itemMenu;

                    return;
                }

                Categoria categoria = cbCategoria.SelectedItem as Categoria;

                itemMenu.Nome = tbNome.Text;
                itemMenu.Ingredientes = tbIngredientes.Text;
                itemMenu.Preco = Double.Parse(mtbPreco.Text);
                itemMenu.Categoria = categoria;

                ImageConverter _imageConverter = new ImageConverter();
                itemMenu.Fotografia = (byte[])_imageConverter.ConvertTo(pbImagem.Image, typeof(byte[]));

                restGuest.SaveChanges();
                modoCriar(false, false);

                btEditar.Text = "Editar";
                btAdicionar.Enabled = true;
                popularCheckbox(null);
                cbCategoria.SelectedItem = itemMenu;
            }
        }

        private void cbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            btEditar.Enabled = false;
            clearTexbox();

            IEnumerable<ItemMenu> pesquisa;

            if (cbPesquisa.SelectedIndex == 0)
                pesquisa = restGuest.ItemMenus.ToList().Where(p => p.Nome.ToUpper().Contains(tbPesquisa.Text.ToUpper()));
            else 
                pesquisa = restGuest.ItemMenus.ToList().Where(p => p.Categoria.Nome.ToUpper().Contains(tbPesquisa.Text.ToUpper()));

            if (pesquisa.Count() != 0)
                popularCheckbox(pesquisa);
            else
                cbItemsMenu.Items.Clear();
        }
    }
}
