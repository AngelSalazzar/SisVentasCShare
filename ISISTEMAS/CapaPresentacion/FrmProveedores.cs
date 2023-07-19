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
    public partial class FrmProveedores : Form
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
        public FrmProveedores()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        N_Proveedores objProve = new N_Proveedores();
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

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            try
            {
                if (Validar())
                {
                    objProve.InsertarCli(txtNomProve.Text, txtRucProve.Text, txtDirecProve.Text);
                    Mostrar_Cli();
                }
            } catch 
            {
                MessageBox.Show("Rellenar con datos correctos las casillas","Error al registrar Proveedor");
            }
           
        }
        private bool Validar()
        {
            bool ok = true;
            if (txtNomProve.TextLength == 0)
            {
                ok = false;
                lblNomE.Text = "Llenar Casilla";
            }
            if (txtRucProve.TextLength == 0)
            {
                ok = false;
                lblRucE.Text = "Llenar Casilla";
            }
            if (txtDirecProve.TextLength == 0)
            {
                ok = false;
                lblDireE.Text = "Llenar Casilla";
            }


            return ok;
        }
        private void BorrarMensaje()
        {
            if (!(txtNomProve.TextLength == 0))
            {
                lblNomE.Text = "";
            }
            if (!(txtRucProve.TextLength == 0))
            {
                lblRucE.Text = "";
            }
            if (!(txtDirecProve.TextLength == 0))
            {
                lblDireE.Text = "";
            }
        }
        private void Mostrar_Cli()
        {
            N_Proveedores cliente = new N_Proveedores();
            tablaProveedores.DataSource = cliente.Mostrar();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            Mostrar_Cli();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Limpiar()
        {
            txtNomProve.Text = "";
            txtDirecProve.Text = "";
            txtRucProve.Text = "";
            txtIDProv.Text = "";
            //------------------------
            lblIDE.Text = "";
            lblNomE.Text = "";
            lblRucE.Text = "";
            lblDireE.Text = "";
            
        }

        private void btnEditarProv_Click(object sender, EventArgs e)
        {
            
            try
            {
                objProve.NeditarProv(txtIDProv.Text, txtNomProve.Text, txtRucProve.Text, txtDirecProve.Text);
                Mostrar_Cli();
            }
            catch
            {
                MessageBox.Show("Aegurese de seleccionar los datos a Editar porfavor","Error al Editar Proveedor");
            }
        }
        
        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            try
            {
                objProve.NeliminarProv(txtIDProv.Text);
                Mostrar_Cli();
                Limpiar();
            }catch
            {
                MessageBox.Show("Asegurese de seleecionar el registro a eliminar ","Error al Eliminar Proveedor");
            }
        }

        private void btnNuevoProv_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tablaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDProv.Text = tablaProveedores.CurrentRow.Cells[0].Value.ToString();
            txtNomProve.Text = tablaProveedores.CurrentRow.Cells[1].Value.ToString();
            txtRucProve.Text = tablaProveedores.CurrentRow.Cells[2].Value.ToString();
            txtDirecProve.Text = tablaProveedores.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
