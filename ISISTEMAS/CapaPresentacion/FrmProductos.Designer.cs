namespace CapaPresentacion
{
    partial class FrmProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtCantP = new System.Windows.Forms.TextBox();
            this.txtPrecioP = new System.Windows.Forms.TextBox();
            this.txtDescP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.btnRegistrarP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.btnEliProd = new System.Windows.Forms.Button();
            this.btnNuevoProd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbtnContado = new System.Windows.Forms.RadioButton();
            this.rdbtnCredito = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblNomPrE = new System.Windows.Forms.Label();
            this.lblPreE = new System.Windows.Forms.Label();
            this.lblCanE = new System.Windows.Forms.Label();
            this.lblCatE = new System.Windows.Forms.Label();
            this.lblDescE = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 41);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "INFINITY LABS";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaPresentacion.Properties.Resources.infinity;
            this.pictureBox6.Location = new System.Drawing.Point(10, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(764, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.minimize;
            this.pictureBox4.Location = new System.Drawing.Point(729, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(32, 174);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(158, 20);
            this.txtNombreP.TabIndex = 1;
            // 
            // txtCantP
            // 
            this.txtCantP.Location = new System.Drawing.Point(32, 294);
            this.txtCantP.Name = "txtCantP";
            this.txtCantP.Size = new System.Drawing.Size(158, 20);
            this.txtCantP.TabIndex = 2;
            // 
            // txtPrecioP
            // 
            this.txtPrecioP.Location = new System.Drawing.Point(32, 235);
            this.txtPrecioP.Name = "txtPrecioP";
            this.txtPrecioP.Size = new System.Drawing.Size(158, 20);
            this.txtPrecioP.TabIndex = 3;
            // 
            // txtDescP
            // 
            this.txtDescP.Location = new System.Drawing.Point(32, 422);
            this.txtDescP.Name = "txtDescP";
            this.txtDescP.Size = new System.Drawing.Size(158, 20);
            this.txtDescP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label2.Location = new System.Drawing.Point(28, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom del Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label3.Location = new System.Drawing.Point(28, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label4.Location = new System.Drawing.Point(28, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label5.Location = new System.Drawing.Point(28, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripcion:";
            // 
            // tablaProductos
            // 
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Location = new System.Drawing.Point(214, 110);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.Size = new System.Drawing.Size(547, 211);
            this.tablaProductos.TabIndex = 11;
            this.tablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellContentClick);
            // 
            // btnRegistrarP
            // 
            this.btnRegistrarP.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarP.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarP.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarP.Location = new System.Drawing.Point(232, 336);
            this.btnRegistrarP.Name = "btnRegistrarP";
            this.btnRegistrarP.Size = new System.Drawing.Size(110, 40);
            this.btnRegistrarP.TabIndex = 12;
            this.btnRegistrarP.Text = "Registrar";
            this.btnRegistrarP.UseVisualStyleBackColor = false;
            this.btnRegistrarP.Click += new System.EventHandler(this.btnRegistrarP_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 10);
            this.panel2.TabIndex = 13;
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProd.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.ForeColor = System.Drawing.Color.White;
            this.btnEditarProd.Location = new System.Drawing.Point(368, 336);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(110, 40);
            this.btnEditarProd.TabIndex = 15;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.UseVisualStyleBackColor = false;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // btnEliProd
            // 
            this.btnEliProd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliProd.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliProd.ForeColor = System.Drawing.Color.White;
            this.btnEliProd.Location = new System.Drawing.Point(501, 336);
            this.btnEliProd.Name = "btnEliProd";
            this.btnEliProd.Size = new System.Drawing.Size(110, 40);
            this.btnEliProd.TabIndex = 16;
            this.btnEliProd.Text = "Eliminar";
            this.btnEliProd.UseVisualStyleBackColor = false;
            this.btnEliProd.Click += new System.EventHandler(this.btnEliProd_Click);
            // 
            // btnNuevoProd
            // 
            this.btnNuevoProd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNuevoProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProd.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProd.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProd.Location = new System.Drawing.Point(635, 336);
            this.btnNuevoProd.Name = "btnNuevoProd";
            this.btnNuevoProd.Size = new System.Drawing.Size(110, 40);
            this.btnNuevoProd.TabIndex = 17;
            this.btnNuevoProd.Text = "Nuevo";
            this.btnNuevoProd.UseVisualStyleBackColor = false;
            this.btnNuevoProd.Click += new System.EventHandler(this.btnNuevoProd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label7.Location = new System.Drawing.Point(28, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID_Producto";
            // 
            // txtIDProd
            // 
            this.txtIDProd.Enabled = false;
            this.txtIDProd.Location = new System.Drawing.Point(32, 110);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(158, 20);
            this.txtIDProd.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label8.Location = new System.Drawing.Point(28, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Forma de Pago:";
            // 
            // rdbtnContado
            // 
            this.rdbtnContado.AutoSize = true;
            this.rdbtnContado.Checked = true;
            this.rdbtnContado.Font = new System.Drawing.Font("JetBrains Mono", 9F);
            this.rdbtnContado.Location = new System.Drawing.Point(33, 487);
            this.rdbtnContado.Name = "rdbtnContado";
            this.rdbtnContado.Size = new System.Drawing.Size(74, 20);
            this.rdbtnContado.TabIndex = 21;
            this.rdbtnContado.TabStop = true;
            this.rdbtnContado.Text = "Contado";
            this.rdbtnContado.UseVisualStyleBackColor = true;
            this.rdbtnContado.CheckedChanged += new System.EventHandler(this.rdbtnContado_CheckedChanged);
            // 
            // rdbtnCredito
            // 
            this.rdbtnCredito.AutoSize = true;
            this.rdbtnCredito.Font = new System.Drawing.Font("JetBrains Mono", 9F);
            this.rdbtnCredito.Location = new System.Drawing.Point(116, 487);
            this.rdbtnCredito.Name = "rdbtnCredito";
            this.rdbtnCredito.Size = new System.Drawing.Size(74, 20);
            this.rdbtnCredito.TabIndex = 22;
            this.rdbtnCredito.Text = "Credito";
            this.rdbtnCredito.UseVisualStyleBackColor = true;
            this.rdbtnCredito.CheckedChanged += new System.EventHandler(this.rdbtnCredito_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label9.Location = new System.Drawing.Point(28, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Muebles"});
            this.cboCategoria.Location = new System.Drawing.Point(32, 356);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(158, 24);
            this.cboCategoria.TabIndex = 24;
            this.cboCategoria.Text = "Seleccione";
            // 
            // lblNomPrE
            // 
            this.lblNomPrE.AutoSize = true;
            this.lblNomPrE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblNomPrE.ForeColor = System.Drawing.Color.Red;
            this.lblNomPrE.Location = new System.Drawing.Point(30, 196);
            this.lblNomPrE.Name = "lblNomPrE";
            this.lblNomPrE.Size = new System.Drawing.Size(0, 14);
            this.lblNomPrE.TabIndex = 25;
            // 
            // lblPreE
            // 
            this.lblPreE.AutoSize = true;
            this.lblPreE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblPreE.ForeColor = System.Drawing.Color.Red;
            this.lblPreE.Location = new System.Drawing.Point(30, 258);
            this.lblPreE.Name = "lblPreE";
            this.lblPreE.Size = new System.Drawing.Size(0, 14);
            this.lblPreE.TabIndex = 26;
            // 
            // lblCanE
            // 
            this.lblCanE.AutoSize = true;
            this.lblCanE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblCanE.ForeColor = System.Drawing.Color.Red;
            this.lblCanE.Location = new System.Drawing.Point(30, 315);
            this.lblCanE.Name = "lblCanE";
            this.lblCanE.Size = new System.Drawing.Size(0, 14);
            this.lblCanE.TabIndex = 27;
            // 
            // lblCatE
            // 
            this.lblCatE.AutoSize = true;
            this.lblCatE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblCatE.ForeColor = System.Drawing.Color.Red;
            this.lblCatE.Location = new System.Drawing.Point(30, 382);
            this.lblCatE.Name = "lblCatE";
            this.lblCatE.Size = new System.Drawing.Size(0, 14);
            this.lblCatE.TabIndex = 28;
            // 
            // lblDescE
            // 
            this.lblDescE.AutoSize = true;
            this.lblDescE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblDescE.ForeColor = System.Drawing.Color.Red;
            this.lblDescE.Location = new System.Drawing.Point(30, 445);
            this.lblDescE.Name = "lblDescE";
            this.lblDescE.Size = new System.Drawing.Size(0, 14);
            this.lblDescE.TabIndex = 29;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 532);
            this.Controls.Add(this.lblDescE);
            this.Controls.Add(this.lblCatE);
            this.Controls.Add(this.lblCanE);
            this.Controls.Add(this.lblPreE);
            this.Controls.Add(this.lblNomPrE);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rdbtnCredito);
            this.Controls.Add(this.rdbtnContado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNuevoProd);
            this.Controls.Add(this.btnEliProd);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarP);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescP);
            this.Controls.Add(this.txtPrecioP);
            this.Controls.Add(this.txtCantP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtCantP;
        private System.Windows.Forms.TextBox txtPrecioP;
        private System.Windows.Forms.TextBox txtDescP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.Button btnRegistrarP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditarProd;
        private System.Windows.Forms.Button btnEliProd;
        private System.Windows.Forms.Button btnNuevoProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbtnContado;
        private System.Windows.Forms.RadioButton rdbtnCredito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblNomPrE;
        private System.Windows.Forms.Label lblPreE;
        private System.Windows.Forms.Label lblCanE;
        private System.Windows.Forms.Label lblCatE;
        private System.Windows.Forms.Label lblDescE;
    }
}