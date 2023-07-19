using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Cliente
    {
        D_Clientes objD = new D_Clientes();
        public void InsertarCli(string cliente,string direccion,string dni, string celular)
        {
            objD.insertar(cliente, direccion, Convert.ToInt32(dni), Convert.ToInt32(celular));
        }
        public void NeditarC(string id_clientes, string nombres,string direccion, string dni, string numcelular)
        {
            objD.DeditarC(Convert.ToInt32(id_clientes), nombres, direccion, Convert.ToInt32(dni), Convert.ToInt32(numcelular));
        }
        public void NelimininarC(string id_clientes)
        {
            objD.DeliminarC(Convert.ToInt32(id_clientes));
        }
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            dt = objD.Mostrar();
            return dt;
        }

        public bool Buscar_cli(int codigo)
        {
            return objD.Busqueda_Cliente(codigo);
        }
    }
}
