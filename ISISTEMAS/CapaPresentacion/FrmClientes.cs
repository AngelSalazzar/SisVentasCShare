using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
                                                                                                                                                              
namespace CapaPresentacion
{
    public partial class FrmClientes : Form
    {
        //string cn = "Data Source=.;Initial Catalog=ISISTEMAS;Integrated Security=True";
        //SqlConnection conexion = new SqlConnection();
        //Conexion con = new Conexion();
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
        public FrmClientes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        N_Cliente objN = new N_Cliente();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            try
            {
                if (Validar())
                {
                    objN.InsertarCli(txtNombreC.Text, txtDirecC.Text, txtDniC.Text, txtNumC.Text);
                    Mostrar_Cli();
                }
            } catch
            {
                MessageBox.Show("Revise Todas las casillas","Error al Registrar Cliente");
            }
        }

        private bool Validar()
        {
            bool ok = true;
            if (txtNombreC.TextLength == 0)
            {
                ok = false;
                lblNomE.Text = "Llenar casilla";
            }
            if (txtDirecC.TextLength == 0)
            {
                ok = false;
                lblDicE.Text = "Llenar casilla";
            }
            if (txtDniC.TextLength == 0)
            {
                ok = false;
                lblDniE.Text = "Llenar casilla";
            }
            if (txtNumC.TextLength == 0)
            {
                ok = false;
                lblNumE.Text = "Llenar casilla";
            }

            return ok;
        }
        private void BorrarMensaje()
        {
            if (!(txtNombreC.TextLength == 0))
            {
                lblNomE.Text = "";
            }
            if (!(txtDirecC.TextLength == 0))
            {
                lblDicE.Text = "";
            }
            if (!(txtDniC.TextLength == 0))
            {
                lblDniE.Text = "";
            }
            if (!(txtNumC.TextLength == 0))
            {
                lblNumE.Text = "";
            }
        }



        private void Mostrar_Cli()
        {
            N_Cliente cliente = new N_Cliente();
            tablaCliente.DataSource = cliente.Mostrar();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Mostrar_Cli();
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

        private void Limpiar()
        {
            txtID.Text = "";
            txtNombreC.Text = "";
            txtDirecC.Text = "";
            txtDniC.Text = "";
            txtNumC.Text = "";
            //----------------------------
            lblIDE.Text = "";
            lblNomE.Text = "";
            lblDicE.Text = "";
            lblDniE.Text = "";
            lblNumE.Text = "";
        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            try
            {
                 objN.NeditarC(txtID.Text, txtNombreC.Text, txtDirecC.Text, txtDniC.Text, txtNumC.Text);
                 Mostrar_Cli();
                
            }
            catch
            {
                MessageBox.Show("Aegurese de seleccionar los datos a Editar porfavor","Error al Editar Cliente");
            }
            
        }
        
        
        private void btnEliC_Click(object sender, EventArgs e)
        {
            try
            {
                objN.NelimininarC(txtID.Text);
                Mostrar_Cli();
                Limpiar();
            }catch
            {
                MessageBox.Show("Asegurese de seleccionar el registro a eliminar ","Error al Eliminar Cliente");
            }
        }

        private void btnNuevoC_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tablaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = tablaCliente.CurrentRow.Cells[0].Value.ToString();
                txtNombreC.Text = tablaCliente.CurrentRow.Cells[1].Value.ToString();
                txtDirecC.Text = tablaCliente.CurrentRow.Cells[2].Value.ToString();
                txtDniC.Text = tablaCliente.CurrentRow.Cells[3].Value.ToString();
                txtNumC.Text = tablaCliente.CurrentRow.Cells[4].Value.ToString();
            } catch
            {
                MessageBox.Show("Si desea editar seleccione al menos un datos de su registro");
            }
        }
    }
}
