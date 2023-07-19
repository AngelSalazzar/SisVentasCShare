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
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class FrmProductos : Form
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
        public FrmProductos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        N_Producto objProd = new N_Producto();
        int posX = 0;
        int posY = 0;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            try
            {
                if (Validar())
                {
                    if (rdbtnContado.Checked)
                    {
                        string forma = "Contado";
                        objProd.InsertarProd(txtNombreP.Text, Convert.ToDecimal(txtPrecioP.Text), Convert.ToInt32(txtCantP.Text), cboCategoria.Text, txtDescP.Text, forma);
                        Mostrar_Cli();

                    }
                    if (rdbtnCredito.Checked)
                    {
                        string forma = "Credito";
                        objProd.InsertarProd(txtNombreP.Text, Convert.ToDecimal(txtPrecioP.Text), Convert.ToInt32(txtCantP.Text), cboCategoria.Text, txtDescP.Text, forma);
                        Mostrar_Cli();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Rellenar las casillas con los datos correspondientes","Error al Registrar Producto");
            }
            

        }
        private bool Validar()
        {
            bool ok = true;
            if (txtNombreP.TextLength == 0)
            {
                ok = false;
                lblNomPrE.Text = "Llenar Casilla";
            }
            if (txtPrecioP.TextLength == 0)
            {
                ok = false;
                lblPreE.Text = "Llenar Casilla";
            }
            if (txtCantP.TextLength == 0)
            {
                ok = false;
                lblCanE.Text = "Llenar Casilla";
            }
            if (cboCategoria.Text == "Seleccione")
            {
                ok = false;
                lblCatE.Text = "Llenar Casilla";
            }
            if (txtDescP.TextLength == 0)
            {
                ok = false;
                lblDescE.Text = "Llenar Casilla";
            }

            return ok;
        }
        private void BorrarMensaje()
        {
            if (!(txtNombreP.TextLength == 0))
            {
                lblNomPrE.Text = "";
            }
            if (!(txtPrecioP.TextLength == 0))
            {
                lblPreE.Text = "";
            }
            if (!(txtCantP.TextLength == 0))
            {
                lblCanE.Text = "";
            }
            if (!(cboCategoria.Text == "Seleccione"))
            {
                lblCatE.Text = "";
            }
            if (!(txtDescP.TextLength == 0))
            {
                lblDescE.Text = "";
            }
        }
        private void Mostrar_Cli()
        {
            N_Producto cliente = new N_Producto();
            tablaProductos.DataSource = cliente.Mostrar();
        }
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

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Mostrar_Cli();
        }

        private void Limpiar()
        {
            txtIDProd.Text = "";
            txtNombreP.Text = "";
            txtDescP.Text = "";
            txtCantP.Text = "";
            txtPrecioP.Text = "";
            //------------------------------
            lblNomPrE.Text = "";
            lblDescE.Text = "";
            lblCanE.Text = "";
            lblCatE.Text = "";
            lblPreE.Text = "";
        }

        private void btnEliProd_Click(object sender, EventArgs e)
        {
            try
            {
                objProd.NeliminarProd(txtIDProd.Text);
                Mostrar_Cli();
                Limpiar();

            }
            catch
            {
                MessageBox.Show("Asegurese de que el campo ID esté lleno","Error al Eliminar Producto");
            }
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbtnContado.Checked)
                {
                    string forma = "Contado";
                    objProd.NeditarProd(txtIDProd.Text, txtNombreP.Text, txtPrecioP.Text, txtCantP.Text, cboCategoria.Text, txtDescP.Text, forma);
                    Mostrar_Cli();

                }
                if (rdbtnCredito.Checked)
                {
                    string forma = "Credito";
                    objProd.NeditarProd(txtIDProd.Text, txtNombreP.Text, txtPrecioP.Text, txtCantP.Text, cboCategoria.Text, txtDescP.Text, forma);
                    Mostrar_Cli();
                }
            }
            catch
            {
                MessageBox.Show("Asegurese de clickear y/o rellenar los datos que faltan !","Error al Editar Cliente");
            }
        }

        private void btnNuevoProd_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void rdbtnContado_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbtnCredito_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDProd.Text = tablaProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombreP.Text = tablaProductos.CurrentRow.Cells[1].Value.ToString();
            txtPrecioP.Text = tablaProductos.CurrentRow.Cells[2].Value.ToString();
            txtCantP.Text = tablaProductos.CurrentRow.Cells[3].Value.ToString();
            cboCategoria.Text = tablaProductos.CurrentRow.Cells[4].Value.ToString();
            txtDescP.Text = tablaProductos.CurrentRow.Cells[5].Value.ToString();
            string val_sex = tablaProductos.CurrentRow.Cells[6].Value.ToString();
            if (val_sex == "Contado")
            {
                rdbtnContado.Checked = true;
            }
            else
            {
                rdbtnCredito.Checked = true;
            }
        }
    }
}
