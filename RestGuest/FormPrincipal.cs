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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            var array = new string[4] { "Recebido", "Em Processamento", "Cancelado", "Concluído"};
            RestGuestContainer restGuest = new RestGuestContainer();
            var estados = restGuest.Estados.ToList();
            if(estados.Count == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Estado estado = new Estado();
                    estado.Status = array[i];
                    restGuest.Estados.Add(estado);
                    restGuest.SaveChanges();
                }
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGestaoClientes formGestaoClientes = new FormGestaoClientes();
            this.Enabled = false;
            formGestaoClientes.Closed += (s, args) => this.Enabled = true;
            formGestaoClientes.Closed += (s, args) => clearLabels();
            formGestaoClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGestaoGeralRestaurantes formGestaoGeralRestaurantes = new FormGestaoGeralRestaurantes();
            this.Enabled = false;
            formGestaoGeralRestaurantes.Closed += (s, args) => this.Enabled = true;
            formGestaoGeralRestaurantes.Closed += (s, args) => clearLabels();
            formGestaoGeralRestaurantes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione o restaurante para aceder à gestão de restaurante", "RestGest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Restaurante restaurante = toolStripComboBox1.SelectedItem as Restaurante;

            FormGestaoIndividualRestaurante formGestaoIndividualRestaurantes = new FormGestaoIndividualRestaurante(restaurante);
            this.Enabled = false;
            formGestaoIndividualRestaurantes.Closed += (s,args) => this.Enabled = true; 
            formGestaoIndividualRestaurantes.Closed += (s,args) => clearLabels();
            formGestaoIndividualRestaurantes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormGestaoMenu formGestaoMenu = new FormGestaoMenu();
            this.Enabled = false;
            formGestaoMenu.Closed += (s, args) => this.Enabled = true;
            formGestaoMenu.Closed += (s, args) => clearLabels();
            formGestaoMenu.Show();
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            RestGuestContainer restGuest = new RestGuestContainer();
            toolStripComboBox1.Items.Clear();
            label3.Text = "";
            label4.Text = "";

            var restaurantes = restGuest.Restaurantes.ToList();

            if(restaurantes == null)
                return;

            foreach (var item in restaurantes)
            {
                toolStripComboBox1.Items.Add(item);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox2.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione o restaurante e funcionário para aceder à gestão de pedidos", "RestGest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Restaurante restaurante = toolStripComboBox1.SelectedItem as Restaurante;
            Trabalhador trabalhador = toolStripComboBox2.SelectedItem as Trabalhador;
                

            FormGestaoPedidos formGestaoPedidos = new FormGestaoPedidos(restaurante, trabalhador);
            this.Enabled = false;
            formGestaoPedidos.Closed += (s, args) => this.Enabled = true;
            formGestaoPedidos.Closed += (s, args) => clearLabels();
            formGestaoPedidos.Show();
        }

        private void toolStripComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            RestGuestContainer restGuest = new RestGuestContainer();
            toolStripComboBox2.Items.Clear();

            if (toolStripComboBox1.SelectedItem == null)
                return;
            Restaurante restaurante = toolStripComboBox1.SelectedItem as Restaurante;

            label3.Text = restaurante.Nome;


            var funcionarios = restGuest.Pessoas.OfType<Trabalhador>().Where(p => p.IdRestaurante == restaurante.Id);
            if (funcionarios == null)
                return;

            foreach (var item in funcionarios)
            {
                toolStripComboBox2.Items.Add(item);
            }
        }

        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            label4.Text = "";

            if (toolStripComboBox2.SelectedItem == null)
                return;
            Trabalhador trabalhador = toolStripComboBox2.SelectedItem as Trabalhador;
            label4.Text = trabalhador.Nome;


        }

        private void clearLabels()
        {
            if(toolStripComboBox1.SelectedIndex == -1)
            label3.Text = "";
            if(toolStripComboBox2.SelectedIndex == -1)
            label4.Text = "";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            toolStripComboBox1_DropDownClosed(sender, e);
        }

        private void gerirRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void gestãoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void gestãoDeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }
    }
}
