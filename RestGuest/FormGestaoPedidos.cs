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
    public partial class FormGestaoPedidos : Form
    {
        RestGuestContainer restGuest = new RestGuestContainer();
        Restaurante restaurante;
        Trabalhador trabalhador;

        public FormGestaoPedidos(Restaurante restaurante, Trabalhador trabalhador)
        {
            InitializeComponent();
            this.restaurante = restaurante;
            this.trabalhador = trabalhador;
            popularEstados();
            popularClientes();
            popularCategorias();
            popularPagamentos();
            comboBox2.SelectedIndex = -1;
            cbEstadoLista.SelectedIndex = 0;

            modoCriar(false);
            lbFuncionario.Text = trabalhador.Nome;
        }

        private void popularEstados()
        {
            cbEstadoLista.DataSource = restGuest.Estados.ToList();
            cbEstadoPedido.DataSource = restGuest.Estados.ToList();
        }

        private void popularClientes()
        {
            var clientes = restGuest.Pessoas.OfType<Cliente>().ToList<Cliente>();
            foreach (var item in clientes)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void popularPagamentos()
        {
            var pagamentos = restGuest.MetodoPagamentos.ToList();
            foreach (var item in pagamentos)
            {
                if(item.Ativo)
                    comboBox2.Items.Add(item);
            }
        }

        private void popularCategorias()
        {
            var categorias = restGuest.Categorias.ToList().Where(p => p.Ativo.Equals(true));
            foreach (var item in categorias)
            {
                cbCategoria.Items.Add(item);
            }
        }

        private void popularListBox()
        {
            modoCriar(false);
            clearTexbox();
            lbPedidos.Items.Clear();
            Estado estado = cbEstadoLista.SelectedItem as Estado;
            var pedidos = restaurante.Pedidos.ToList().Where<Pedido>(p => p.IdEstado.Equals(estado.Id));
            foreach (var item in pedidos)
            {
                lbPedidos.Items.Add(item);
            }
            lbPedidos.ClearSelected();
            clearTexbox();
        }

        private void modoCriar(bool modo)
        {
            comboBox2.Enabled = modo;
            cbCategoria.Enabled = modo;
            lbListaItems.Enabled = modo;
            numQuantidade.Enabled = modo;
            btAdicionarItem.Enabled = modo;
            btRemoverItem.Enabled = modo;
            lbItemsEscolhidos.Enabled = modo;
            cbEstadoPedido.Enabled = modo;
            btExportar.Enabled = modo;
            mtbPagar.Enabled = modo;
            cbPagar.Enabled = modo;
            btPagar.Enabled = modo;
        }

        private void clearTexbox()
        {
            lbListaItems.Items.Clear();
            lbItemsEscolhidos.Items.Clear();
            cbCategoria.SelectedIndex = -1;
            numQuantidade.Value = 1;
            cbEstadoPedido.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            lbPagar.Text = "0€";
            mtbPagar.Text = "";
            cbPagar.SelectedIndex = -1;
            pbImagem.Image = pbImagem.InitialImage;
            lbIngredientes.Text = "";
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
           
        }

        private void cbEstadoLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            popularListBox();
        }

        private void lbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            modoCriar(false);
            if (lbPedidos.SelectedItem == null)
                return;
            Pedido pedido = lbPedidos.SelectedItem as Pedido;
            comboBox2.Items.Clear();
            comboBox2.Items.Add(pedido.Cliente);
            comboBox2.SelectedIndex = 0;
            modoCriar(true);
            comboBox2.Enabled = false;
        }

        private void btNovoPedido_Click(object sender, EventArgs e)
        {
            modoCriar(false);
            comboBox2.Enabled = true;
            clearTexbox();
            comboBox2.Focus();
            comboBox2.DroppedDown = true;
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbListaItems.Items.Clear();
            if (cbCategoria.SelectedIndex == -1)
                return;
            Categoria categoria = cbCategoria.SelectedItem as Categoria;
            var items = restaurante.ItemMenus.Where(p => p.Categoria.Id.Equals(categoria.Id));
            foreach (var item in items)
            {
                if (item.Ativo)
                    lbListaItems.Items.Add(item);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            modoCriar(false);
            comboBox2.Enabled = true;
            if (comboBox2.SelectedIndex == -1)
                return;
            modoCriar(true);
            comboBox2.Enabled = false;
        }

        private void btAdicionarItem_Click(object sender, EventArgs e)
        {
            if (lbListaItems.SelectedIndex == -1)
                return;
        }
    }
}
