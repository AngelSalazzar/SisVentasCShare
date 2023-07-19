namespace CapaPresentacion
{
    partial class FrmClientes
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
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaCliente = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtDirecC = new System.Windows.Forms.TextBox();
            this.txtDniC = new System.Windows.Forms.TextBox();
            this.txtNumC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditarC = new System.Windows.Forms.Button();
            this.btnEliC = new System.Windows.Forms.Button();
            this.btnNuevoC = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNomE = new System.Windows.Forms.Label();
            this.lblDicE = new System.Windows.Forms.Label();
            this.lblDniE = new System.Windows.Forms.Label();
            this.lblNumE = new System.Windows.Forms.Label();
            this.lblIDE = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 40);
            this.panel1.TabIndex = 1;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "INFINITY LABS";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CapaPresentacion.Properties.Resources.infinity;
            this.pictureBox5.Location = new System.Drawing.Point(9, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(635, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(669, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "REGISTRO DE CLIENTES";
            // 
            // tablaCliente
            // 
            this.tablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCliente.Location = new System.Drawing.Point(234, 128);
            this.tablaCliente.Name = "tablaCliente";
            this.tablaCliente.RowHeadersWidth = 51;
            this.tablaCliente.Size = new System.Drawing.Size(468, 185);
            this.tablaCliente.TabIndex = 2;
            this.tablaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCliente_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(234, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Num Celular:";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(26, 182);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(173, 20);
            this.txtNombreC.TabIndex = 11;
            // 
            // txtDirecC
            // 
            this.txtDirecC.Location = new System.Drawing.Point(26, 244);
            this.txtDirecC.Name = "txtDirecC";
            this.txtDirecC.Size = new System.Drawing.Size(173, 20);
            this.txtDirecC.TabIndex = 12;
            // 
            // txtDniC
            // 
            this.txtDniC.Location = new System.Drawing.Point(26, 311);
            this.txtDniC.Name = "txtDniC";
            this.txtDniC.Size = new System.Drawing.Size(173, 20);
            this.txtDniC.TabIndex = 13;
            // 
            // txtNumC
            // 
            this.txtNumC.Location = new System.Drawing.Point(26, 380);
            this.txtNumC.Name = "txtNumC";
            this.txtNumC.Size = new System.Drawing.Size(173, 20);
            this.txtNumC.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 439);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 8);
            this.panel2.TabIndex = 15;
            // 
            // btnEditarC
            // 
            this.btnEditarC.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarC.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarC.ForeColor = System.Drawing.Color.White;
            this.btnEditarC.Location = new System.Drawing.Point(349, 343);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(103, 32);
            this.btnEditarC.TabIndex = 16;
            this.btnEditarC.Text = "Editar";
            this.btnEditarC.UseVisualStyleBackColor = false;
            this.btnEditarC.Click += new System.EventHandler(this.btnEditarC_Click);
            // 
            // btnEliC
            // 
            this.btnEliC.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliC.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliC.ForeColor = System.Drawing.Color.White;
            this.btnEliC.Location = new System.Drawing.Point(458, 343);
            this.btnEliC.Name = "btnEliC";
            this.btnEliC.Size = new System.Drawing.Size(103, 32);
            this.btnEliC.TabIndex = 17;
            this.btnEliC.Text = "Eliminar";
            this.btnEliC.UseVisualStyleBackColor = false;
            this.btnEliC.Click += new System.EventHandler(this.btnEliC_Click);
            // 
            // btnNuevoC
            // 
            this.btnNuevoC.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNuevoC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoC.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoC.ForeColor = System.Drawing.Color.White;
            this.btnNuevoC.Location = new System.Drawing.Point(567, 343);
            this.btnNuevoC.Name = "btnNuevoC";
            this.btnNuevoC.Size = new System.Drawing.Size(103, 32);
            this.btnNuevoC.TabIndex = 18;
            this.btnNuevoC.Text = "Nuevo";
            this.btnNuevoC.UseVisualStyleBackColor = false;
            this.btnNuevoC.Click += new System.EventHandler(this.btnNuevoC_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(27, 120);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 20);
            this.txtID.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "ID_Cliente:";
            // 
            // lblNomE
            // 
            this.lblNomE.AutoSize = true;
            this.lblNomE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblNomE.ForeColor = System.Drawing.Color.Red;
            this.lblNomE.Location = new System.Drawing.Point(24, 205);
            this.lblNomE.Name = "lblNomE";
            this.lblNomE.Size = new System.Drawing.Size(0, 14);
            this.lblNomE.TabIndex = 21;
            // 
            // lblDicE
            // 
            this.lblDicE.AutoSize = true;
            this.lblDicE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblDicE.ForeColor = System.Drawing.Color.Red;
            this.lblDicE.Location = new System.Drawing.Point(24, 267);
            this.lblDicE.Name = "lblDicE";
            this.lblDicE.Size = new System.Drawing.Size(0, 14);
            this.lblDicE.TabIndex = 22;
            // 
            // lblDniE
            // 
            this.lblDniE.AutoSize = true;
            this.lblDniE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblDniE.ForeColor = System.Drawing.Color.Red;
            this.lblDniE.Location = new System.Drawing.Point(24, 334);
            this.lblDniE.Name = "lblDniE";
            this.lblDniE.Size = new System.Drawing.Size(0, 14);
            this.lblDniE.TabIndex = 23;
            // 
            // lblNumE
            // 
            this.lblNumE.AutoSize = true;
            this.lblNumE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblNumE.ForeColor = System.Drawing.Color.Red;
            this.lblNumE.Location = new System.Drawing.Point(24, 403);
            this.lblNumE.Name = "lblNumE";
            this.lblNumE.Size = new System.Drawing.Size(0, 14);
            this.lblNumE.TabIndex = 24;
            // 
            // lblIDE
            // 
            this.lblIDE.AutoSize = true;
            this.lblIDE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblIDE.ForeColor = System.Drawing.Color.Red;
            this.lblIDE.Location = new System.Drawing.Point(27, 143);
            this.lblIDE.Name = "lblIDE";
            this.lblIDE.Size = new System.Drawing.Size(0, 14);
            this.lblIDE.TabIndex = 25;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 447);
            this.Controls.Add(this.lblIDE);
            this.Controls.Add(this.lblNumE);
            this.Controls.Add(this.lblDniE);
            this.Controls.Add(this.lblDicE);
            this.Controls.Add(this.lblNomE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnNuevoC);
            this.Controls.Add(this.btnEliC);
            this.Controls.Add(this.btnEditarC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumC);
            this.Controls.Add(this.txtDniC);
            this.Controls.Add(this.txtDirecC);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tablaCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtDirecC;
        private System.Windows.Forms.TextBox txtDniC;
        private System.Windows.Forms.TextBox txtNumC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditarC;
        private System.Windows.Forms.Button btnEliC;
        private System.Windows.Forms.Button btnNuevoC;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNomE;
        private System.Windows.Forms.Label lblDicE;
        private System.Windows.Forms.Label lblDniE;
        private System.Windows.Forms.Label lblNumE;
        private System.Windows.Forms.Label lblIDE;
    }
}