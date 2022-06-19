namespace RestGuest
{
    partial class FormGestaoPedidos
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
            this.lbPedidos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.cbEstadoLista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restGuestDataSet = new RestGuest.RestGuestDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFuncionario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstadoPedido = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btNovoPedido = new System.Windows.Forms.Button();
            this.btRemoverItem = new System.Windows.Forms.Button();
            this.btAdicionarItem = new System.Windows.Forms.Button();
            this.lbItemsEscolhidos = new System.Windows.Forms.ListBox();
            this.lbListaItems = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btPagar = new System.Windows.Forms.Button();
            this.lbPagar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbPagar = new System.Windows.Forms.ComboBox();
            this.mtbPagar = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbIngredientes = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btExportar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restGuestDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPedidos
            // 
            this.lbPedidos.FormattingEnabled = true;
            this.lbPedidos.Location = new System.Drawing.Point(6, 40);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(246, 420);
            this.lbPedidos.TabIndex = 0;
            this.lbPedidos.SelectedIndexChanged += new System.EventHandler(this.lbPedidos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btPesquisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbPesquisa);
            this.groupBox1.Controls.Add(this.tbPesquisa);
            this.groupBox1.Controls.Add(this.cbEstadoLista);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbPedidos);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 547);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Pedidos";
            // 
            // btPesquisa
            // 
            this.btPesquisa.Location = new System.Drawing.Point(92, 518);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btPesquisa.TabIndex = 16;
            this.btPesquisa.Text = "Limpar pesquisa";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pesquisa por:";
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "Nome Cliente",
            "Nome Funcionário",
            "NIF Cliente",
            "Numero de pedido"});
            this.cbPesquisa.Location = new System.Drawing.Point(116, 466);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(136, 21);
            this.cbPesquisa.TabIndex = 14;
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(55, 493);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(148, 20);
            this.tbPesquisa.TabIndex = 15;
            // 
            // cbEstadoLista
            // 
            this.cbEstadoLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoLista.FormattingEnabled = true;
            this.cbEstadoLista.Location = new System.Drawing.Point(110, 16);
            this.cbEstadoLista.Name = "cbEstadoLista";
            this.cbEstadoLista.Size = new System.Drawing.Size(142, 21);
            this.cbEstadoLista.TabIndex = 2;
            this.cbEstadoLista.SelectedIndexChanged += new System.EventHandler(this.cbEstadoLista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado:";
            // 
            // restGuestDataSet
            // 
            this.restGuestDataSet.DataSetName = "RestGuestDataSet";
            this.restGuestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(187, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Funcionário:";
            // 
            // lbFuncionario
            // 
            this.lbFuncionario.AutoSize = true;
            this.lbFuncionario.Location = new System.Drawing.Point(98, 18);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(0, 13);
            this.lbFuncionario.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(276, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Valor Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "0 €";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numQuantidade);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbCategoria);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbEstadoPedido);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.btNovoPedido);
            this.groupBox3.Controls.Add(this.btRemoverItem);
            this.groupBox3.Controls.Add(this.btAdicionarItem);
            this.groupBox3.Controls.Add(this.lbItemsEscolhidos);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbListaItems);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbFuncionario);
            this.groupBox3.Location = new System.Drawing.Point(277, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 390);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Pedido";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numQuantidade.Location = new System.Drawing.Point(200, 130);
            this.numQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(54, 20);
            this.numQuantidade.TabIndex = 7;
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(187, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Quantidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(94, 48);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(90, 21);
            this.cbCategoria.TabIndex = 14;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(278, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado:";
            // 
            // cbEstadoPedido
            // 
            this.cbEstadoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoPedido.FormattingEnabled = true;
            this.cbEstadoPedido.Location = new System.Drawing.Point(340, 363);
            this.cbEstadoPedido.Name = "cbEstadoPedido";
            this.cbEstadoPedido.Size = new System.Drawing.Size(111, 21);
            this.cbEstadoPedido.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(248, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btNovoPedido
            // 
            this.btNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoPedido.Location = new System.Drawing.Point(6, 345);
            this.btNovoPedido.Name = "btNovoPedido";
            this.btNovoPedido.Size = new System.Drawing.Size(100, 38);
            this.btNovoPedido.TabIndex = 10;
            this.btNovoPedido.Text = "Novo Pedido";
            this.btNovoPedido.UseVisualStyleBackColor = true;
            this.btNovoPedido.Click += new System.EventHandler(this.btNovoPedido_Click);
            // 
            // btRemoverItem
            // 
            this.btRemoverItem.Location = new System.Drawing.Point(213, 243);
            this.btRemoverItem.Name = "btRemoverItem";
            this.btRemoverItem.Size = new System.Drawing.Size(30, 30);
            this.btRemoverItem.TabIndex = 7;
            this.btRemoverItem.Text = "<<";
            this.btRemoverItem.UseVisualStyleBackColor = true;
            // 
            // btAdicionarItem
            // 
            this.btAdicionarItem.Location = new System.Drawing.Point(213, 156);
            this.btAdicionarItem.Name = "btAdicionarItem";
            this.btAdicionarItem.Size = new System.Drawing.Size(30, 30);
            this.btAdicionarItem.TabIndex = 4;
            this.btAdicionarItem.Text = ">>";
            this.btAdicionarItem.UseVisualStyleBackColor = true;
            this.btAdicionarItem.Click += new System.EventHandler(this.btAdicionarItem_Click);
            // 
            // lbItemsEscolhidos
            // 
            this.lbItemsEscolhidos.FormattingEnabled = true;
            this.lbItemsEscolhidos.Location = new System.Drawing.Point(273, 75);
            this.lbItemsEscolhidos.Name = "lbItemsEscolhidos";
            this.lbItemsEscolhidos.Size = new System.Drawing.Size(178, 264);
            this.lbItemsEscolhidos.TabIndex = 6;
            // 
            // lbListaItems
            // 
            this.lbListaItems.FormattingEnabled = true;
            this.lbListaItems.Location = new System.Drawing.Point(6, 75);
            this.lbListaItems.Name = "lbListaItems";
            this.lbListaItems.Size = new System.Drawing.Size(178, 264);
            this.lbListaItems.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btPagar);
            this.groupBox2.Controls.Add(this.lbPagar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbPagar);
            this.groupBox2.Controls.Add(this.mtbPagar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(777, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 167);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagamento";
            // 
            // btPagar
            // 
            this.btPagar.Location = new System.Drawing.Point(42, 123);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(100, 38);
            this.btPagar.TabIndex = 20;
            this.btPagar.Text = "Pagar";
            this.btPagar.UseVisualStyleBackColor = true;
            // 
            // lbPagar
            // 
            this.lbPagar.AutoSize = true;
            this.lbPagar.Location = new System.Drawing.Point(115, 22);
            this.lbPagar.Name = "lbPagar";
            this.lbPagar.Size = new System.Drawing.Size(22, 13);
            this.lbPagar.TabIndex = 19;
            this.lbPagar.Text = "0 €";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(6, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Metodo de Pagamento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(6, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Valor em Falta:";
            // 
            // cbPagar
            // 
            this.cbPagar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagar.FormattingEnabled = true;
            this.cbPagar.Location = new System.Drawing.Point(6, 98);
            this.cbPagar.Name = "cbPagar";
            this.cbPagar.Size = new System.Drawing.Size(151, 21);
            this.cbPagar.TabIndex = 2;
            // 
            // mtbPagar
            // 
            this.mtbPagar.Location = new System.Drawing.Point(75, 48);
            this.mtbPagar.Mask = "€9999.99";
            this.mtbPagar.Name = "mtbPagar";
            this.mtbPagar.Size = new System.Drawing.Size(67, 20);
            this.mtbPagar.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "A Pagar:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbIngredientes);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.pbImagem);
            this.groupBox4.Location = new System.Drawing.Point(777, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 217);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados do Item";
            // 
            // lbIngredientes
            // 
            this.lbIngredientes.AutoSize = true;
            this.lbIngredientes.Location = new System.Drawing.Point(6, 153);
            this.lbIngredientes.Name = "lbIngredientes";
            this.lbIngredientes.Size = new System.Drawing.Size(0, 13);
            this.lbIngredientes.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(6, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Ingredientes:";
            // 
            // pbImagem
            // 
            this.pbImagem.InitialImage = null;
            this.pbImagem.Location = new System.Drawing.Point(6, 19);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(119, 107);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 38;
            this.pbImagem.TabStop = false;
            // 
            // btExportar
            // 
            this.btExportar.Location = new System.Drawing.Point(277, 414);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(100, 38);
            this.btExportar.TabIndex = 6;
            this.btExportar.Text = "Exportar Fatura";
            this.btExportar.UseVisualStyleBackColor = true;
            // 
            // FormGestaoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 557);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGestaoPedidos";
            this.Text = "Gestão de Pedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restGuestDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEstadoLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Label lbFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btRemoverItem;
        private System.Windows.Forms.Button btAdicionarItem;
        private System.Windows.Forms.ListBox lbItemsEscolhidos;
        private System.Windows.Forms.ListBox lbListaItems;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btNovoPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstadoPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtbPagar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Label lbPagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbPagar;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label lbIngredientes;
        private RestGuestDataSet restGuestDataSet;
    }
}