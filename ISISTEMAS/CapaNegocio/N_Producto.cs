using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Producto
    {
        D_Productos objProd = new D_Productos();
        public void InsertarProd(string producto, decimal precio, int cantidad, string categoria, string descripcion, string forma)
        {
            objProd.insertar(producto, precio, cantidad, categoria, descripcion, forma);
        }
        public void NeditarProd(string id_productos, string producto, string precio, string cantidad, string categoria, string descripcion, string forma)
        {
            objProd.DeditarProd(Convert.ToInt32(id_productos), producto, Convert.ToInt32(precio), Convert.ToInt32(cantidad), categoria, descripcion, forma);
        }
        public void NeliminarProd(string id_producto)
        {
            objProd.DeliminarProd(Convert.ToInt32(id_producto));
        }
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            dt = objProd.Mostrar();
            return dt;
        }

        public bool Buscar_Prd(int codigo)
        {
            return objProd.Busqueda(codigo);
        }

        public DataTable Registro_fac(string vendedor, DateTime fecha, int cli, string cliente, int prd, string producto, int cant, decimal total)
        {
            return objProd.Reg_fc(vendedor, fecha, cli, cliente, prd, producto, cant, total);
        }

        public DataTable mostrar_factura()
        {
            return objProd.mostrar_fc();
        }
        public DataTable reducir(int cod, int can)
        {
            return objProd.reducir(cod, can);
        }
    }
}
