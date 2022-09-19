using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class ConexionSqlN
    {
        ConexionSql cn = new ConexionSql();

        public int conSql(string usuario, string contraseña)
        {
            return cn.ConsultaLogin(usuario, contraseña);
        }
    }
}
