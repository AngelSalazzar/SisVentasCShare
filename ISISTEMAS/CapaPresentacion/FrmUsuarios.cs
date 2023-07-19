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
    public partial class FrmUsuarios : Form
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
        public FrmUsuarios()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        N_Usuarios objNU = new N_Usuarios();

        private void MostrarUsu()
        {
            N_Usuarios objNU = new N_Usuarios();
            tablaUsuarios.DataSource = objNU.Mostrar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsu();
        }

        private void btnRegistrarU_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            try
            {
                if (Validar())
                {
                    objNU.InsertarUsu(txtNomU.Text, txtContraU.Text, txtTipoU.Text);
                    MostrarUsu();
                }
            } catch
            {
                MessageBox.Show("Rellene bien los campos","Error al Registrar Usuario");
            }
            
        }
        private bool Validar()
        {
            bool ok = true;
            if (txtNomU.TextLength == 0)
            {
                ok = false;
                lblNomE.Text = "Llenar la casilla";
            }
            if (txtContraU.TextLength == 0)
            {
                ok = false;
                lblPassE.Text = "Llenar la casilla";
            }
            if (txtTipoU.TextLength == 0)
            {
                ok = false;
                lblTipoE.Text = "Llenar la casilla";
            }


            return ok;
        }
        private void BorrarMensaje()
        {
            if(!(txtNomU.TextLength == 0))
            {
                lblNomE.Text = "";
            }
            if (!(txtContraU.TextLength == 0))
            {
                lblPassE.Text = "";
            }
            if (!(txtTipoU.TextLength == 0))
            {
                lblTipoE.Text = "";
            }
        }
        private void Limpiar()
        {
            txtIDU.Text = "";
            txtNomU.Text = "";
            txtContraU.Text = "";
            txtTipoU.Text = "";
            //----------------------------------
            lblNomE.Text = "";
            lblPassE.Text = "";
            lblTipoE.Text = "";
            
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

        private void btnEditarU_Click(object sender, EventArgs e)
        {
            try
            {
                objNU.NeditarU(txtIDU.Text, txtNomU.Text, txtTipoU.Text);
                MostrarUsu();
            }
            catch
            {
                MessageBox.Show("Asegurese de seleccionar los campos a editar","Error al Editar Usuario");
            }
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            try
            {
                objNU.NeliminarU(txtIDU.Text);
                MostrarUsu();
                Limpiar();
            }
            catch
            {
                MessageBox.Show("Asegurese de seleccionar el registro a eliminar","Error al Eliminar Usuario");
            }
        }

        private void btnNuevoU_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDU.Text = tablaUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNomU.Text = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
            
            txtTipoU.Text = tablaUsuarios.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
