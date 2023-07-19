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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //VARIABLES PARA PODER MOVER EL FORM
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

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
                
            }

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Silver;
                
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Silver;
                
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            try
            {
                if (Validar())
                {
                    string usu = txtUsuario.Text;
                    N_Usuarios usuario = new N_Usuarios();
                    var validacion = usuario.Login(txtUsuario.Text, txtPassword.Text);
                    if (validacion == true)
                    {
                        
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                    else if (validacion == false)
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrectas");
                        Limpiar();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos " + ex.Message);
            }
            

        }
        private bool Validar()
        {
            bool ok = true;
            if(txtUsuario.TextLength == 0)
            {
                ok = false;
                errorProvider1.SetError(txtUsuario, "Ingrese Usuario");
                lblUsuario.Text = "Ingrese Usuario";
            }
            if (txtPassword.TextLength == 0)
            {
                ok = false;
                errorProvider1.SetError(txtPassword, "Ingrese Password");
                lblPass.Text = "Ingrese Password";
            }
            return ok;
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtUsuario, "");
            if (!(txtUsuario.TextLength == 0))
            {
                lblUsuario.Text = "";
            }
            errorProvider1.SetError(txtPassword, "");
            if (!(txtPassword.TextLength == 0))
            {
                lblPass.Text = "";
            }
        }
        private void Limpiar()
        {
            txtPassword.Text = "";
            txtUsuario.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //string usuario, pass;
        //usuario = txtUsuario.Text;
        //pass = txtPassword.Text;

        //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=ISISTEMAS;Integrated Security=True");
        //SqlCommand cmd = new SqlCommand("USER_LOGIN", conexion);
        //cmd.CommandType = CommandType.StoredProcedure;

        //SqlParameter paramUsuario = new SqlParameter("@USUARIO", SqlDbType.VarChar, 20);
        //SqlParameter paramPass = new SqlParameter("@PASS", SqlDbType.VarBinary, 64);

        //paramUsuario.Value = usuario;
        //paramPass.Value = Encoding.ASCII.GetBytes(pass);

        //cmd.Parameters.Add(paramUsuario);
        //cmd.Parameters.Add(paramPass);

        //try
        //{
        //    conexion.Open();
        //    SqlDataReader leer = cmd.ExecuteReader();

        //    if (leer.HasRows)
        //    {
        //        MessageBox.Show("Bienvenido " + usuario);
        //        this.Hide();
        //        Menu frm = new Menu();
        //        frm.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Usuario o Contraseña incorrectas");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Error" + ex.Message);
        //}
        //finally
        //{
        //    conexion.Close();
        //}

        //string nombre, contraseña;
        //nombre = txtUsuario.Text;
        //contraseña = txtPassword.Text;
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ISISTEMAS;Integrated Security=True");
        //con.Open();

        //string sql = "select USUARIO,PASS from USUARIOS where USUARIO = '" + nombre + "'AND PASS = '" + contraseña + "'";
        //SqlCommand cmd = new SqlCommand(sql, con);
        //SqlDataReader read = cmd.ExecuteReader();
        //if (read.Read())
        //{
        //    this.Hide();
        //    MessageBox.Show("Bienvenido " + nombre);
        //    Menu frm = new Menu();
        //    frm.Show();

        //}
        //else
        //{
        //    MessageBox.Show("No existe ese usuario " + nombre);
        //}
        //N_Usuarios usuario = new N_Usuarios();
        //var validacion = usuario.Login(txtUsuario.Text, txtPassword.Text);
        //if (validacion==true)
        //{
        //    Menu dash = new Menu();
        //    dash.Show();

        //}
    }


            }
        
    

