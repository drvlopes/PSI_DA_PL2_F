
namespace RestGuest
{
    partial class FormGestaoIndividualRestaurante
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
            this.label7 = new System.Windows.Forms.Label();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.lbTrabalhadores = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTelemovel = new System.Windows.Forms.MaskedTextBox();
            this.tbCodPostal = new System.Windows.Forms.MaskedTextBox();
            this.mtbIndicativo = new System.Windows.Forms.MaskedTextBox();
            this.tbPosicao = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.btNovoTrabalhador = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbNomeTrabalhador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCategorias = new System.Windows.Forms.ListBox();
            this.cbItens = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Pesquisa por:";
            // 
            // btPesquisa
            // 
            this.btPesquisa.Location = new System.Drawing.Point(84, 449);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btPesquisa.TabIndex = 26;
            this.btPesquisa.Text = "Limpar";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(7, 424);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(230, 20);
            this.tbPesquisa.TabIndex = 25;
            this.tbPesquisa.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "Nome"});
            this.cbPesquisa.Location = new System.Drawing.Point(105, 393);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(132, 21);
            this.cbPesquisa.TabIndex = 24;
            this.cbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbPesquisa_SelectedIndexChanged);
            // 
            // lbTrabalhadores
            // 
            this.lbTrabalhadores.FormattingEnabled = true;
            this.lbTrabalhadores.Location = new System.Drawing.Point(6, 19);
            this.lbTrabalhadores.Name = "lbTrabalhadores";
            this.lbTrabalhadores.Size = new System.Drawing.Size(231, 368);
            this.lbTrabalhadores.TabIndex = 23;
            this.lbTrabalhadores.SelectedIndexChanged += new System.EventHandler(this.lbTrabalhadores_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTelemovel);
            this.groupBox1.Controls.Add(this.tbCodPostal);
            this.groupBox1.Controls.Add(this.mtbIndicativo);
            this.groupBox1.Controls.Add(this.tbPosicao);
            this.groupBox1.Controls.Add(this.tbSalario);
            this.groupBox1.Controls.Add(this.tbPais);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btRemover);
            this.groupBox1.Controls.Add(this.btNovoTrabalhador);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.tbRua);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbCidade);
            this.groupBox1.Controls.Add(this.tbNomeTrabalhador);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(263, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 298);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Trabalhador";
            // 
            // tbTelemovel
            // 
            this.tbTelemovel.Location = new System.Drawing.Point(122, 224);
            this.tbTelemovel.Mask = "999999999";
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.Size = new System.Drawing.Size(60, 20);
            this.tbTelemovel.TabIndex = 8;
            this.tbTelemovel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(82, 134);
            this.tbCodPostal.Mask = "9999-999";
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(52, 20);
            this.tbCodPostal.TabIndex = 5;
            // 
            // mtbIndicativo
            // 
            this.mtbIndicativo.Location = new System.Drawing.Point(82, 224);
            this.mtbIndicativo.Mask = "+999";
            this.mtbIndicativo.Name = "mtbIndicativo";
            this.mtbIndicativo.Size = new System.Drawing.Size(34, 20);
            this.mtbIndicativo.TabIndex = 38;
            // 
            // tbPosicao
            // 
            this.tbPosicao.Location = new System.Drawing.Point(82, 194);
            this.tbPosicao.Name = "tbPosicao";
            this.tbPosicao.Size = new System.Drawing.Size(100, 20);
            this.tbPosicao.TabIndex = 7;
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(82, 164);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(100, 20);
            this.tbSalario.TabIndex = 6;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(82, 104);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(230, 20);
            this.tbPais.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Pais:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Salário:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Posição:";
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(119, 255);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(100, 38);
            this.btRemover.TabIndex = 31;
            this.btRemover.Text = "Remover Trabalhador";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btNovoTrabalhador
            // 
            this.btNovoTrabalhador.Location = new System.Drawing.Point(9, 255);
            this.btNovoTrabalhador.Name = "btNovoTrabalhador";
            this.btNovoTrabalhador.Size = new System.Drawing.Size(100, 38);
            this.btNovoTrabalhador.TabIndex = 30;
            this.btNovoTrabalhador.Text = "Novo Trabalhador";
            this.btNovoTrabalhador.UseVisualStyleBackColor = true;
            this.btNovoTrabalhador.Click += new System.EventHandler(this.btNovoTrabalhador_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(229, 255);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(100, 38);
            this.btEditar.TabIndex = 29;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(82, 44);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(230, 20);
            this.tbRua.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telemóvel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cod-Postal:";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(82, 74);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(230, 20);
            this.tbCidade.TabIndex = 3;
            // 
            // tbNomeTrabalhador
            // 
            this.tbNomeTrabalhador.Location = new System.Drawing.Point(82, 14);
            this.tbNomeTrabalhador.Name = "tbNomeTrabalhador";
            this.tbNomeTrabalhador.Size = new System.Drawing.Size(230, 20);
            this.tbNomeTrabalhador.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label11.Location = new System.Drawing.Point(707, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 29);
            this.label11.TabIndex = 35;
            // 
            // lbCategorias
            // 
            this.lbCategorias.FormattingEnabled = true;
            this.lbCategorias.Location = new System.Drawing.Point(6, 19);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(227, 199);
            this.lbCategorias.TabIndex = 39;
            this.lbCategorias.SelectedIndexChanged += new System.EventHandler(this.lbCategorias_SelectedIndexChanged);
            // 
            // cbItens
            // 
            this.cbItens.FormattingEnabled = true;
            this.cbItens.Location = new System.Drawing.Point(6, 224);
            this.cbItens.Name = "cbItens";
            this.cbItens.Size = new System.Drawing.Size(227, 199);
            this.cbItens.TabIndex = 40;
            this.cbItens.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbItens_ItemCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTrabalhadores);
            this.groupBox2.Controls.Add(this.cbPesquisa);
            this.groupBox2.Controls.Add(this.tbPesquisa);
            this.groupBox2.Controls.Add(this.btPesquisa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 475);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Trabalhadores";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbCategorias);
            this.groupBox3.Controls.Add(this.cbItens);
            this.groupBox3.Location = new System.Drawing.Point(607, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 430);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gerir Menu";
            // 
            // FormGestaoIndividualRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormGestaoIndividualRestaurante";
            this.ShowIcon = false;
            this.Text = "Gestão Individual de Restaurante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.ListBox lbTrabalhadores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btNovoTrabalhador;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbNomeTrabalhador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPosicao;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbIndicativo;
        private System.Windows.Forms.ListBox lbCategorias;
        private System.Windows.Forms.CheckedListBox cbItens;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox tbTelemovel;
        private System.Windows.Forms.MaskedTextBox tbCodPostal;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}