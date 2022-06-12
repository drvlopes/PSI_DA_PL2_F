namespace RestGuest
{
    partial class FormGestaoMenu
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbIngredientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btImagem = new System.Windows.Forms.Button();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.cbItemsMenu = new System.Windows.Forms.CheckedListBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Pesquisa por:";
            // 
            // btPesquisa
            // 
            this.btPesquisa.Location = new System.Drawing.Point(93, 439);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btPesquisa.TabIndex = 25;
            this.btPesquisa.Text = "Limpar pesquisa";
            this.btPesquisa.UseVisualStyleBackColor = true;
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(41, 413);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(182, 20);
            this.tbPesquisa.TabIndex = 24;
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "Nome"});
            this.cbPesquisa.Location = new System.Drawing.Point(110, 386);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(143, 21);
            this.cbPesquisa.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Preço:";
            // 
            // tbIngredientes
            // 
            this.tbIngredientes.Location = new System.Drawing.Point(352, 57);
            this.tbIngredientes.Name = "tbIngredientes";
            this.tbIngredientes.Size = new System.Drawing.Size(222, 20);
            this.tbIngredientes.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ingredientes:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(352, 29);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(222, 20);
            this.tbNome.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome:";
            // 
            // pbImagem
            // 
            this.pbImagem.InitialImage = global::RestGuest.Properties.Resources.Screenshot_74;
            this.pbImagem.Location = new System.Drawing.Point(406, 154);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(119, 107);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 37;
            this.pbImagem.TabStop = false;
            // 
            // btImagem
            // 
            this.btImagem.Location = new System.Drawing.Point(406, 267);
            this.btImagem.Name = "btImagem";
            this.btImagem.Size = new System.Drawing.Size(119, 23);
            this.btImagem.TabIndex = 38;
            this.btImagem.Text = "Carregar Imagem";
            this.btImagem.UseVisualStyleBackColor = true;
            this.btImagem.Click += new System.EventHandler(this.btImagem_Click);
            // 
            // mtbPreco
            // 
            this.mtbPreco.Location = new System.Drawing.Point(352, 85);
            this.mtbPreco.Mask = "€999.99";
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(54, 20);
            this.mtbPreco.TabIndex = 39;
            // 
            // cbItemsMenu
            // 
            this.cbItemsMenu.FormattingEnabled = true;
            this.cbItemsMenu.Location = new System.Drawing.Point(12, 12);
            this.cbItemsMenu.Name = "cbItemsMenu";
            this.cbItemsMenu.Size = new System.Drawing.Size(241, 364);
            this.cbItemsMenu.TabIndex = 40;
            this.cbItemsMenu.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbItemsMenu_ItemCheck);
            this.cbItemsMenu.SelectedIndexChanged += new System.EventHandler(this.cbItemsMenu_SelectedIndexChanged);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(304, 296);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(104, 38);
            this.btAdicionar.TabIndex = 33;
            this.btAdicionar.Text = "Novo Item de Menu";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(413, 296);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(104, 38);
            this.btEditar.TabIndex = 32;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(523, 296);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(104, 38);
            this.btRemover.TabIndex = 34;
            this.btRemover.Text = "Remover Item de Menu";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(352, 113);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 42;
            // 
            // FormGestaoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.cbItemsMenu);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.btImagem);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIngredientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btPesquisa);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.cbPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGestaoMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestaoMenu";
            this.Shown += new System.EventHandler(this.FormGestaoMenu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIngredientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btImagem;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.CheckedListBox cbItemsMenu;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}