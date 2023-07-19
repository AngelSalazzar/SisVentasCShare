namespace CapaPresentacion
{
    partial class FrmUsuarios
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomU = new System.Windows.Forms.TextBox();
            this.txtContraU = new System.Windows.Forms.TextBox();
            this.txtTipoU = new System.Windows.Forms.TextBox();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnRegistrarU = new System.Windows.Forms.Button();
            this.txtIDU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditarU = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.btnNuevoU = new System.Windows.Forms.Button();
            this.lblNomE = new System.Windows.Forms.Label();
            this.lblPassE = new System.Windows.Forms.Label();
            this.lblTipoE = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 410);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 8);
            this.panel2.TabIndex = 16;
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
            this.panel1.Size = new System.Drawing.Size(735, 40);
            this.panel1.TabIndex = 17;
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
            this.pictureBox3.Location = new System.Drawing.Point(680, 11);
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
            this.pictureBox2.Location = new System.Drawing.Point(713, 11);
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
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "REGISTRO DE USUARIOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tipo de Usuario:";
            // 
            // txtNomU
            // 
            this.txtNomU.Location = new System.Drawing.Point(31, 186);
            this.txtNomU.Multiline = true;
            this.txtNomU.Name = "txtNomU";
            this.txtNomU.Size = new System.Drawing.Size(158, 20);
            this.txtNomU.TabIndex = 22;
            // 
            // txtContraU
            // 
            this.txtContraU.Location = new System.Drawing.Point(31, 255);
            this.txtContraU.Name = "txtContraU";
            this.txtContraU.Size = new System.Drawing.Size(158, 20);
            this.txtContraU.TabIndex = 23;
            // 
            // txtTipoU
            // 
            this.txtTipoU.Location = new System.Drawing.Point(31, 324);
            this.txtTipoU.Multiline = true;
            this.txtTipoU.Name = "txtTipoU";
            this.txtTipoU.Size = new System.Drawing.Size(158, 20);
            this.txtTipoU.TabIndex = 24;
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.Location = new System.Drawing.Point(226, 128);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.RowHeadersWidth = 51;
            this.tablaUsuarios.Size = new System.Drawing.Size(496, 153);
            this.tablaUsuarios.TabIndex = 25;
            this.tablaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuarios_CellContentClick);
            // 
            // btnRegistrarU
            // 
            this.btnRegistrarU.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarU.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarU.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarU.Location = new System.Drawing.Point(236, 295);
            this.btnRegistrarU.Name = "btnRegistrarU";
            this.btnRegistrarU.Size = new System.Drawing.Size(103, 32);
            this.btnRegistrarU.TabIndex = 26;
            this.btnRegistrarU.Text = "Registrar";
            this.btnRegistrarU.UseVisualStyleBackColor = false;
            this.btnRegistrarU.Click += new System.EventHandler(this.btnRegistrarU_Click);
            // 
            // txtIDU
            // 
            this.txtIDU.Enabled = false;
            this.txtIDU.Location = new System.Drawing.Point(31, 119);
            this.txtIDU.Multiline = true;
            this.txtIDU.Name = "txtIDU";
            this.txtIDU.Size = new System.Drawing.Size(158, 20);
            this.txtIDU.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "ID_Usuario";
            // 
            // btnEditarU
            // 
            this.btnEditarU.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditarU.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarU.ForeColor = System.Drawing.Color.White;
            this.btnEditarU.Location = new System.Drawing.Point(360, 295);
            this.btnEditarU.Name = "btnEditarU";
            this.btnEditarU.Size = new System.Drawing.Size(103, 32);
            this.btnEditarU.TabIndex = 29;
            this.btnEditarU.Text = "Editar";
            this.btnEditarU.UseVisualStyleBackColor = false;
            this.btnEditarU.Click += new System.EventHandler(this.btnEditarU_Click);
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarU.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarU.ForeColor = System.Drawing.Color.White;
            this.btnEliminarU.Location = new System.Drawing.Point(489, 295);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(103, 32);
            this.btnEliminarU.TabIndex = 30;
            this.btnEliminarU.Text = "Eliminar";
            this.btnEliminarU.UseVisualStyleBackColor = false;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // btnNuevoU
            // 
            this.btnNuevoU.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNuevoU.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoU.ForeColor = System.Drawing.Color.White;
            this.btnNuevoU.Location = new System.Drawing.Point(619, 295);
            this.btnNuevoU.Name = "btnNuevoU";
            this.btnNuevoU.Size = new System.Drawing.Size(103, 32);
            this.btnNuevoU.TabIndex = 31;
            this.btnNuevoU.Text = "Nuevo";
            this.btnNuevoU.UseVisualStyleBackColor = false;
            this.btnNuevoU.Click += new System.EventHandler(this.btnNuevoU_Click);
            // 
            // lblNomE
            // 
            this.lblNomE.AutoSize = true;
            this.lblNomE.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomE.ForeColor = System.Drawing.Color.Red;
            this.lblNomE.Location = new System.Drawing.Point(28, 209);
            this.lblNomE.Name = "lblNomE";
            this.lblNomE.Size = new System.Drawing.Size(0, 14);
            this.lblNomE.TabIndex = 32;
            // 
            // lblPassE
            // 
            this.lblPassE.AutoSize = true;
            this.lblPassE.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassE.ForeColor = System.Drawing.Color.Red;
            this.lblPassE.Location = new System.Drawing.Point(28, 278);
            this.lblPassE.Name = "lblPassE";
            this.lblPassE.Size = new System.Drawing.Size(0, 14);
            this.lblPassE.TabIndex = 33;
            // 
            // lblTipoE
            // 
            this.lblTipoE.AutoSize = true;
            this.lblTipoE.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoE.ForeColor = System.Drawing.Color.Red;
            this.lblTipoE.Location = new System.Drawing.Point(28, 347);
            this.lblTipoE.Name = "lblTipoE";
            this.lblTipoE.Size = new System.Drawing.Size(0, 14);
            this.lblTipoE.TabIndex = 34;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 418);
            this.Controls.Add(this.lblTipoE);
            this.Controls.Add(this.lblPassE);
            this.Controls.Add(this.lblNomE);
            this.Controls.Add(this.btnNuevoU);
            this.Controls.Add(this.btnEliminarU);
            this.Controls.Add(this.btnEditarU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDU);
            this.Controls.Add(this.btnRegistrarU);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.txtTipoU);
            this.Controls.Add(this.txtContraU);
            this.Controls.Add(this.txtNomU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomU;
        private System.Windows.Forms.TextBox txtContraU;
        private System.Windows.Forms.TextBox txtTipoU;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.Button btnRegistrarU;
        private System.Windows.Forms.TextBox txtIDU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditarU;
        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.Button btnNuevoU;
        private System.Windows.Forms.Label lblNomE;
        private System.Windows.Forms.Label lblPassE;
        private System.Windows.Forms.Label lblTipoE;
    }
}