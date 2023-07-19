namespace CapaPresentacion
{
    partial class FrmReporte
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
            this.btnProd = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNom_v = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNomPrd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVenta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.txtPb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCodCliE = new System.Windows.Forms.Label();
            this.lblCodProdE = new System.Windows.Forms.Label();
            this.lblCantE = new System.Windows.Forms.Label();
            this.lblNomVenE = new System.Windows.Forms.Label();
            this.lblFechaE = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(955, 40);
            this.panel1.TabIndex = 18;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
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
            this.pictureBox3.Location = new System.Drawing.Point(891, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(927, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProd.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.btnProd.ForeColor = System.Drawing.Color.White;
            this.btnProd.Location = new System.Drawing.Point(220, 125);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(149, 38);
            this.btnProd.TabIndex = 58;
            this.btnProd.Text = "Buscar Producto";
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Location = new System.Drawing.Point(220, 64);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(149, 38);
            this.btnCliente.TabIndex = 57;
            this.btnCliente.Text = "Buscar Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label12.Location = new System.Drawing.Point(627, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 56;
            this.label12.Text = "Fecha:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label11.Location = new System.Drawing.Point(406, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 19);
            this.label11.TabIndex = 55;
            this.label11.Text = "Nombre del vendedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label10.Location = new System.Drawing.Point(406, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 54;
            this.label10.Text = "Stock:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(631, 254);
            this.txtFecha.Multiline = true;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(177, 19);
            this.txtFecha.TabIndex = 53;
            // 
            // txtNom_v
            // 
            this.txtNom_v.Location = new System.Drawing.Point(410, 254);
            this.txtNom_v.Multiline = true;
            this.txtNom_v.Name = "txtNom_v";
            this.txtNom_v.Size = new System.Drawing.Size(177, 19);
            this.txtNom_v.TabIndex = 52;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(410, 194);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(177, 19);
            this.txtStock.TabIndex = 51;
            // 
            // txtNomPrd
            // 
            this.txtNomPrd.Location = new System.Drawing.Point(410, 134);
            this.txtNomPrd.Multiline = true;
            this.txtNomPrd.Name = "txtNomPrd";
            this.txtNomPrd.ReadOnly = true;
            this.txtNomPrd.Size = new System.Drawing.Size(177, 19);
            this.txtNomPrd.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label9.Location = new System.Drawing.Point(406, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "Producto:";
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVenta.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Location = new System.Drawing.Point(795, 458);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(144, 41);
            this.btnVenta.TabIndex = 48;
            this.btnVenta.Text = "Generar venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label8.Location = new System.Drawing.Point(19, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "Cantidad:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(22, 263);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(176, 20);
            this.numericUpDown1.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, -19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Nombre del Cliente";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(606, 538);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(177, 19);
            this.txtTotal.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(795, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 41);
            this.button1.TabIndex = 43;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIgv
            // 
            this.txtIgv.Location = new System.Drawing.Point(606, 500);
            this.txtIgv.Multiline = true;
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(177, 19);
            this.txtIgv.TabIndex = 42;
            // 
            // txtPb
            // 
            this.txtPb.Location = new System.Drawing.Point(606, 461);
            this.txtPb.Multiline = true;
            this.txtPb.Name = "txtPb";
            this.txtPb.ReadOnly = true;
            this.txtPb.Size = new System.Drawing.Size(177, 19);
            this.txtPb.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-27, -35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Codigo del cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label5.Location = new System.Drawing.Point(19, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label1.Location = new System.Drawing.Point(19, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Codigo del Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label3.Location = new System.Drawing.Point(542, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "TOTAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label2.Location = new System.Drawing.Point(559, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "IGV:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label13.Location = new System.Drawing.Point(484, 461);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "Precio bruto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(22, 202);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(177, 19);
            this.txtPrecio.TabIndex = 33;
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(22, 145);
            this.txtProd.Multiline = true;
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(177, 19);
            this.txtProd.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(930, 137);
            this.dataGridView1.TabIndex = 30;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(22, 84);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(177, 19);
            this.txtCliente.TabIndex = 31;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(410, 84);
            this.txtNomCliente.Multiline = true;
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.ReadOnly = true;
            this.txtNomCliente.Size = new System.Drawing.Size(177, 19);
            this.txtNomCliente.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label14.Location = new System.Drawing.Point(19, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 19);
            this.label14.TabIndex = 59;
            this.label14.Text = "Codigo de Cliente:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("JetBrains Mono", 11F);
            this.label15.Location = new System.Drawing.Point(406, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 19);
            this.label15.TabIndex = 60;
            this.label15.Text = "Nombre del Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 575);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 9);
            this.panel2.TabIndex = 61;
            // 
            // lblCodCliE
            // 
            this.lblCodCliE.AutoSize = true;
            this.lblCodCliE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblCodCliE.ForeColor = System.Drawing.Color.Red;
            this.lblCodCliE.Location = new System.Drawing.Point(20, 106);
            this.lblCodCliE.Name = "lblCodCliE";
            this.lblCodCliE.Size = new System.Drawing.Size(0, 14);
            this.lblCodCliE.TabIndex = 62;
            // 
            // lblCodProdE
            // 
            this.lblCodProdE.AutoSize = true;
            this.lblCodProdE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblCodProdE.ForeColor = System.Drawing.Color.Red;
            this.lblCodProdE.Location = new System.Drawing.Point(20, 166);
            this.lblCodProdE.Name = "lblCodProdE";
            this.lblCodProdE.Size = new System.Drawing.Size(0, 14);
            this.lblCodProdE.TabIndex = 63;
            // 
            // lblCantE
            // 
            this.lblCantE.AutoSize = true;
            this.lblCantE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblCantE.ForeColor = System.Drawing.Color.Red;
            this.lblCantE.Location = new System.Drawing.Point(20, 286);
            this.lblCantE.Name = "lblCantE";
            this.lblCantE.Size = new System.Drawing.Size(0, 14);
            this.lblCantE.TabIndex = 64;
            // 
            // lblNomVenE
            // 
            this.lblNomVenE.AutoSize = true;
            this.lblNomVenE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblNomVenE.ForeColor = System.Drawing.Color.Red;
            this.lblNomVenE.Location = new System.Drawing.Point(407, 276);
            this.lblNomVenE.Name = "lblNomVenE";
            this.lblNomVenE.Size = new System.Drawing.Size(0, 14);
            this.lblNomVenE.TabIndex = 65;
            // 
            // lblFechaE
            // 
            this.lblFechaE.AutoSize = true;
            this.lblFechaE.Font = new System.Drawing.Font("JetBrains Mono", 8F);
            this.lblFechaE.ForeColor = System.Drawing.Color.Red;
            this.lblFechaE.Location = new System.Drawing.Point(628, 276);
            this.lblFechaE.Name = "lblFechaE";
            this.lblFechaE.Size = new System.Drawing.Size(0, 14);
            this.lblFechaE.TabIndex = 66;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 584);
            this.Controls.Add(this.lblFechaE);
            this.Controls.Add(this.lblNomVenE);
            this.Controls.Add(this.lblCantE);
            this.Controls.Add(this.lblCodProdE);
            this.Controls.Add(this.lblCodCliE);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNom_v);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtNomPrd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.txtPb);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNom_v;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNomPrd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.TextBox txtPb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCodCliE;
        private System.Windows.Forms.Label lblCodProdE;
        private System.Windows.Forms.Label lblCantE;
        private System.Windows.Forms.Label lblNomVenE;
        private System.Windows.Forms.Label lblFechaE;
    }
}