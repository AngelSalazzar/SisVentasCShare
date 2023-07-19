using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Proveedores
    {
        public Conexion cn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        SqlDataReader leer;
        public void insertar(string proveedor, int ruc, string direccion)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "INSERTAR_PROVEE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor);
            cmd.Parameters.AddWithValue("@RUC", ruc);
            cmd.Parameters.AddWithValue("@DIRECCION", direccion);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();


        }
        public void DeditarProv(int id_proveedor, string nombres, int ruc, string direccion)
        {
            cmd.Connection= cn.AbrirConexion();
            cmd.CommandText = "EDITAR_PROVEEDOR";
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_PROVEEDORES", id_proveedor);
            cmd.Parameters.AddWithValue("@NOMBRES", nombres);
            cmd.Parameters.AddWithValue("@RUC", ruc);
            cmd.Parameters.AddWithValue("@DIRECCION", direccion);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }
        public void DeliminarProv(int id_proveedor)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "ELIMINAR_PROVEEDOR";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_PROVEEDORES", id_proveedor);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public DataTable Mostrar()
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "MOSTRAR_PROVEE";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            dt.Load(leer);
            cn.CerrarConexion();
            return dt;
        }
    }
}
