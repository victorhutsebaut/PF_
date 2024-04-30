using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PF_48662379Z_49970058M_49478171L
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void txb_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_registro_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txb_usuario.Text;
            pass = txb_contraseña.Text;
            SqlConnection conexión = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI");
            SqlCommand comandosql = new SqlCommand();
            try
            {
                conexión.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido establecer conexion con la base de datos");

            }
            comandosql.Connection = conexión;
            comandosql.CommandText = "INSERT INTO usuarios(usuario,contraseña) values (@user,@pass)";

            comandosql.Parameters.AddWithValue("@user", user);
            comandosql.Parameters.AddWithValue("@pass", pass);

            try
            {
                comandosql.ExecuteNonQuery();
                MessageBox.Show("USUARIO REGISTRADO");
                this.Hide();
                InicioSesion inicioSesion = new InicioSesion();
                inicioSesion.Show();



            }catch (Exception ex)
            {
                MessageBox.Show("El usuario no ha podido ser registrado ");
            }
        }

        private void btn_cerrar_registro_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
