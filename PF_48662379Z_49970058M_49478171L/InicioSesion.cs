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


namespace PF_48662379Z_49970058M_49478171L
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_inicio_sesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox_mostrar_contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mostrar_contraseña.Checked == true)
            {
                txb_contraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txb_contraseña.UseSystemPasswordChar=true;
            }
        }

        private void btn_entrar_inicio_sesion_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txb_usuario.Text;
            pass = txb_contraseña.Text;
            SqlConnection conexión = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI");
            SqlCommand comandosql = new SqlCommand();
            try
            {
                conexión.Open();

            } catch (Exception ex)
            {
                MessageBox.Show("No se ha podido establecer conexion con la base de datos");

            }
            comandosql.Connection = conexión;
            comandosql.CommandText = "SELECT usuario,contraseña FROM usuarios WHERE user=usuario AND pass=contraseña";
            SqlDataReader midatareader = comandosql.ExecuteReader();

            if (midatareader.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido" + user);


            }
            else
            {
                MessageBox.Show("No existe el usuario"+user);
            }

            }

        private void txb_usuario_Leave(object sender, EventArgs e)
        {
            if (txb_usuario.Text == "")
            {
                txb_usuario.Text = "Ingrese su usuario";
                txb_usuario.ForeColor = Color.Black;
            }
        }

        private void txb_usuario_Enter(object sender, EventArgs e)
        {
            if (txb_usuario.Text == "Ingrese su usuario")
            {
                txb_usuario.Text = "";
                txb_usuario.ForeColor = Color.Black;
            }
        }

        private void txb_contraseña_Leave(object sender, EventArgs e)
        {
            if (txb_contraseña.Text == "")
            {

                txb_contraseña.Text = "Ingrese su contraseña";
                txb_contraseña.ForeColor = Color.Black;
                txb_contraseña.UseSystemPasswordChar = false;
            }
        }

        private void txb_contraseña_Enter(object sender, EventArgs e)
        {
            if (txb_contraseña.Text == "Ingrese su contraseña")
            {

                txb_contraseña.Text = "";
                txb_contraseña.ForeColor = Color.Black;
                txb_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void btn_registrarse_inicio_sesion_Click(object sender, EventArgs e)
        {
            RegistroUsuarios registrar = new RegistroUsuarios();
            this.Hide();
            registrar.Show();


        }
    }
}
