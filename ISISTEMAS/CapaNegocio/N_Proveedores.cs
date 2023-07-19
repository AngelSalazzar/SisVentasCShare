using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Proveedores
    {
        D_Proveedores objProve = new D_Proveedores();
        public void InsertarCli(string nombre, string ruc, string direccion)
        {
            objProve.insertar(nombre, Convert.ToInt32(ruc), direccion);
        }
        public void NeditarProv(string id_proveedor, string nombres, string ruc, string direccion)
        {
            objProve.DeditarProv(Convert.ToInt32(id_proveedor), nombres, Convert.ToInt32(ruc), direccion);
        }
        public void NeliminarProv(string id_proveedor)
        {
            objProve.DeliminarProv(Convert.ToInt32(id_proveedor));
        }
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            dt = objProve.Mostrar();
            return dt;
        }
    }
}
