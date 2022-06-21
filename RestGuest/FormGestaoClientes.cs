using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGuest
{
    public partial class FormGestaoClientes : Form
    {

      RestGuestContainer restGuest = new RestGuestContainer();
        public FormGestaoClientes()
        {
            InitializeComponent();

            cbPesquisa.SelectedIndex = 0;
            popularListBox();
            modoCriar(false, false);
        }

        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            if (btNovoCliente.Text == "Novo Cliente")
            {
                clearTexbox();
                modoCriar(true, false);
                btNovoCliente.Text = "Guardar/Cancelar";
                mtbIndicativo.Text = "351";
                tbNome.Focus();
            }
            else
            {
                if (isTexboxEmpty())
                {
                    if(MessageBox.Show("Preencha todos os campos antes de guardar!", "Guardar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                    {
                        modoCriar(false, false);
                        popularListBox();
                        btNovoCliente.Text = "Novo Cliente";
                    }

                    return;
                }

                if (!int.TryParse(tbNif.Text, out int nif) || tbNif.Text.Length != 9)
                {
                    MessageBox.Show("O NIF têm de ter 9 digitos!", "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    popularListBox();
                    btNovoCliente.Text = "Novo Cliente";

                    return;
                }

                Morada morada = new Morada();
                morada.Rua = tbRua.Text;
                morada.Cidade = tbCidade.Text;
                morada.CodPostal = tbCodPostal.Text;
                morada.Pais = tbPais.Text;

                Cliente cliente = new Cliente();
                cliente.Nome = tbNome.Text;
                cliente.Morada = morada;
                cliente.TotalGasto = 0;
                cliente.NumContribuinte = tbNif.Text;
                cliente.Telemovel = mtbIndicativo.Text + tbTelemovel.Text;

              restGuest.Moradas.Add(morada);
               restGuest.Pessoas.Add(cliente);

                restGuest.SaveChanges();

                modoCriar(false, false);

                btNovoCliente.Text = "Novo Cliente";
                popularListBox();
            }
        }

        private void popularListBox()//popula a listbox lbClientes com todos os clientes
        {
            lbClientes.DataSource = restGuest.Pessoas.OfType<Cliente>().ToList<Cliente>();
            lbClientes.ClearSelected();
            clearTexbox();
            btEditar.Enabled = false;
            btRemover.Enabled = false;
        }

        private void clearTexbox()//Limpa todos os campos
        {
            tbNome.Text = "";
            tbRua.Text = "";
            tbCidade.Text = "";
            tbCodPostal.Text = "";
            tbPais.Text = "";
            tbNif.Text = "";
            tbTelemovel.Text = "";
            mtbIndicativo.Text = "";
            lbTotal.Text = "0 €";
        }

        private bool isTexboxEmpty() //verifica se todos os campos estão preenchidos
        {
            if(tbNome.Text.Trim() == "" || tbRua.Text.Trim() == "" || tbCidade.Text.Trim() == "" || tbCodPostal.Text.Trim() == "-" || tbPais.Text.Trim() == "" || tbNif.Text.Trim() == "" || tbTelemovel.Text.Trim() == "" || mtbIndicativo.Text == "+")
                return true;
            return false;
        }

        private void modoCriar(bool modo, bool editar)//permite especificar quais os elementos que podem ser usados ou não
        {
            if (!editar)
                btEditar.Enabled = false;
            else
                btEditar.Enabled = true;

            lbClientes.Enabled = !modo;
            cbPesquisa.Enabled = !modo;
            tbPesquisa.Enabled = !modo;
            btPesquisa.Enabled = !modo;
            btRemover.Enabled = !modo;

            tbNome.Enabled = modo;
            tbRua.Enabled = modo;
            tbCidade.Enabled = modo;
            tbCodPostal.Enabled = modo;
            tbPais.Enabled = modo;
            tbNif.Enabled = modo;
            tbTelemovel.Enabled = modo;
            mtbIndicativo.Enabled = modo;
        }
        
        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            btEditar.Enabled = false;
            clearTexbox();

            IEnumerable<Cliente> pesquisa;

            if(cbPesquisa.SelectedIndex == 0)
                pesquisa = restGuest.Pessoas.OfType<Cliente>().ToList<Cliente>().Where<Cliente>(p => p.Nome.ToUpper().Contains(tbPesquisa.Text.ToUpper()));//pesquisa por nome
            else if(cbPesquisa.SelectedIndex == 1)
                pesquisa = restGuest.Pessoas.OfType<Cliente>().ToList<Cliente>().Where<Cliente>(p => p.Telemovel.Contains(tbPesquisa.Text));//pesquisa por telemovel
            else
                pesquisa = restGuest.Pessoas.OfType<Cliente>().ToList<Cliente>().Where<Cliente>(p => p.NumContribuinte.Contains(tbPesquisa.Text));//pesquisa por numero de contribuinte

            if (pesquisa.Count() != 0)
                lbClientes.DataSource = pesquisa.ToList<Cliente>();
            else
                lbClientes.DataSource = null;
        }
        
        private void btRemover_Click(object sender, EventArgs e)//remove o cliente caso não esteja a ser usado na base de dados
        {
            Cliente cliente = lbClientes.SelectedItem as Cliente;

            var pedidos = restGuest.Pedidos.Where(p => p.IdCliente == cliente.Id);

            if(pedidos.Count() != 0)
            {
                MessageBox.Show("Clientes com faturas no sistema não podem ser removidos", "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            var result = MessageBox.Show($"Deseja remover o cliente {cliente.Nome}?", "Remover Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            Morada morada = cliente.Morada;

            restGuest.Pessoas.Remove(cliente);
            restGuest.Moradas.Remove(morada);

            restGuest.SaveChanges();

            popularListBox();
        }
        
        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btRemover.Enabled = false;
            btEditar.Enabled = false;
            if (!(lbClientes.SelectedItem is Cliente cliente))
                return;
            btEditar.Enabled = true;
            btRemover.Enabled = true;
            Morada morada = cliente.Morada;

            tbNome.Text = cliente.Nome;
            tbRua.Text = morada.Rua;
            tbCidade.Text = morada.Cidade;
            tbCodPostal.Text = morada.CodPostal;
            tbPais.Text = morada.Pais;
            tbNif.Text = cliente.NumContribuinte;
            mtbIndicativo.Text  = cliente.Telemovel.Substring(0, cliente.Telemovel.Length - 9);
            tbTelemovel.Text = cliente.Telemovel.Substring(cliente.Telemovel.Length - 9);
            lbTotal.Text = $"{cliente.Total()} €";
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (lbClientes.SelectedItem == null)
                return;
            if (btEditar.Text == "Editar")
            {
                modoCriar(true, true);
                btEditar.Text = "Guardar/Cancelar";
                btNovoCliente.Enabled = false;
                btRemover.Enabled = false;
            }
            else
            {
                if (isTexboxEmpty())
                {
                    MessageBox.Show("Preencha todos os campos antes de guardar!", "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Cliente cliente = lbClientes.SelectedItem as Cliente;

                var result = MessageBox.Show("Deseja guardar as alterações do cliente?", "Editar cliente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
                else if (result == DialogResult.Cancel)
                {
                    modoCriar(false, false);

                    btEditar.Text = "Editar";
                    btNovoCliente.Enabled = true;
                    popularListBox();
                    lbClientes.SelectedItem = cliente;

                    return;
                }

                cliente.Nome = tbNome.Text;
                cliente.NumContribuinte = tbNif.Text;
                cliente.Telemovel = mtbIndicativo.Text + tbTelemovel.Text;

                Morada morada = cliente.Morada;
                morada.Rua = tbRua.Text;
                morada.Cidade = tbCidade.Text;
                morada.CodPostal = tbCodPostal.Text;
                morada.Pais = tbPais.Text;

                cliente.Morada = morada;

                restGuest.SaveChanges();

                modoCriar(false, false);

                btEditar.Text = "Editar";
                btNovoCliente.Enabled = true;
                popularListBox();
                lbClientes.SelectedItem  = cliente;
            }
        }

        private void cbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
           tbPesquisa_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbPesquisa.Text = "";
            cbPesquisa.SelectedIndex = 0;
        }

    
    }
}
