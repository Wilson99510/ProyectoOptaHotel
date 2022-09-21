using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace ProyectoOptaHotel
{
    public partial class frmLogin : Form
    {
        ConexionSqlN cn = new ConexionSqlN();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (cn.conSql(txt_Usuario.Text, txt_Contraseña.Text) == 1)
            {
                MessageBox.Show("Usuario Correcto!!");
                this.Hide();
                frmPrincipal v1 = new frmPrincipal();
                v1.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto!!");
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
