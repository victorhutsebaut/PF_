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
using Excel = Microsoft.Office.Interop.Excel;

namespace PF_48662379Z_49970058M_49478171L
{
    public partial class MenuCompra : Form
    {
        public decimal precioTotal = 0;
        public MenuCompra()
        {
            InitializeComponent();

            cbBaterias.SelectedIndexChanged += new EventHandler(ComboBoxes_SelectedIndexChanged);
            cbMotores.SelectedIndexChanged += new EventHandler(ComboBoxes_SelectedIndexChanged);
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

            precioTotal = 0;
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

        private void cbModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            CambiarColor();
        }

        private void CambiarColor()
        {
            string opcionSeleccionada = cbBicicleta.Text;

            switch (opcionSeleccionada)
            {
                case "Paseo":
                    if (rbazul.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.PaseoAzul;
                    }
                    else if (rbnegro.Checked)
                    {
                        MessageBox.Show("Color no disponible", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbnegro.Checked = false;
                    }
                    else if (rbrojo.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.PaseoRoja;
                    }
                    else if (rbrosa.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.PaseoRosa;
                    }
                    else if (rbverde.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.PaseoVerde;
                    }
                    else if (rbnaranja.Checked)
                    {
                        MessageBox.Show("Color no disponible", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbnaranja.Checked = false;
                    }
                    else if (rbneon.Checked)
                    {
                        MessageBox.Show("Color no disponible", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbneon.Checked = false;
                    }
                    break;

                case "Carretera":
                    if (rbazul.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.CarreteraAzul;
                    }
                    else if (rbnegro.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.BicicletaCarreteraNegra;
                    }
                    else if (rbrojo.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.CarreteraRoja;
                    }
                    else if (rbrosa.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.CarreteraRosa;
                    }
                    else if (rbverde.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.CarreteraVerde;
                    }
                    else if (rbnaranja.Checked)
                    {
                        MessageBox.Show("Color no disponible", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbnaranja.Checked = false;
                    }
                    else if (rbneon.Checked)
                    {
                        MessageBox.Show("Color no disponible", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbneon.Checked = false;
                    }
                    break;

                case "Montaña":
                    if (rbazul.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.BicicletaMontañaAzul;
                    }
                    else if (rbnegro.Checked)
                    {
                        MessageBox.Show("Color no disponible", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbnegro.Checked = false;
                    }
                    else if (rbrojo.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.BicicletaMontañaRoja;
                    }
                    else if (rbrosa.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.BicicletaMontañaRosa;
                    }
                    else if (rbverde.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.BicicletaMontañaVerde;
                    }
                    else if (rbnaranja.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.bicicleta_montaña_naranja;
                    }
                    else if (rbneon.Checked)
                    {
                        imagenesBicis.Image = Properties.Resources.BicicletaMontañaNeonAzul;
                    }

                    break;

                default:
                    // Manejo para la opción por defecto (puede ser vacío o una imagen por defecto)
                    imagenesBicis.Image = Properties.Resources.ET;
                    break;

            }
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

        private void btn_carrito_Click(object sender, EventArgs e)
        {

            string connectionString = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(connectionString);

            string Bici = cbBicicleta.Text;
            string Bateria = cbBaterias.Text;
            string Motor = cbMotores.Text;

            string query = "INSERT INTO  Compras(Nombre_Bicicleta, Nombre_Bateria, Nombre_Motor, Precio_Total) VALUES (@bici, @bateria, @motor, @preciototal)";

            try
            {
                conn.Open(); // Abre la conexión
                SqlCommand cmd = new SqlCommand(query, conn);

                // Añadir los parámetros
                cmd.Parameters.AddWithValue("@bici", Bici);
                cmd.Parameters.AddWithValue("@bateria", Bateria);
                cmd.Parameters.AddWithValue("@motor", Motor);
                cmd.Parameters.AddWithValue("@preciototal", precioTotal);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda surgir
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
            finally
            {

                // Cerrar la conexión
                Excel.Application objExcel = new Excel.Application();
                objExcel.Visible = true;
                // Crear un nuevo libro de Excel
                Excel.Workbook objWorkbook = objExcel.Workbooks.Add();

                // Obtener la primera hoja de trabajo del libro
                Excel.Worksheet objWorksheet = (Excel.Worksheet)objWorkbook.Sheets[1];

                // Agregar encabezados a la hoja de trabajo
                objWorksheet.Cells[1, 1] = "Nombre Bicicleta";
                objWorksheet.Cells[1, 2] = "Nombre Bateria";
                objWorksheet.Cells[1, 3] = "Nombre Motor";
                objWorksheet.Cells[1, 4] = "Precio Total";

                // Inicializar una variable para el número de fila
                
                objWorksheet.Cells[2, 1] = Bici;
                objWorksheet.Cells[2, 2] = Bateria;
                objWorksheet.Cells[2, 3] = Motor;
                objWorksheet.Cells[2, 4] = precioTotal;

            }

        }

        private void CambiarColor(object sender, EventArgs e)
        {

        }
    }
}
