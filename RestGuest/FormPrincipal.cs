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
    }
}
