using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Usuarios
    {
        D_Usuarios objUsu = new D_Usuarios();
        DataTable dt = new DataTable();

        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            dt = objUsu.Mostrar();
            return dt;
        }

        public bool Login(string USUARIO, string PASS)
        {
            return objUsu.Login(USUARIO, PASS);
        }

        public void InsertarUsu(string usuario, string pass, string tipousuario)
        {
            objUsu.insertar(usuario, Encoding.UTF8.GetBytes(pass), tipousuario);
        }
        
        public void NeditarU(string id_usuario, string usuario, string tipousuario)
        {
            objUsu.DeditarU(Convert.ToInt32(id_usuario),usuario,tipousuario);
        }
        public void NeliminarU(string id_usuario)
        {
            objUsu.DeliminarU(Convert.ToInt32(id_usuario));
        }
    }
}
