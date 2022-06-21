using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            var estados = restGuest.Estados.ToList();
            foreach (var estado in estados)
            {
                cbEstadoLista.Items.Add(estado);
            }
        }

        private void popularClientes()
        {
            comboBox2.Items.Clear();
            var clientes = restGuest.Pessoas.OfType<Cliente>().ToList<Cliente>();
            foreach (var item in clientes)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void popularPagamentos()
        {
            cbPagar.Items.Clear();
            var pagamentos = restGuest.MetodoPagamentos.ToList().Where(p => p.Ativo.Equals(true));
            foreach (var item in pagamentos)
            {
                if(item.Ativo)
                    cbPagar.Items.Add(item);
            }
        }

        private void popularCategorias()
        {
            cbCategoria.Items.Clear();
            var categorias = restGuest.Categorias.ToList().Where(p => p.Ativo.Equals(true));
            foreach (var item in categorias)
            {
                cbCategoria.Items.Add(item);
            }
        }

        public void popularEscolhidos()
        {
            if (lbPedidos.SelectedIndex == -1)
                return;
            RestGuestContainer restGuest = new RestGuestContainer();

            lbItemsEscolhidos.Items.Clear();
            Pedido pedido = lbPedidos.SelectedItem as Pedido;
            var menu = restGuest.ItemMenuPedidos.Where(p => p.PedidoId == pedido.Id).GroupBy(p => p.ItemMenu).ToList();
            foreach (var item in menu)
            {
                lbItemsEscolhidos.Items.Add($"{item.Key}  x  {item.Count()}");
            }
        }

        private void popularListBox()
        {
            Restaurante res = restGuest.Restaurantes.Find(restaurante.Id);
            modoCriar(false);
            clearTexbox();
            lbPedidos.Items.Clear();
            Estado estado = cbEstadoLista.SelectedItem as Estado;
            var pedidos = res.Pedidos.ToList().Where<Pedido>(p => p.IdEstado.Equals(estado.Id));
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
            btExportar.Enabled = modo;
            tbPagar.Enabled = modo;
            cbPagar.Enabled = modo;
            btPagar.Enabled = modo;
        }

        private void clearTexbox()
        {
            lbListaItems.Items.Clear();
            lbItemsEscolhidos.Items.Clear();
            cbCategoria.SelectedIndex = -1;
            numQuantidade.Value = 1;
            comboBox2.SelectedIndex = -1;
            lbPagar.Text = "0 €";
            tbPagar.Text = "";
            cbPagar.SelectedIndex = -1;
            pbImagem.Image = pbImagem.InitialImage;
            lbIngredientes.Text = "";
        }

        private void cbEstadoLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            popularListBox();
            lbPedidos_SelectedIndexChanged(sender, e);
        }

        private void lbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            modoCriar(false);
            clearTexbox();
            btCancelar.Enabled = false;
            btExportar.Enabled = false;
            if (lbPedidos.SelectedItem == null)
                return;
            Pedido pedido = lbPedidos.SelectedItem as Pedido;
            comboBox2.Items.Clear();
            comboBox2.Items.Add(pedido.Cliente);
            comboBox2.SelectedIndex = 0;
            modoCriar(true);
            comboBox2.Enabled = false;
            if (pedido.Estado.Status == "Concluído" || pedido.Estado.Status == "Cancelado")
            {
                modoCriar(false);
                btExportar.Enabled = true;

            }
            else if (pedido.Estado.Status == "Em Processamento")
            {
                modoCriar(false);
                lbItemsEscolhidos.Enabled = true;
                tbPagar.Enabled = true;
                cbPagar.Enabled = true;
                btPagar.Enabled = true;
            }
            else
                btCancelar.Enabled = true;
            popularEscolhidos();

            if (lbItemsEscolhidos.Items.Count == 0)
                btPagar.Enabled = false;

            label8.Text = $"{pedido.ValorTotal} €";
            lbPagar.Text = $"{pedido.ValorTotal} €";
            tbPagar.Text = $"{pedido.ValorTotal}";
        }

        private void btNovoPedido_Click(object sender, EventArgs e)
        {
            modoCriar(false);
            popularClientes();
            lbPedidos.SelectedIndex = -1;
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
            Restaurante res = restGuest.Restaurantes.Find(restaurante.Id);
            var items = res.ItemMenus.Where(p => p.Categoria.Id.Equals(categoria.Id));
            foreach (var item in items)
            {
                if (item.Ativo)
                    lbListaItems.Items.Add(item);
            }
        }

        private void btAdicionarItem_Click(object sender, EventArgs e)
        {
            if (lbListaItems.SelectedIndex == -1)
                return;
            btPagar.Enabled = true;
            Pedido pedido = lbPedidos.SelectedItem as Pedido;
            Cliente cliente = pedido.Cliente;
            restGuest.Pedidos.Attach(pedido);
            ItemMenu item = lbListaItems.SelectedItem as ItemMenu;
            restGuest.ItemMenus.Attach(item);
            double total = pedido.ValorTotal;

            for (int i = 0; i < numQuantidade.Value; i++)
            {
                ItemMenuPedidos menu = new ItemMenuPedidos();
                menu.ItemMenu = item;
                menu.Pedido = pedido;
                restGuest.ItemMenuPedidos.Add(menu);
                total += item.Preco;
            }

            pedido.ValorTotal = Math.Round(total, 2);

            restGuest.SaveChanges();

            popularEscolhidos();

            label8.Text = $"{total} €";
            numQuantidade.Value = 1;
            lbPagar.Text = $"{total} €";
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            modoCriar(false);
            comboBox2.Enabled = true;
            if (comboBox2.SelectedIndex == -1)
                return;
            if (lbPedidos.SelectedIndex != -1)
                return;
            modoCriar(true);
            comboBox2.Enabled = false;
            Pedido pedido = new Pedido();
            Restaurante res = restGuest.Restaurantes.Find(restaurante.Id);
            Trabalhador tra = restGuest.Pessoas.Find(trabalhador.Id) as Trabalhador;

            pedido.Trabalhador = tra;
            pedido.Restaurante = res;
            pedido.Cliente = comboBox2.SelectedItem as Cliente;
            pedido.Estado = restGuest.Estados.First();
            pedido.ValorTotal = 0;

            restGuest.Pedidos.Add(pedido);

            restGuest.SaveChanges();

            cbEstadoLista.SelectedItem = restGuest.Estados.First();
            popularListBox();
            lbPedidos.SelectedItem = pedido;
        }

        private void btRemoverItem_Click(object sender, EventArgs e)
        {
            if (lbItemsEscolhidos.SelectedIndex == -1)
                return;

            Pedido pedido = lbPedidos.SelectedItem as Pedido;
            var menu = restGuest.ItemMenuPedidos.Where(p => p.PedidoId == pedido.Id).GroupBy(p => p.ItemMenu).ToList();

            ItemMenu item = menu[lbItemsEscolhidos.SelectedIndex].Key as ItemMenu;

            double total = pedido.ValorTotal;
            double temp = item.Preco;

            total -= temp;

            
            if(total > 0)
            {
                ItemMenuPedidos itemPedido = restGuest.ItemMenuPedidos.Where(p => p.ItemMenuId == item.Id).ToList().Last();
                restGuest.ItemMenuPedidos.Remove(itemPedido);
                pedido.ValorTotal = Math.Round(total, 2);
            }
            else
            {
                var itemPedido = restGuest.ItemMenuPedidos.Where(p => p.ItemMenuId == item.Id);
                foreach (var itemp in itemPedido)
                {
                    restGuest.ItemMenuPedidos.Remove(itemp);
                    pedido.ValorTotal = 0;
                    total = 0;
                }
            }

            restGuest.SaveChanges();

            int index = lbItemsEscolhidos.SelectedIndex;

            popularEscolhidos();

            if (lbItemsEscolhidos.Items.Count != 0 && index < lbItemsEscolhidos.Items.Count)
                lbItemsEscolhidos.SelectedIndex = index;
            else
                lbItemsEscolhidos.ClearSelected();
            label8.Text = $"{Math.Round(total, 2)} €";
            lbPagar.Text = $"{Math.Round(total, 2)} €";
            numQuantidade.Value = 1;
            if (lbItemsEscolhidos.Items.Count == 0)
                btPagar.Enabled = false;
        }

        private void lbItemsEscolhidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbImagem.Image = pbImagem.InitialImage;
            lbIngredientes.Text = "";
            if (lbItemsEscolhidos.SelectedIndex == -1)
                return;
            Pedido pedido = lbPedidos.SelectedItem as Pedido;
            var menu = restGuest.ItemMenuPedidos.Where(p => p.PedidoId == pedido.Id).GroupBy(p => p.ItemMenu).ToList();

            ItemMenu item = menu[lbItemsEscolhidos.SelectedIndex].Key as ItemMenu;

            if (item.Fotografia.Length != 0)
                pbImagem.Image = (Bitmap)((new ImageConverter()).ConvertFrom(item.Fotografia));
            lbIngredientes.Text = item.Ingredientes;
        }

        private void lbListaItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbListaItems.SelectedItem == null)
                return;

            ItemMenu item = lbListaItems.SelectedItem as ItemMenu;

            if (item.Fotografia.Length != 0)
                pbImagem.Image = (Bitmap)((new ImageConverter()).ConvertFrom(item.Fotografia));
            lbIngredientes.Text = item.Ingredientes;
        }

        private void FormGestaoPedidos_Shown(object sender, EventArgs e)
        {
            var categorias = restGuest.Categorias.ToList().Where(p => p.Ativo.Equals(true));

            if (categorias.Count() == 0)
            {
                MessageBox.Show("Precisa de ter categorias associadas a este restaunte para aceder à gestão de pedidos", "Gestão de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            var clientes = restGuest.Pessoas.OfType<Cliente>().ToList<Cliente>();

            if (clientes.Count() == 0)
            {
                MessageBox.Show("Precisa de ter clientes adicionados para aceder à gestão de pedidos", "Gestão de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            var pagamentos = restGuest.MetodoPagamentos.ToList().Where(p => p.Ativo.Equals(true));

            if (pagamentos.Count() == 0)
            {
                MessageBox.Show("Precisa de ter metodos de pagamento associados a este restaunte para aceder à gestão de pedidos", "Gestão de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            Restaurante res = restGuest.Restaurantes.Find(restaurante.Id);

            var items = res.ItemMenus.ToList();

            if (pagamentos.Count() == 0)
            {
                MessageBox.Show("Precisa de ter items de menu associados a este restaunte para aceder à gestão de pedidos", "Gestão de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            if (cbPagar.SelectedIndex == -1)
                return;

            Pedido pedido = lbPedidos.SelectedItem as Pedido;
            var pagamentos = pedido.Pagamentos;

            double total = pedido.ValorTotal;
            double pago = 0;

            if(pagamentos.Count != 0)
                foreach (var item in pagamentos)
                {
                    pago += item.Valor;
                }



            if (double.TryParse(tbPagar.Text, out double pagar))
            {
                if (pagar <= total)
                {
                    total -= pagar;
                    Pagamento pagamento = new Pagamento();
                    pagamento.MetodoPagamento = cbPagar.SelectedItem as MetodoPagamento;
                    pagamento.Pedido = pedido;
                    pagamento.Valor = Math.Round(pagar, 2);
                    pedido.ValorTotal = Math.Round(total, 2);
                    if (total == 0)
                    {
                        pedido.Estado = restGuest.Estados.Find(4);
                    }
                    else
                    {
                        pedido.Estado = restGuest.Estados.Find(2);
                    }
                    restGuest.Pagamentos.Add(pagamento);
                    restGuest.SaveChanges();
                    cbEstadoLista.SelectedIndex = pedido.Estado.Id - 1;
                    popularListBox();
                    lbPedidos.SelectedIndex = lbPedidos.Items.Count - 1;
                    if(total != 0)
                    {
                        cbPagar.Focus();
                        cbPagar.SelectedItem = pagamento.MetodoPagamento;
                        cbPagar_SelectionChangeCommitted(sender, e);
                    }

                }
                else
                    MessageBox.Show($"Valor a pagar {total} €");
            }
            else
                MessageBox.Show("Formato incorrecto!");
        }

        private void cbPagar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (lbPedidos.SelectedIndex == -1)
                return;

            Pedido pedido = lbPedidos.SelectedItem as Pedido;
            lbPagar.Text = $"{pedido.ValorTotal} €";
            tbPagar.Text = pedido.ValorTotal.ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (lbPedidos.SelectedIndex == -1)
                return;

            Pedido pedido = lbPedidos.SelectedItem as Pedido;

            pedido.Estado = restGuest.Estados.Find(3);

            restGuest.SaveChanges();

            cbEstadoLista.SelectedItem = pedido.Estado;
            popularListBox();
            lbPedidos.SelectedItem = pedido;
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            if (lbPedidos.SelectedItem == null)
                return;
            Pedido pedido = lbPedidos.SelectedItem as Pedido;
            var items = pedido.ItemMenuPedidos.GroupBy(p => p.ItemMenu);
            var pagamentos = pedido.Pagamentos;
            string filename = "";

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = $"({pedido.Id})_{pedido.Cliente.Nome.Replace(' ', '_').Trim()}_{pedido.Cliente.NumContribuinte}"; // Default file name
            dlg.Filter = "txt files (*.txt)|*.txt"; // Default file extensions
            dlg.FilterIndex = 1; // Default filter index
                     // Show save file dialog box e process save file dialog box results
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Save document
                filename = dlg.FileName;
                // ...
            }
            else
            {
                return;
            }

            // Definir o stream de ligação ao ficheiro em modo append e para escrit
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            // Criar o buffer de texto de escrita
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"Nome: {pedido.Restaurante.Nome}");
            sw.WriteLine($"Morada: {pedido.Restaurante.Morada.Rua}");
            sw.WriteLine($"{pedido.Restaurante.Morada.CodPostal} {pedido.Restaurante.Morada.Cidade}");
            sw.WriteLine($"____________________________________________");
            sw.WriteLine($"Nome: {pedido.Cliente.Nome}");
            sw.WriteLine($"Morada: {pedido.Cliente.Morada.Rua}");
            sw.WriteLine($"{pedido.Cliente.Morada.CodPostal} {pedido.Cliente.Morada.Cidade}");
            sw.WriteLine($"Nif: {pedido.Cliente.NumContribuinte}");
            sw.WriteLine($"____________________________________________");
            sw.WriteLine($"Data de exportação: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}");
            sw.WriteLine($"Funcionário: {pedido.Trabalhador.Nome}");
            sw.WriteLine($"____________________________________________");
            foreach (var item in items)
            {
                sw.WriteLine($"{item.Key}  x  {item.Count()} \t{item.Key.Preco * item.Count()} €");
            }
            sw.WriteLine($"\t\tTotal: {pedido.TotalPedido()} €");
            foreach (var item in pagamentos)
            {
                sw.WriteLine($"{item.MetodoPagamento.MetPagamento}: {item.Valor} €");
            }
            


            // Fechar o ficheiro e o stream
            sw.Close();
            fs.Close();
        }
    }
}
