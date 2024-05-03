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
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            // Sobreescribe el método ToString para asegurar que el texto correcto se muestra en el ComboBox.
            public override string ToString()
            {
                return Text;
            }
        }

        public MenuCompra()
        {
            InitializeComponent();

            cbBaterias.SelectedIndexChanged += new EventHandler(ComboBoxes_SelectedIndexChanged);
            cbMotores.SelectedIndexChanged += new EventHandler(ComboBoxes_SelectedIndexChanged);
            cbBicicleta.SelectedIndexChanged += new EventHandler(ComboBoxes_SelectedIndexChanged);
        }

        private decimal ObtenerPrecioPorId(string tableName, int itemId)
        {
            decimal precio = 0;
            string connectionString = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            // Asegúrate de que la columna para el ID y el precio sean correctas.
            string query = $"SELECT Precio FROM {tableName} WHERE ID = @ItemId";  // Ajusta 'PrecioBase' y 'ID' si son diferentes.

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemId", itemId);

                try
                {
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        precio = Convert.ToDecimal(result);
                    }
                    // Para depuración
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el precio: " + ex.Message);
                }
            }

            return precio;
        }


        private void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void UpdatePrice()
        {
            decimal precioTotal = 0;

            // Baterías
            if (cbBaterias.SelectedValue != null && int.TryParse(cbBaterias.SelectedValue.ToString(), out int idBateria))
            {
                precioTotal += ObtenerPrecioPorId("Baterias", idBateria);
            }

            // Motores
            if (cbMotores.SelectedValue != null && int.TryParse(cbMotores.SelectedValue.ToString(), out int idMotor))
            {
                precioTotal += ObtenerPrecioPorId("Motores", idMotor);
            }

            // Bicicletas
            if (cbBicicleta.SelectedValue != null && int.TryParse(cbBicicleta.SelectedValue.ToString(), out int idBicicleta))
            {
                precioTotal += ObtenerPrecioPorId("Bicicletas", idBicicleta);
            }

            lPrecio.Text = $"{precioTotal:C}";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void cbModelos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet3.Motores' Puede moverla o quitarla según sea necesario.
            this.motoresTableAdapter.Fill(this.masterDataSet3.Motores);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet2.Baterias' Puede moverla o quitarla según sea necesario.
            this.bateriasTableAdapter.Fill(this.masterDataSet2.Baterias);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Bicicletas' Puede moverla o quitarla según sea necesario.
            this.bicicletasTableAdapter.Fill(this.masterDataSet.Bicicletas);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
