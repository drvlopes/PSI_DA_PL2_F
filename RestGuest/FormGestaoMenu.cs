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
            popularCheckbox();
            clearTexbox();
            modoCriar(false, false);

        }

        private void btImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "imagem"; // Default file name
            dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            dlg.FilterIndex = 1; // Default filter index
                                 // Show save file dialog box e process save file dialog box results
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                {
                    pbImagem.Image = Image.FromFile(dlg.FileName);
                }
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
                        popularCheckbox();
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
                    popularCheckbox();
                    btAdicionar.Text = "Novo Restaurante";
                    return;
                }

                Categoria categoria = cbCategoria.SelectedItem as Categoria;
                ItemMenu itemMenu = new ItemMenu();
                itemMenu.Nome = tbNome.Text;
                itemMenu.Ingredientes = tbIngredientes.Text;
                itemMenu.Preco = mtbPreco.Text;
                itemMenu.Categoria = categoria;

                ImageConverter _imageConverter = new ImageConverter();
                itemMenu.Fotografia = (byte[])_imageConverter.ConvertTo(pbImagem.Image, typeof(byte[]));

                restGuest.ItemMenus.Add(itemMenu);

                restGuest.SaveChanges();

                modoCriar(false, false);
                popularCheckbox();
                btAdicionar.Text = "Novo Item de Menu";
            }
        }

        private void popularCheckbox()
        {
            cbItemsMenu.Items.Clear();
            btRemover.Enabled = false;
            var list = restGuest.ItemMenus.ToList();

            foreach (var item in list)
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
            mtbPreco.Text = itemMenu.Preco;
            cbCategoria.SelectedItem = itemMenu.Categoria;

            pbImagem.Image = (Bitmap)((new ImageConverter()).ConvertFrom(itemMenu.Fotografia));
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            ItemMenu itemMenu = cbItemsMenu.SelectedItem as ItemMenu;

            var result = MessageBox.Show($"Deseja remover o item?", "Remover Item de Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            restGuest.ItemMenus.Remove(itemMenu);
            restGuest.SaveChanges();
            popularCheckbox();
        }
    }
}
