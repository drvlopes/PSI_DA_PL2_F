namespace RestGuest
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btGestaoIndividualRestaurante = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.restaurantesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // restaurantesToolStripMenuItem
            // 
            this.restaurantesToolStripMenuItem.Checked = true;
            this.restaurantesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.restaurantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.restaurantesToolStripMenuItem.Name = "restaurantesToolStripMenuItem";
            this.restaurantesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.restaurantesToolStripMenuItem.Text = "Restaurantes";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 126);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestão de Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(188, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 126);
            this.button2.TabIndex = 2;
            this.button2.Text = "Gestão Global de Restaurantes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btGestaoIndividualRestaurante
            // 
            this.btGestaoIndividualRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btGestaoIndividualRestaurante.Location = new System.Drawing.Point(320, 305);
            this.btGestaoIndividualRestaurante.Name = "btGestaoIndividualRestaurante";
            this.btGestaoIndividualRestaurante.Size = new System.Drawing.Size(126, 126);
            this.btGestaoIndividualRestaurante.TabIndex = 3;
            this.btGestaoIndividualRestaurante.Text = "Gestão Individual Restaurante";
            this.btGestaoIndividualRestaurante.UseVisualStyleBackColor = true;
            this.btGestaoIndividualRestaurante.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(452, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 126);
            this.button4.TabIndex = 4;
            this.button4.Text = "Gestão de Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(584, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 126);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 443);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btGestaoIndividualRestaurante);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "RestGest";
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btGestaoIndividualRestaurante;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

