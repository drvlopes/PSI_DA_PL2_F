namespace RestGuest
{
    partial class FormGestaoClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbIndicativo = new System.Windows.Forms.MaskedTextBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.btNovoCliente = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTelemovel = new System.Windows.Forms.TextBox();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbClientes
            // 
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 16;
            this.lbClientes.Location = new System.Drawing.Point(16, 31);
            this.lbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(517, 516);
            this.lbClientes.TabIndex = 0;
            this.lbClientes.SelectedIndexChanged += new System.EventHandler(this.lbClientes_SelectedIndexChanged);
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "Nome",
            "Telemovel",
            "NIF"});
            this.cbPesquisa.Location = new System.Drawing.Point(703, 415);
            this.cbPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(160, 24);
            this.cbPesquisa.TabIndex = 10;
            this.cbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbPesquisa_SelectedIndexChanged);
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(547, 448);
            this.tbPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(316, 22);
            this.tbPesquisa.TabIndex = 11;
            this.tbPesquisa.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 418);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisa por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbIndicativo);
            this.groupBox1.Controls.Add(this.btRemover);
            this.groupBox1.Controls.Add(this.btNovoCliente);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTelemovel);
            this.groupBox1.Controls.Add(this.tbNif);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbPais);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCodPostal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCidade);
            this.groupBox1.Controls.Add(this.tbRua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(543, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(681, 384);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // mtbIndicativo
            // 
            this.mtbIndicativo.Location = new System.Drawing.Point(119, 244);
            this.mtbIndicativo.Margin = new System.Windows.Forms.Padding(4);
            this.mtbIndicativo.Mask = "+999";
            this.mtbIndicativo.Name = "mtbIndicativo";
            this.mtbIndicativo.Size = new System.Drawing.Size(48, 26);
            this.mtbIndicativo.TabIndex = 17;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(261, 311);
            this.btRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(177, 53);
            this.btRemover.TabIndex = 16;
            this.btRemover.Text = "Remover Cliente";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btNovoCliente
            // 
            this.btNovoCliente.Location = new System.Drawing.Point(12, 311);
            this.btNovoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btNovoCliente.Name = "btNovoCliente";
            this.btNovoCliente.Size = new System.Drawing.Size(177, 53);
            this.btNovoCliente.TabIndex = 8;
            this.btNovoCliente.Text = "Novo Cliente";
            this.btNovoCliente.UseVisualStyleBackColor = true;
            this.btNovoCliente.Click += new System.EventHandler(this.btNovoCliente_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(496, 311);
            this.btEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(177, 53);
            this.btEditar.TabIndex = 6;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(511, 108);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(32, 20);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "€ 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total Gasto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telemóvel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "NIF:";
            // 
            // tbTelemovel
            // 
            this.tbTelemovel.Location = new System.Drawing.Point(176, 244);
            this.tbTelemovel.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.Size = new System.Drawing.Size(121, 26);
            this.tbTelemovel.TabIndex = 7;
            // 
            // tbNif
            // 
            this.tbNif.Location = new System.Drawing.Point(117, 208);
            this.tbNif.Margin = new System.Windows.Forms.Padding(4);
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(180, 26);
            this.tbNif.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pais:";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(117, 172);
            this.tbPais.Margin = new System.Windows.Forms.Padding(4);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(180, 26);
            this.tbPais.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cod-postal:";
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(117, 137);
            this.tbCodPostal.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(180, 26);
            this.tbCodPostal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cidade:";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(117, 101);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(180, 26);
            this.tbCidade.TabIndex = 3;
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(117, 65);
            this.tbRua.Margin = new System.Windows.Forms.Padding(4);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(320, 26);
            this.tbRua.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rua:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(117, 30);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(540, 26);
            this.tbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // btPesquisa
            // 
            this.btPesquisa.Location = new System.Drawing.Point(643, 480);
            this.btPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(127, 42);
            this.btPesquisa.TabIndex = 12;
            this.btPesquisa.Text = "Limpar pesquisa";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 559);
            this.Controls.Add(this.btPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.cbPesquisa);
            this.Controls.Add(this.lbClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormGestaoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTelemovel;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btNovoCliente;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.MaskedTextBox mtbIndicativo;
    }
}