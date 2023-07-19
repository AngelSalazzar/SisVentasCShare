using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Usuarios
    {
        public Conexion cn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        SqlDataReader leer;

        public DataTable Mostrar()
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "MOSTRAR_USU";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            dt.Load(leer);
            cn.CerrarConexion();
            return dt;
        }

        public void insertar(string usuario, byte[] pass, string tipousuario)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "INSERTAR_USUARIO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@USUARIO", usuario);
            cmd.Parameters.AddWithValue("@PASS", pass);
            cmd.Parameters.AddWithValue("@TIPO_USUARIO", tipousuario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = cn.CerrarConexion();

        } 
        public void DeditarU(int id_usuario, string usuario, string tipousuario)
        {
            cmd.Connection= cn.AbrirConexion();
            cmd.CommandText = "EDITAR_USUARIO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
            cmd.Parameters.AddWithValue("@USUARIO", usuario);
            cmd.Parameters.AddWithValue("@TIPOUSUARIO", tipousuario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void DeliminarU(int id_usuario)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "ELIMINAR_USUARIO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ID_USUARIO", id_usuario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        //private SqlDataReader leer;

        public bool Login(string USUARIO, string PASS)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "USUARIOLOGIN";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@USUARIO", USUARIO);
            cmd.Parameters.AddWithValue("@PASS", PASS);
            leer = cmd.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    E_Usuarios.USUARIO = leer.GetString(1);
                    E_Usuarios.TIPOUSUARIO = leer.GetString(3);
                }
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
