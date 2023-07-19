using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Usuarios
    {
        public static int IDUSUARIO { get; set; }
        public static string USUARIO { get; set; }
        public static SqlBinary PASS { get; set; }
        public static string TIPOUSUARIO { get; set; }
    }
}
