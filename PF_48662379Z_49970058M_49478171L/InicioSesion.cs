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
            Application.Exit();
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
            
            SqlConnection conexión = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI");
            SqlCommand comandosql = new SqlCommand();


            if (cbx_roles_inicio_sesion.Text == "")
            {
                MessageBox.Show("Debe introducir su rol");
            }
            else if (cbx_roles_inicio_sesion.Text == "Administrador")
            {
                try
                {
                    conexión.Open();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido establecer conexion con la base de datos");

                }
                string user, pass;
                user = txb_usuario.Text;
                pass = txb_contraseña.Text;
                comandosql.Connection = conexión;
                comandosql.CommandText = "SELECT usuario,contraseña FROM administradores WHERE usuario=@user AND contraseña=@pass";
                comandosql.Parameters.AddWithValue("@user", user);
                comandosql.Parameters.AddWithValue("@pass", pass);
                SqlDataReader midatareader = comandosql.ExecuteReader();
                
                comandosql.Parameters.Clear();
                if (midatareader.Read())
                {
                    this.Hide();
                    PanelAdmin panel=new PanelAdmin();
                    panel.Show();   

                }
                else
                {
                    MessageBox.Show("No existe el administrador " + user);
                }


            }
            else
            {

                try
                {
                    conexión.Open();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido establecer conexion con la base de datos");

                }
                string user, pass;
                user = txb_usuario.Text;
                pass = txb_contraseña.Text;
                comandosql.Connection = conexión;
                comandosql.CommandText = "SELECT usuario,contraseña FROM usuarios WHERE usuario=@user AND contraseña=@pass";
                comandosql.Parameters.AddWithValue("@user", user);
                comandosql.Parameters.AddWithValue("@pass", pass);
                SqlDataReader midatareader = comandosql.ExecuteReader();
                
                comandosql.Parameters.Clear();

                if (midatareader.Read())
                {
                    this.Hide();
                    MenuCompra menuCompra = new MenuCompra();
                    menuCompra.Show();
                }
                else
                {
                    MessageBox.Show("No existe el usuario " + user);
                }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
