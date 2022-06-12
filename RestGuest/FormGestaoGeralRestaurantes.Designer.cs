﻿namespace RestGuest
{
    partial class FormGestaoGeralRestaurantes
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
            this.lbRestaurantes = new System.Windows.Forms.ListBox();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNomeRestaurante = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.cbMetodosPagamento = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAdicionarCategoria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btAdicionarCategoria = new System.Windows.Forms.Button();
            this.btRemoverCategoria = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btRemoverMetodo = new System.Windows.Forms.Button();
            this.btAdicionarPagamento = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMetodoPagamento = new System.Windows.Forms.TextBox();
            this.cbCategorias = new System.Windows.Forms.CheckedListBox();
            this.btRemoverRestaurante = new System.Windows.Forms.Button();
            this.btNovoRestaurante = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRestaurantes
            // 
            this.lbRestaurantes.FormattingEnabled = true;
            this.lbRestaurantes.ItemHeight = 16;
            this.lbRestaurantes.Location = new System.Drawing.Point(16, 15);
            this.lbRestaurantes.Margin = new System.Windows.Forms.Padding(4);
            this.lbRestaurantes.Name = "lbRestaurantes";
            this.lbRestaurantes.Size = new System.Drawing.Size(360, 452);
            this.lbRestaurantes.TabIndex = 0;
            this.lbRestaurantes.SelectedIndexChanged += new System.EventHandler(this.lbRestaurantes_SelectedIndexChanged);
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "Nome"});
            this.cbPesquisa.Location = new System.Drawing.Point(151, 484);
            this.cbPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(189, 24);
            this.cbPesquisa.TabIndex = 1;
            this.cbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbPesquisa_SelectedIndexChanged);
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(29, 517);
            this.tbPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(311, 22);
            this.tbPesquisa.TabIndex = 2;
            this.tbPesquisa.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
            // 
            // btPesquisa
            // 
            this.btPesquisa.Location = new System.Drawing.Point(128, 549);
            this.btPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(100, 28);
            this.btPesquisa.TabIndex = 3;
            this.btPesquisa.Text = "Limpar pesquisa";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cod-Postal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pais:";
            // 
            // tbNomeRestaurante
            // 
            this.tbNomeRestaurante.Location = new System.Drawing.Point(113, 36);
            this.tbNomeRestaurante.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomeRestaurante.Name = "tbNomeRestaurante";
            this.tbNomeRestaurante.Size = new System.Drawing.Size(305, 22);
            this.tbNomeRestaurante.TabIndex = 1;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(113, 188);
            this.tbPais.Margin = new System.Windows.Forms.Padding(4);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(305, 22);
            this.tbPais.TabIndex = 5;
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(113, 150);
            this.tbCodPostal.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(305, 22);
            this.tbCodPostal.TabIndex = 4;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(113, 112);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(305, 22);
            this.tbCidade.TabIndex = 3;
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(113, 74);
            this.tbRua.Margin = new System.Windows.Forms.Padding(4);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(305, 22);
            this.tbRua.TabIndex = 2;
            // 
            // cbMetodosPagamento
            // 
            this.cbMetodosPagamento.CheckOnClick = true;
            this.cbMetodosPagamento.FormattingEnabled = true;
            this.cbMetodosPagamento.Location = new System.Drawing.Point(389, 320);
            this.cbMetodosPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.cbMetodosPagamento.Name = "cbMetodosPagamento";
            this.cbMetodosPagamento.Size = new System.Drawing.Size(240, 174);
            this.cbMetodosPagamento.TabIndex = 14;
            this.cbMetodosPagamento.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbMetodosPagamento_ItemCheck);
            this.cbMetodosPagamento.SelectedIndexChanged += new System.EventHandler(this.cbMetodosPagamento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Métodos de Pagamento";
            // 
            // tbAdicionarCategoria
            // 
            this.tbAdicionarCategoria.Location = new System.Drawing.Point(900, 267);
            this.tbAdicionarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdicionarCategoria.Name = "tbAdicionarCategoria";
            this.tbAdicionarCategoria.Size = new System.Drawing.Size(215, 22);
            this.tbAdicionarCategoria.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(827, 268);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nome:";
            // 
            // btAdicionarCategoria
            // 
            this.btAdicionarCategoria.Location = new System.Drawing.Point(831, 299);
            this.btAdicionarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btAdicionarCategoria.Name = "btAdicionarCategoria";
            this.btAdicionarCategoria.Size = new System.Drawing.Size(139, 28);
            this.btAdicionarCategoria.TabIndex = 20;
            this.btAdicionarCategoria.Text = "Adicionar";
            this.btAdicionarCategoria.UseVisualStyleBackColor = true;
            this.btAdicionarCategoria.Click += new System.EventHandler(this.btAdicionarCategoria_Click);
            // 
            // btRemoverCategoria
            // 
            this.btRemoverCategoria.Enabled = false;
            this.btRemoverCategoria.Location = new System.Drawing.Point(977, 299);
            this.btRemoverCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btRemoverCategoria.Name = "btRemoverCategoria";
            this.btRemoverCategoria.Size = new System.Drawing.Size(139, 28);
            this.btRemoverCategoria.TabIndex = 21;
            this.btRemoverCategoria.Text = "Remover";
            this.btRemoverCategoria.UseVisualStyleBackColor = true;
<<<<<<< Updated upstream
            this.btRemoverCategoria.Click += new System.EventHandler(this.btRemoverCategoria_Click);
=======

>>>>>>> Stashed changes
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 485);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Pesquisa por:";
            // 
            // btRemoverMetodo
            // 
            this.btRemoverMetodo.Enabled = false;
            this.btRemoverMetodo.Location = new System.Drawing.Point(520, 555);
            this.btRemoverMetodo.Margin = new System.Windows.Forms.Padding(4);
            this.btRemoverMetodo.Name = "btRemoverMetodo";
            this.btRemoverMetodo.Size = new System.Drawing.Size(111, 28);
            this.btRemoverMetodo.TabIndex = 27;
            this.btRemoverMetodo.Text = "Remover";
            this.btRemoverMetodo.UseVisualStyleBackColor = true;
            this.btRemoverMetodo.Click += new System.EventHandler(this.btRemoverMetodo_Click);
            // 
            // btAdicionarPagamento
            // 
            this.btAdicionarPagamento.Location = new System.Drawing.Point(389, 555);
            this.btAdicionarPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btAdicionarPagamento.Name = "btAdicionarPagamento";
            this.btAdicionarPagamento.Size = new System.Drawing.Size(111, 28);
            this.btAdicionarPagamento.TabIndex = 26;
            this.btAdicionarPagamento.Text = "Adicionar";
            this.btAdicionarPagamento.UseVisualStyleBackColor = true;
            this.btAdicionarPagamento.Click += new System.EventHandler(this.btAdicionarPagamento_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 524);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nome:";
            // 
            // tbMetodoPagamento
            // 
            this.tbMetodoPagamento.Location = new System.Drawing.Point(463, 523);
            this.tbMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.tbMetodoPagamento.Name = "tbMetodoPagamento";
            this.tbMetodoPagamento.Size = new System.Drawing.Size(167, 22);
            this.tbMetodoPagamento.TabIndex = 24;
            // 
            // cbCategorias
            // 
            this.cbCategorias.CheckOnClick = true;
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(831, 15);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(284, 242);
            this.cbCategorias.TabIndex = 28;
            this.cbCategorias.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbCategorias_ItemCheck);
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // btRemoverRestaurante
            // 
            this.btRemoverRestaurante.Location = new System.Drawing.Point(151, 220);
            this.btRemoverRestaurante.Margin = new System.Windows.Forms.Padding(4);
            this.btRemoverRestaurante.Name = "btRemoverRestaurante";
            this.btRemoverRestaurante.Size = new System.Drawing.Size(139, 47);
            this.btRemoverRestaurante.TabIndex = 31;
            this.btRemoverRestaurante.Text = "Remover Restaurante";
            this.btRemoverRestaurante.UseVisualStyleBackColor = true;
            this.btRemoverRestaurante.Click += new System.EventHandler(this.btRemoverRestaurante_Click);
            // 
            // btNovoRestaurante
            // 
<<<<<<< Updated upstream
            this.btNovoRestaurante.Location = new System.Drawing.Point(6, 179);
            this.btNovoRestaurante.Name = "btNovoRestaurante";
            this.btNovoRestaurante.Size = new System.Drawing.Size(104, 38);
            this.btNovoRestaurante.TabIndex = 30;
            this.btNovoRestaurante.Text = "Novo Restaurante";
            this.btNovoRestaurante.UseVisualStyleBackColor = true;
            this.btNovoRestaurante.Click += new System.EventHandler(this.btNovoRestaurante_Click);
=======
            this.btNovoCliente.Location = new System.Drawing.Point(8, 220);
            this.btNovoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btNovoCliente.Name = "btNovoCliente";
            this.btNovoCliente.Size = new System.Drawing.Size(139, 47);
            this.btNovoCliente.TabIndex = 30;
            this.btNovoCliente.Text = "Novo Restaurante";
            this.btNovoCliente.UseVisualStyleBackColor = true;
            this.btNovoCliente.Click += new System.EventHandler(this.btNovoCliente_Click);
>>>>>>> Stashed changes
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(293, 220);
            this.btEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(139, 47);
            this.btEditar.TabIndex = 29;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRemoverRestaurante);
            this.groupBox1.Controls.Add(this.btNovoRestaurante);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.tbRua);
            this.groupBox1.Controls.Add(this.tbCidade);
            this.groupBox1.Controls.Add(this.tbCodPostal);
            this.groupBox1.Controls.Add(this.tbPais);
            this.groupBox1.Controls.Add(this.tbNomeRestaurante);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(385, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(437, 277);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Restaurante";
            // 
            // FormGestaoGeralRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btRemoverMetodo);
            this.Controls.Add(this.btRemoverCategoria);
            this.Controls.Add(this.btAdicionarPagamento);
            this.Controls.Add(this.btAdicionarCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMetodoPagamento);
            this.Controls.Add(this.tbAdicionarCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMetodosPagamento);
            this.Controls.Add(this.btPesquisa);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.cbPesquisa);
            this.Controls.Add(this.lbRestaurantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormGestaoGeralRestaurantes";
            this.Text = "FormGestaoGeralRestaurantes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRestaurantes;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNomeRestaurante;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.CheckedListBox cbMetodosPagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAdicionarCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAdicionarCategoria;
        private System.Windows.Forms.Button btRemoverCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btRemoverMetodo;
        private System.Windows.Forms.Button btAdicionarPagamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMetodoPagamento;
        private System.Windows.Forms.CheckedListBox cbCategorias;
        private System.Windows.Forms.Button btRemoverRestaurante;
        private System.Windows.Forms.Button btNovoRestaurante;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}