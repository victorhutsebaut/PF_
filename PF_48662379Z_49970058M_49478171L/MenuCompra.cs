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
using System.Collections;

namespace PF_48662379Z_49970058M_49478171L
{
    public partial class MenuCompra : Form
    {
        public MenuCompra()
        {
            InitializeComponent();
            CargarModelosBicicletas();
            CargarBaterias();
            CargarMotores();
        }

        private void CargarModelosBicicletas()
        {
            string connectionString = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            string query = "SELECT BicicletaID, NombreModelo FROM Bicicletas";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbModelos.DisplayMember = "Text";
                    cbModelos.ValueMember = "Value";

                    while (reader.Read())
                    {
                        cbModelos.Items.Add(new { Text = reader["NombreModelo"].ToString(), Value = reader["BicicletaID"].ToString() });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los modelos de bicicletas: " + ex.Message);
                }
            }
        }
        private void CargarBaterias()
        {
            string connectionString = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
        string query = "SELECT Nombre FROM Baterias";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbBaterias.DisplayMember = "Text";
                    cbBaterias.ValueMember = "Value";

                    while (reader.Read())
                    {
                        string nombre = reader["Nombre"].ToString();
                        cbBaterias.Items.Add(nombre);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los modelos de bicicletas: " + ex.Message);
                }
            }
        }

        private void CargarMotores()
        {
            string connectionString = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            string query = "SELECT Nombre FROM Motores";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbMotores.DisplayMember = "Text";
                    cbMotores.ValueMember = "Value";

                    while (reader.Read())
                    {
                        string nombre = reader["Nombre"].ToString();
                        cbMotores.Items.Add(nombre);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los modelos de bicicletas: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
