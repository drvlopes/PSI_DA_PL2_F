using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGuest
{
    public partial class FormGestaoGeralRestaurantes : Form
    {
        RestGuestContainer restGuest = new RestGuestContainer();

        public FormGestaoGeralRestaurantes()
        {
            InitializeComponent();

            cbPesquisa.SelectedIndex = 0;
            popularListBoxRestaurante();
            popularCheckboxMetodosPagamento();
            popularCheckboxCategorias();
            clearTexbox();
            modoCriar(false, false);
        }

        private bool isTextBoxEmpty()//verifica se todos os campos estão preenchidos
        {
            if (tbNomeRestaurante.Text.Trim() == "" || tbRua.Text.Trim() == "" || tbCidade.Text.Trim() == "" || tbCodPostal.Text.Trim() == "-" || tbPais.Text.Trim() == "")
                return true;
            return false;
        }

        private void clearTexbox()//Limpa todos os campos
        {
            tbNomeRestaurante.Text = "";
            tbRua.Text = "";
            tbCidade.Text = "";
            tbCodPostal.Text = "";
            tbPais.Text = "";
        }

        private void modoCriar(bool modo, bool editar)//permite especificar quais os elementos que podem ser usados ou não
        {
            if (!editar)
                btEditar.Enabled = false;
            else
                btEditar.Enabled = true;

            tbNomeRestaurante.Enabled = modo;
            tbRua.Enabled = modo;
            tbCidade.Enabled = modo;
            tbCodPostal.Enabled = modo;
            tbPais.Enabled = modo;

            lbRestaurantes.Enabled = !modo;
            cbPesquisa.Enabled = !modo;
            tbPesquisa.Enabled = !modo;
            btPesquisa.Enabled = !modo;
        }
                
        private void popularListBoxRestaurante()//popula a listbox lbRestaurantes com todos os restaurantes
        {
            lbRestaurantes.DataSource = restGuest.Restaurantes.ToList();
            lbRestaurantes.ClearSelected();
            clearTexbox();
            btEditar.Enabled = false;
            btRemoverRestaurante.Enabled = false;
        }

        private void popularCheckboxMetodosPagamento()//popula a combobox cbMetodosPagamento com todos os metodos de pagamento e da check aos que estao ativos
        {
            cbMetodosPagamento.Items.Clear();

            var list = restGuest.MetodoPagamentos.ToList();

            foreach(var item in list)
            {
                cbMetodosPagamento.Items.Add(item);
                if (item.Ativo)
                {
                    cbMetodosPagamento.SetItemChecked(cbMetodosPagamento.Items.Count - 1, true);
                }
            }
        }

        private void popularCheckboxCategorias()//popula a combobox cbCategorias com todas as categorias e da check as que estao ativas
        {
            cbCategorias.Items.Clear();

            var list = restGuest.Categorias.ToList();

            foreach (var item in list)
            {
                cbCategorias.Items.Add(item);
                if (item.Ativo)
                {
                    cbCategorias.SetItemChecked(cbCategorias.Items.Count - 1, true);
                }
            }
        }

        private void btNovoRestaurante_Click(object sender, EventArgs e)
        {
            if (btNovoRestaurante.Text == "Novo Restaurante")
            {
                clearTexbox();
                modoCriar(true, false);
                btNovoRestaurante.Text = "Guardar/Cancelar";
                tbNomeRestaurante.Focus();
            }
            else
            {
                if (isTextBoxEmpty())
                {
                    if (MessageBox.Show("Preencha todos os campos antes de guardar!", "Guardar Restaurante", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                    {
                        modoCriar(false, false);
                        popularListBoxRestaurante();
                        btNovoRestaurante.Text = "Novo Restaurante";
                    }

                    return;
                }


                var result = MessageBox.Show("Deseja guardar os dados do restaurante novo?", "Guardar Restaurante", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
                else if (result == DialogResult.Cancel)
                {
                    modoCriar(false, false);
                    popularListBoxRestaurante();
                    btNovoRestaurante.Text = "Novo Restaurante";
                    return;
                }

                Morada morada = new Morada();
                morada.Rua = tbRua.Text;
                morada.Cidade = tbCidade.Text;
                morada.CodPostal = tbCodPostal.Text;
                morada.Pais = tbPais.Text;

                Restaurante restaurante = new Restaurante();
                restaurante.Nome = tbNomeRestaurante.Text;
                restaurante.Morada = morada;

                restGuest.Moradas.Add(morada);
                restGuest.Restaurantes.Add(restaurante);

                restGuest.SaveChanges();

                modoCriar(false, false);

                btNovoRestaurante.Text = "Novo Restaurante";
                clearTexbox();
                popularListBoxRestaurante();
            }
        }

        private void btRemoverRestaurante_Click(object sender, EventArgs e)//remove o restaurante caso não esteja a ser usado na base de dados
        {
            Restaurante restaurante = lbRestaurantes.SelectedItem as Restaurante;

            var trabalhadores = restaurante.Trabalhadores;
            var items = restaurante.ItemMenus;

            if (trabalhadores.Count() != 0 || items.Count() != 0)
            {
                MessageBox.Show("Restaurantes com dados no sistema não podem ser removidos", "Remover Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Deseja remover o restaurante {restaurante.Nome}?", "Remover Restaurante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            Morada morada = restaurante.Morada;

            restGuest.Restaurantes.Remove(restaurante);
            restGuest.Moradas.Remove(morada);

            restGuest.SaveChanges();
            popularListBoxRestaurante();
        }

        private void btAdicionarPagamento_Click(object sender, EventArgs e)
        {
            if(tbMetodoPagamento.Text.Trim() == "")
                return;

            MetodoPagamento metodo = new MetodoPagamento();
            metodo.MetPagamento = tbMetodoPagamento.Text;
            metodo.Ativo = false;

            restGuest.MetodoPagamentos.Add(metodo);

            restGuest.SaveChanges();

            popularCheckboxMetodosPagamento();

            tbMetodoPagamento.Text = "";
        }

        private void cbMetodosPagamento_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cbMetodosPagamento.SelectedIndex == -1)
                return;

            MetodoPagamento metodo = cbMetodosPagamento.SelectedItem as MetodoPagamento;

            if (cbMetodosPagamento.GetItemChecked(cbMetodosPagamento.SelectedIndex))
                metodo.Ativo = false;
            else
                metodo.Ativo = true;

            restGuest.SaveChanges();
        }

        private void cbMetodosPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMetodosPagamento.SelectedIndex != -1)
                btRemoverMetodo.Enabled = true;
        }

        private void btRemoverMetodo_Click(object sender, EventArgs e)//remove o metodo de pagamento caso não esteja a ser usado na base de dados
        {
            MetodoPagamento metodo = cbMetodosPagamento.SelectedItem as MetodoPagamento;

            var result = MessageBox.Show($"Deseja remover o método de pagamento {metodo.MetPagamento}?", "Remover Método de Pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            restGuest.MetodoPagamentos.Remove(metodo);
            restGuest.SaveChanges();

            popularCheckboxMetodosPagamento();

            btRemoverMetodo.Enabled = false;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (lbRestaurantes.SelectedItem == null)
                return;
            if(btEditar.Text == "Editar")
            {
                modoCriar(true, true);
                btEditar.Text = "Guardar/Cancelar";
                btNovoRestaurante.Enabled = false;
            }
            else
            {
                if (isTextBoxEmpty())
                {
                    if (MessageBox.Show("Preencha todos os campos antes de guardar!", "Guardar Restaurante", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                    {
                        modoCriar(false, false);
                        btEditar.Text = "Editar";
                        btNovoRestaurante.Enabled = true;
                    }

                    return;
                }

                Restaurante restaurante = lbRestaurantes.SelectedItem as Restaurante;

                var result = MessageBox.Show("Deseja guardar as alterações do restaurante?", "Editar Restaurante", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
                else if (result == DialogResult.Cancel)
                {
                    modoCriar(false, false);

                    btEditar.Text = "Editar";
                    btNovoRestaurante.Enabled = true;
                    popularListBoxRestaurante();
                    lbRestaurantes.SelectedItem = restaurante;

                    return;
                }

                restaurante.Nome = tbNomeRestaurante.Text;

                Morada morada = restaurante.Morada;

                morada.Rua = tbRua.Text;
                morada.Cidade = tbCidade.Text;
                morada.CodPostal = tbCodPostal.Text;
                morada.Pais = tbPais.Text;

                restaurante.Morada = morada;

                restGuest.SaveChanges();

                modoCriar(false, false);

                btEditar.Text = "Editar";
                btNovoRestaurante.Enabled = true;
                popularListBoxRestaurante();
                lbRestaurantes.SelectedItem = restaurante;
            }
        }

        private void lbRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btRemoverRestaurante.Enabled = false;
            btEditar.Enabled = false;
            if (!(lbRestaurantes.SelectedItem is Restaurante restaurante))
                return;
            btRemoverRestaurante.Enabled = true;
            btEditar.Enabled = true;

            Morada morada = restaurante.Morada;

            tbNomeRestaurante.Text = restaurante.Nome;
            tbRua.Text = morada.Rua;
            tbCidade.Text = morada.Cidade;
            tbCodPostal.Text = morada.CodPostal;
            tbPais.Text = morada.Pais;
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            btEditar.Enabled = false;
            clearTexbox();

            IEnumerable<Restaurante> pesquisa;

            pesquisa = restGuest.Restaurantes.ToList<Restaurante>().Where<Restaurante>(p => p.Nome.ToUpper().Contains(tbPesquisa.Text.ToUpper()));

            if (pesquisa.Count() != 0)
                lbRestaurantes.DataSource = pesquisa.ToList<Restaurante>();
            else
                lbRestaurantes.DataSource = null;
        }

        private void cbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPesquisa_TextChanged(sender, e);
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            tbPesquisa.Text = "";
            cbPesquisa.SelectedIndex = 0;
        }
        private void btAdicionarCategoria_Click(object sender, EventArgs e)
        {
            if (tbAdicionarCategoria.Text.Trim() == "")
                return;

            Categoria categoria = new Categoria();
            categoria.Nome = tbAdicionarCategoria.Text;
            categoria.Ativo = false;

            restGuest.Categorias.Add(categoria);

            restGuest.SaveChanges();

            popularCheckboxCategorias();

            tbAdicionarCategoria.Text = "";
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedIndex != -1)
                btRemoverCategoria.Enabled = true;
        }

        private void btRemoverCategoria_Click(object sender, EventArgs e) //remove a categoria caso não esteja a ser usado na base de dados
        {
            Categoria categoria = cbCategorias.SelectedItem as Categoria;

            var result = MessageBox.Show($"Deseja remover a categoria {categoria.Nome}?", "Remover Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            restGuest.Categorias.Remove(categoria);
            restGuest.SaveChanges();

            popularCheckboxCategorias();

            btRemoverCategoria.Enabled = false;
        }

        private void cbCategorias_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cbCategorias.SelectedIndex == -1)
                return;

            Categoria categoria = cbCategorias.SelectedItem as Categoria;

            if (cbCategorias.GetItemChecked(cbCategorias.SelectedIndex))
                categoria.Ativo = false;
            else
                categoria.Ativo = true;

            restGuest.SaveChanges();
        }

   
    }
}
