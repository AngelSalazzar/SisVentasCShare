using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporte : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public FrmReporte()
        {
            InitializeComponent();
            N_Producto pr = new N_Producto();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            dataGridView1.DataSource = pr.mostrar_factura();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCliente.Text != "usuario")
                {
                    N_Cliente cln = new N_Cliente();
                    int v = Convert.ToInt32(txtCliente.Text);
                    var validacion = cln.Buscar_cli(v);
                    if (validacion == true)
                    {
                        txtNomCliente.Text = E_Clientes.CLIENTE;
                        lblCodCliE.Text = "";
                    }
                    else if (validacion == false)
                    {
                        txtCliente.Text = "";
                        MessageBox.Show("Cliente inexistente","Error al Buscar Cliente");
                    }

                }
            }
            catch
            {
                MessageBox.Show("El codigo de Cliente debe ser un Número","Error al Buscar Cliente");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomPrd.Text != "Producto")
                {
                    N_Producto prd = new N_Producto();
                    if (txtProd.Text == "")
                    {
                        MessageBox.Show("ingresar codigo del producto", "Error al Buscar Producto");
                    }
                    else
                    {
                        int v = Convert.ToInt32(txtProd.Text);
                        var validacion = prd.Buscar_Prd(v);
                        if (validacion == true)
                        {
                            txtNomPrd.Text = E_Productos.NOMBRE;
                            txtPrecio.Text = E_Productos.PRECIO.ToString();
                            txtStock.Text = E_Productos.CANTIDAD.ToString();
                            lblCodProdE.Text = "";
                        }
                        else if (validacion == false)
                        {
                            txtProd.Text = "";
                            MessageBox.Show("Producto inexistenete","Falta de Stock");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("El código de Producto debe ser un número, fíjese bien porfavor", "Error Busqueda de Producto");
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            try
            {
                if (Validar())
                {
                    if (E_Productos.CANTIDAD < Convert.ToDecimal(numericUpDown1.Value))
                    {
                        MessageBox.Show("No hay stock suficiente","Falta de Stock");
                    }
                    else
                    {
                        double t = 0;

                        double P_bruto = Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(numericUpDown1.Value);

                        if (t == 0)
                        { t = P_bruto; }
                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            t += Convert.ToDouble(r.Cells[7].Value);
                        }
                        txtPb.Text = t.ToString();

                        double P_igv = (Convert.ToDouble(txtPb.Text) * 0.18);
                        txtIgv.Text = P_igv.ToString("N2");

                        double Total = Convert.ToDouble(txtPb.Text) + P_igv;
                        txtTotal.Text = Total.ToString("N2");

                        N_Producto prd = new N_Producto();
                        prd.Registro_fac(
                            txtNom_v.Text,
                            Convert.ToDateTime(txtFecha.Text),
                            Convert.ToInt32(txtCliente.Text),
                            txtNomCliente.Text,
                            Convert.ToInt32(txtProd.Text),
                            txtNomPrd.Text,
                            Convert.ToInt32(numericUpDown1.Value),
                            Convert.ToDecimal(P_bruto)
                            );
                        dataGridView1.DataSource = prd.mostrar_factura();
                        prd.reducir(Convert.ToInt32(txtProd.Text),
                            E_Productos.CANTIDAD = Convert.ToInt32(txtStock.Text) - Convert.ToInt32(numericUpDown1.Value));
                        txtStock.Text = E_Productos.CANTIDAD.ToString();


                    }
                }
            }
            catch
            {
                MessageBox.Show("Revise si los campos están completos","Error al Generar Reporte");
            }
        }
        private bool Validar()
        {
            bool ok = true;
            if (txtCliente.TextLength == 0)
            {
                ok = false;
                lblCodCliE.Text = "Llenar Casilla";
            }
            if (txtProd.TextLength == 0)
            {
                ok = false;
                lblCodProdE.Text = "Llenar Casilla";
            }
            if (numericUpDown1.Value == 0)
            {
                ok = false;
                lblCantE.Text = "Seleccionar Cantidad";
            }
            if (txtNom_v.TextLength == 0)
            {
                ok = false;
                lblNomVenE.Text = "Llenar Casilla";
            }
            if (txtFecha.TextLength == 0)
            {
                ok = false;
                lblFechaE.Text = "Llenar Casilla";
            }

            return ok;
        }
        public void BorrarMensaje()
        {
            if(!(txtCliente.TextLength == 0))
            {
                lblCodCliE.Text = "";
            }
            if (!(txtProd.TextLength == 0))
            {
                lblCodProdE.Text = "";
            }
            string val_cant = numericUpDown1.Value.ToString();
            if (!(val_cant == "0"))
            {
                lblCantE.Text = "";
            }
            if (!(txtNom_v.TextLength == 0))
            {
                lblNomVenE.Text = "";
            }
            if (!(txtFecha.TextLength == 0))
            {
                lblFechaE.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistro frm = new FrmRegistro();
            frm.Show();
        }      

        
        int posX = 0;
        int posY = 0;
        

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
