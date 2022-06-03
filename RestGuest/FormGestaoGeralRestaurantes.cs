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

            popularListBoxRestaurante();
            popularCheckboxMetodosPagamento();
            popularCheckboxCategorias();
            clearTexbox();
            modoCriar(false, false);
            cbPesquisa.SelectedIndex = 0;
        }

        private bool isTextBoxEmpty()
        {
            if (tbNomeRestaurante.Text.Trim() == "" || tbRua.Text.Trim() == "" || tbCidade.Text.Trim() == "" || tbCodPostal.Text.Trim() == "" || tbPais.Text.Trim() == "")
                return true;
            return false;
        }

        private void clearTexbox()
        {
            tbNomeRestaurante.Text = "";
            tbRua.Text = "";
            tbCidade.Text = "";
            tbCodPostal.Text = "";
            tbPais.Text = "";
        }

        private void modoCriar(bool modo, bool editar)
        {
            if (!editar)
                btEditar.Enabled = !modo;

            tbNomeRestaurante.Enabled = modo;
            tbRua.Enabled = modo;
            tbCidade.Enabled = modo;
            tbCodPostal.Enabled = modo;
            tbPais.Enabled = modo;

            btRemoverRestaurante.Enabled = !modo;
            lbRestaurantes.Enabled = !modo;
            cbPesquisa.Enabled = !modo;
            tbPesquisa.Enabled = !modo;
            btPesquisa.Enabled = !modo;
        }
                
        private void popularListBoxRestaurante()
        {
            lbRestaurantes.DataSource = restGuest.Restaurantes.ToList();
            lbRestaurantes.ClearSelected();
        }

        private void popularCheckboxMetodosPagamento()
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

        private void popularCheckboxCategorias()
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

        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            if (btNovoCliente.Text == "Novo Restaurante")
            {
                clearTexbox();
                modoCriar(true, false);
                btNovoCliente.Text = "Guardar/Cancelar";
                tbNomeRestaurante.Focus();
            }
            else
            {
                if (isTextBoxEmpty())
                    return;

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

                btNovoCliente.Text = "Novo Restaurante";
                clearTexbox();
                popularListBoxRestaurante();
            }
        }

        private void btRemoverRestaurante_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = lbRestaurantes.SelectedItem as Restaurante;
            Morada morada = restaurante.Morada;

            restGuest.Restaurantes.Remove(restaurante);
            restGuest.Moradas.Remove(morada);

            restGuest.SaveChanges();
            popularListBoxRestaurante();
            clearTexbox();
        }

        private void btAdicionarPagamento_Click(object sender, EventArgs e)
        {
            if (tbMetodoPagamento.Text.Trim() == "")
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

        private void btRemoverMetodo_Click(object sender, EventArgs e)
        {
            MetodoPagamento metodo = cbMetodosPagamento.SelectedItem as MetodoPagamento;

            restGuest.MetodoPagamentos.Remove(metodo);
            restGuest.SaveChanges();

            popularCheckboxMetodosPagamento();

            btRemoverMetodo.Enabled = false;
        }
    }
}
