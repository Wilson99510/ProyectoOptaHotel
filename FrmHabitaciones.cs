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
    public partial class FrmHabitaciones : Form
    {
        SqlConnection con = new SqlConnection("Server = DESKTOP-VI1B9TJ; database = dbhotel;" +
            "integrated security = true");
        public void poblar()
        {
            con.Open();
            string consulta = "select * from habitacion";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet(); 
            da.Fill(ds);
            HabitacionGridView.DataSource = ds.Tables[0];   
            con.Close();
        }
    public FrmHabitaciones()
        {
            InitializeComponent();
        }

        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            poblar();   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into habitacion values(" + txtIdHabitacion.Text + ",'" + txtNumero.Text + "','" + cboPiso.SelectedItem.ToString() + "','" + txtCaracteristicas.Text + "','" + txtPrecioDiario.Text + "','" + cboEstado.SelectedItem.ToString() + "','" + cboTipoHabitacion.SelectedItem.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Exitoso");
            con.Close();
            poblar();
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HabitacionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdHabitacion.Text = HabitacionGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtNumero.Text = HabitacionGridView.SelectedRows[0].Cells[1].Value.ToString();
            cboPiso.Text = HabitacionGridView.SelectedRows[0].Cells[2].Value.ToString();    
            txtCaracteristicas.Text = HabitacionGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtPrecioDiario.Text = HabitacionGridView.SelectedRows[0].Cells[4].Value.ToString();
            cboEstado.Text = HabitacionGridView.SelectedRows[0].Cells[5].Value.ToString();
            cboTipoHabitacion.Text = HabitacionGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "UPDATE habitacion set numero_habitacion='" + txtNumero.Text + "',piso='" + cboPiso.SelectedItem.ToString() + "',caracteristicas='" + txtCaracteristicas.Text + "',precio_diario='" + txtPrecioDiario.Text + "',estado_habitacion='" + cboEstado.SelectedItem.ToString() + "',tipo_habitacion='" + cboTipoHabitacion.SelectedItem.ToString() + "' where idhabitacion=" + txtIdHabitacion.Text + ";";
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modificación Exitosa");
            con.Close();
            poblar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "delete from habitacion where idhabitacion = "+txtIdHabitacion.Text+"";
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Habitación Eliminada");
            con.Close();
            poblar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            con.Open();
            string consulta = "select * from habitacion where numero_habitacion='"+txtBuscar.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            HabitacionGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void picActualizar_Click(object sender, EventArgs e)
        {
            poblar();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
