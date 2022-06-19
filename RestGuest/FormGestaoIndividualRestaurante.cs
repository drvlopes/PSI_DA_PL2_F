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
    public partial class FormGestaoIndividualRestaurante : Form
    {
        RestGuestContainer restGuest = new RestGuestContainer();
        Restaurante restaurante;
        public FormGestaoIndividualRestaurante(Restaurante restaurante)
        {
            InitializeComponent();
            this.restaurante = restaurante;
            popularListBox();
            popularlbCategorias();
            modoCriar(false, false);
        }

        private void btNovoTrabalhador_Click(object sender, EventArgs e)
        {
            if (btNovoTrabalhador.Text == "Novo Trabalhador")
            {
                clearTexbox();
                modoCriar(true, false);
                btNovoTrabalhador.Text = "Guarda/Cancelar";
                mtbIndicativo.Text = "351";
                tbNomeTrabalhador.Focus();
            }
            else
            {
                if (ifTextBoxEmpty())
                {
                    if (MessageBox.Show("Preencha todos os campos antes de guardar!", "Guardar Trabalhador", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                    {
                        modoCriar(false, false);
                        btNovoTrabalhador.Text = "Novo Trabalhador";
                    }

                    return;
                }

                if (!int.TryParse(tbTelemovel.Text, out int telemovel) || tbTelemovel.Text.Length != 9)
                {
                    MessageBox.Show("O numero de telemovel têm de ter 9 digitos!", "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var result = MessageBox.Show("Deseja guardar os dados do cliente novo?", "Guardar cliente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
                else if (result == DialogResult.Cancel)
                {
                    modoCriar(false, false);

                    btNovoTrabalhador.Text = "Novo Trabalhador";

                    return;
                }

                Morada morada = new Morada();
                morada.Rua = tbRua.Text;
                morada.Cidade = tbCidade.Text;
                morada.CodPostal = tbCodPostal.Text;
                morada.Pais = tbPais.Text;

                Trabalhador trabalhador = new Trabalhador();
                trabalhador.Nome = tbNomeTrabalhador.Text;
                trabalhador.Morada = morada;
                trabalhador.Salario = tbSalario.Text;
                trabalhador.Posicao = tbPosicao.Text;
                trabalhador.Telemovel = mtbIndicativo.Text + tbTelemovel.Text;

                trabalhador.Restaurante = restaurante;

                restGuest.Moradas.Add(morada);
                restGuest.Pessoas.Add(trabalhador);

                restGuest.SaveChanges();

                modoCriar(false, false);

                btNovoTrabalhador.Text = "Novo Trabalhador";
                popularListBox();
            }
        }
        private void popularListBox()
        {
            lbTrabalhadores.DataSource = restaurante.Trabalhadores.ToList();
            lbTrabalhadores.ClearSelected();
            clearTexbox();
        }

        private void clearTexbox()
        {
            tbNomeTrabalhador.Text = "";
            tbRua.Text = "";
            tbCidade.Text = "";
            tbCodPostal.Text = "";
            tbPais.Text = "";
            tbSalario.Text = "";
            tbTelemovel.Text = "";
            tbPosicao.Text = "";
        }
        private void modoCriar(bool modo, bool editar)
        {
            if (!editar)
                btEditar.Enabled = !modo;

            lbTrabalhadores.Enabled = !modo;
            cbPesquisa.Enabled = !modo;
            tbPesquisa.Enabled = !modo;
            btPesquisa.Enabled = !modo;
            btRemover.Enabled = !modo;

            tbNomeTrabalhador.Enabled = modo;
            tbRua.Enabled = modo;
            tbCidade.Enabled = modo;
            tbCodPostal.Enabled = modo;
            tbPais.Enabled = modo;
            tbSalario.Enabled = modo;
            tbTelemovel.Enabled = modo;
            mtbIndicativo.Enabled = modo;
            tbPosicao.Enabled = modo;
        }
       
        private bool ifTextBoxEmpty()
        {
            if (tbNomeTrabalhador.Text.Trim() == "" || tbRua.Text.Trim() == "" || tbCidade.Text.Trim() == "" || tbCodPostal.Text.Trim() == "" || tbPais.Text.Trim() == "" || tbSalario.Text.Trim() == "" || tbTelemovel.Text.Trim() == "" || mtbIndicativo.Text == "+" || tbPosicao.Text == "")
                return true;
            return false;
        }

        private void lbTrabalhadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lbTrabalhadores.SelectedItem is Trabalhador trabalhador))
                return;

            Morada morada = trabalhador.Morada;

            tbNomeTrabalhador.Text = trabalhador.Nome;
            tbRua.Text = morada.Rua;
            tbCidade.Text = morada.Cidade;
            tbCodPostal.Text = morada.CodPostal;
            tbPais.Text = morada.Pais;
            tbSalario.Text = trabalhador.Salario;
            mtbIndicativo.Text = trabalhador.Telemovel.Substring(0, trabalhador.Telemovel.Length - 9);
            tbTelemovel.Text = trabalhador.Telemovel.Substring(trabalhador.Telemovel.Length - 9);
            tbPosicao.Text = trabalhador.Posicao;
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<Trabalhador> teste;
            if (cbPesquisa.SelectedIndex == 0)
                teste = restGuest.Pessoas.OfType<Trabalhador>().ToList<Trabalhador>().Where<Trabalhador>(p => p.Nome.ToUpper().Contains(tbPesquisa.Text.ToUpper()));
            else if (cbPesquisa.SelectedIndex == 1)
                teste = restGuest.Pessoas.OfType<Trabalhador>().ToList<Trabalhador>().Where<Trabalhador>(p => p.Telemovel.Contains(tbPesquisa.Text));
            else if (cbPesquisa.SelectedIndex == 2)
                teste = restGuest.Pessoas.OfType<Trabalhador>().ToList<Trabalhador>().Where<Trabalhador>(p => p.Salario.Contains(tbPesquisa.Text));
            else
                teste = restGuest.Pessoas.OfType<Trabalhador>().ToList<Trabalhador>().Where<Trabalhador>(p => p.Posicao.Contains(tbPesquisa.Text));

            if (teste.Count() != 0)
                lbTrabalhadores.DataSource = teste.ToList<Trabalhador>();
            else
                lbTrabalhadores.DataSource = null;
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            tbPesquisa.Text = "";
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            Pessoa trabalhador = lbTrabalhadores.SelectedItem as Trabalhador;

            var result = MessageBox.Show($"Deseja remover o trabalhador {trabalhador.Nome}?", "Remover trabalhador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;


            Morada morada = trabalhador.Morada;

            restGuest.Pessoas.Remove(trabalhador);
            restGuest.Moradas.Remove(morada);

            restGuest.SaveChanges();
            popularListBox();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (lbTrabalhadores.SelectedItem == null)
                return;
            if (btEditar.Text == "Editar")
            {
                modoCriar(true, true);
                btEditar.Text = "Guardar/Cancelar";
                btNovoTrabalhador.Enabled = false;
            }
            else
            {
                if (ifTextBoxEmpty())
                {
                    MessageBox.Show("Preencha todos os campos antes de guardar!", "Guardar Trabalhador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Trabalhador trabalhador = lbTrabalhadores.SelectedItem as Trabalhador;

                var result = MessageBox.Show("Deseja guardar as alterações do trabalhador?", "Editar trabalhador", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
                else if (result == DialogResult.Cancel)
                {
                    modoCriar(false, false);

                    btEditar.Text = "Editar";
                    btNovoTrabalhador.Enabled = true;
                    popularListBox();
                    lbTrabalhadores.SelectedItem = trabalhador;

                    return;
                }

                trabalhador.Nome = tbNomeTrabalhador.Text;
                trabalhador.Salario = tbSalario.Text;
                trabalhador.Telemovel = mtbIndicativo.Text + tbTelemovel.Text;
                trabalhador.Posicao = tbPosicao.Text;

                Morada morada = trabalhador.Morada;
                morada.Rua = tbRua.Text;
                morada.Cidade = tbCidade.Text;
                morada.CodPostal = tbCodPostal.Text;
                morada.Pais = tbPais.Text;

                trabalhador.Morada = morada;

                restGuest.SaveChanges();

                modoCriar(false, false);

                btEditar.Text = "Editar";
                btNovoTrabalhador.Enabled = true;
                popularListBox();
                lbTrabalhadores.SelectedItem = trabalhador;
            }
        }

  
        private void popularlbCategorias()
        {
            lbCategorias.Items.Clear();

            var list = restGuest.Categorias.ToList();

            foreach (var item in list)
            {
                if(item.Ativo)
                    lbCategorias.Items.Add(item);
            }
        }

        private void lbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(lbCategorias.SelectedItem is Categoria categoria))
                return;

            cbItens.Items.Clear();
            var items = categoria.ItemMenus;

            foreach (var item in items)
            {
                if (item.Restaurantes.Any(p => p.Id.Equals(restaurante.Id)))
                {
                    if(item.Ativo)
                    {
                        cbItens.Items.Add(item);
                        cbItens.SetItemChecked(cbItens.Items.Count - 1, true);
                    }
                }
                else
                {
                    if(item.Ativo)
                    {
                        cbItens.Items.Add(item);
                        cbItens.SetItemChecked(cbItens.Items.Count - 1, false);
                    }
                }
            }
        }


        private void cbItens_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cbItens.SelectedIndex == -1)
                return;
            Restaurante res = restGuest.Restaurantes.Find(restaurante.Id);

            if (cbItens.GetItemChecked(cbItens.SelectedIndex))
                res.ItemMenus.Remove(cbItens.SelectedItem as ItemMenu);
            else
                res.ItemMenus.Add(cbItens.SelectedItem as ItemMenu);

            restGuest.SaveChanges();
        }
    }
}
