using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoOptaHotel
{
    public partial class frmProductos : Form
    {
        SqlConnection con = new SqlConnection("Server = DESKTOP-VI1B9TJ; database = dbhotel;" +
            "integrated security = true");
        public void poblar()
        {
            con.Open();
            string consulta = "select * from producto";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ProductoGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        public frmProductos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            poblar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into producto values(" + txtIdProducto.Text + ",'" + txtNombre.Text + "','" + txtDescripcion.Text + "','" + cboUni_Medida.SelectedItem.ToString() + "','" +txtPrecioVenta.Text+ "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Exitoso");
            con.Close();
            poblar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductoGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProducto.Text = ProductoGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = ProductoGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtDescripcion.Text = ProductoGridView.SelectedRows[0].Cells[2].Value.ToString();
            cboUni_Medida.Text = ProductoGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtPrecioVenta.Text = ProductoGridView.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
