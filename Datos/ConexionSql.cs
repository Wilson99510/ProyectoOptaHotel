using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConexionSql
    {
        static string conexionstring = "Server = DESKTOP-VI1B9TJ; database = dbhotel;" +
            "integrated security = true";
        SqlConnection con = new SqlConnection(conexionstring);
        public int ConsultaLogin(string usuario, string contraseña)
        {
            int count;
            con.Open();
            string query = "Select count(*) from empleado where usuario = '" + usuario + "'" +
                " and contraseña = '" + contraseña + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            return count;
        }
    }
}
