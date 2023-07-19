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
    public class D_Clientes
    {
        public Conexion cn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        SqlDataReader leer;
        public void insertar(string cliente,string direccion, int dni, int celular)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "INSERTAR_CLIENTES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CLIENTE", cliente);
            cmd.Parameters.AddWithValue("@DIRECCION", direccion);
            cmd.Parameters.AddWithValue("@DNI", dni);
            cmd.Parameters.AddWithValue("@NUMCELULAR", celular);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();


        }
        public void DeditarC(int ID_CLIENTES, string NOMBRES, string DIRECCION, int DNI, int NUMCELULAR)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "EDITAR_CLIENTES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ID_CLIENTES", ID_CLIENTES);
            cmd.Parameters.AddWithValue("CLIENTE", NOMBRES);
            cmd.Parameters.AddWithValue("DIRECCION", DIRECCION);
            cmd.Parameters.AddWithValue("DNI", DNI);
            cmd.Parameters.AddWithValue("NUMCELULAR", NUMCELULAR);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void DeliminarC (int ID_CLIENTES)
        {
            cmd.Connection= cn.AbrirConexion();
            cmd.CommandText = "ELIMINAR_CLIENTE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ID_CLIENTES", ID_CLIENTES);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public DataTable Mostrar()
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "MOSTRAR_CLIENTES";
            cmd.CommandType = CommandType.StoredProcedure;
            leer= cmd.ExecuteReader();
            dt.Load(leer);
            cn.CerrarConexion();
            return dt;
        }

        public bool Busqueda_Cliente(int codigo)
        {

            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "Buscar_Cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_CLIENTE", codigo);
            leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {

                while (leer.Read())
                {
                    E_Clientes.CLIENTE = leer.GetString(1);
                }
                return true;
            }
            else { return false; }

        }

    }
}
