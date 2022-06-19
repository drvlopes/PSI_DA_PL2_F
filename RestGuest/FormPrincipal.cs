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
         RestGuestContainer restGuest = new RestGuestContainer();
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGestaoClientes formGestaoClientes = new FormGestaoClientes();
            this.Enabled = false;
            formGestaoClientes.Closed += (s, args) => this.Enabled = true;
            formGestaoClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGestaoGeralRestaurantes formGestaoGeralRestaurantes = new FormGestaoGeralRestaurantes();
            this.Enabled = false;
            formGestaoGeralRestaurantes.Closed += (s, args) => this.Enabled = true;
            formGestaoGeralRestaurantes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(toolStripComboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Tem de selecionar um restuarante para Aceder", "Seleção Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int restaurante = toolStripComboBox1.SelectedIndex;
            FormGestaoIndividualRestaurante formGestaoIndividualRestaurantes = new FormGestaoIndividualRestaurante(restaurante);
            this.Enabled = false;
            formGestaoIndividualRestaurantes.Closed += (s,args) => this.Enabled = true; 
            formGestaoIndividualRestaurantes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormGestaoMenu formGestaoMenu = new FormGestaoMenu();
            this.Enabled = false;
            formGestaoMenu.Closed += (s, args) => this.Enabled = true;
            formGestaoMenu.Show();
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
            var restaurantes = restGuest.Restaurantes.ToList();
            if(restaurantes == null)
                return;

            foreach (var item in restaurantes)
            {
                toolStripComboBox1.Items.Add(item.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
