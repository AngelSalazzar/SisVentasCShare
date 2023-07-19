using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Productos
    {
        public Conexion cn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        SqlDataReader leer;
        public void insertar(string producto, decimal precio, int cantidad, string categoria, string descripcion, string formapago)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "INSERTAR_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTO", producto);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@CANTIDAD", cantidad);
            cmd.Parameters.AddWithValue("@CATEGORIA", categoria);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("@FORMAPAGO", formapago);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();


        }
        public void DeditarProd(int id_productos, string producto, decimal precio, decimal cantidad, string categoria, string descripcion, string forma)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "EDITAR_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_PRODUCTOS", id_productos);
            cmd.Parameters.AddWithValue("@PRODUCTO", producto);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@CANTIDAD", cantidad);
            cmd.Parameters.AddWithValue("@CATEGORIA", categoria);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("@FORMAPAGO", forma);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void DeliminarProd(int id_productos)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "ELIMINAR_PROD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ID_PRODUCTOS", id_productos);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public DataTable Mostrar()
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "MOSTRAR_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            dt.Load(leer);
            cn.CerrarConexion();
            return dt;
        }

        public bool Busqueda(int codigo)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "Buscar_Producto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_PRODUCTO", codigo);
            leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    E_Productos.NOMBRE = leer.GetString(1);
                    E_Productos.PRECIO = leer.GetInt32(2);
                    E_Productos.CANTIDAD = leer.GetInt32(3);
                }
                return true;
            }
            else { return false; }

        }

        public DataTable Reg_fc(string vendedor, DateTime fecha, int cli, string cliente, int prd, string producto, int cant, decimal total)
        {

            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "Reg_ven";
            cmd.Parameters.AddWithValue("@ID_CLIENTE", cli);
            cmd.Parameters.AddWithValue("@ID_PRODUCTO", prd);
            cmd.Parameters.AddWithValue("@NOM_V", vendedor);
            cmd.Parameters.AddWithValue("@FECHA", fecha);
            cmd.Parameters.AddWithValue("@CANT_PED", cant);
            cmd.Parameters.AddWithValue("@TOTAL", total);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.CerrarConexion();
            return dt;
        }

        public DataTable mostrar_fc() {
            DataTable dt1 = new DataTable();
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "mostar_fac";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            dt1.Load(leer);
            cn.CerrarConexion();
            return dt1;
        }

        public DataTable reducir(int cod, int can)
        {
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "Reducir_stock";
            cmd.Parameters.AddWithValue("@ID_PRODUCTO", cod);
            cmd.Parameters.AddWithValue("@CANTIDAD", can);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.CerrarConexion();
            return dt;
        }
    }
}
