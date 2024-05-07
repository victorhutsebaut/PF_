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

namespace PF_48662379Z_49970058M_49478171L
{
    public partial class PanelAdmin : Form
    {
        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuariosDataSet.usuarios' Puede moverla o quitarla según sea necesario.

            LoadUsersToListView();
        }
        public PanelAdmin()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(PanelAdmin_FormClosed);
        }

        private void PanelAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.ShowDialog();
        }
    
        private void LoadUsersToListView()
        {
            // Define tu cadena de conexión aquí
            SqlConnection conexión = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI");

            // Consulta SQL para recuperar los datos de la tabla "usuarios"
            string query = "SELECT usuario, contraseña FROM usuarios";

            // Establecer la conexión a la base de datos

            // Crear un comando SQL
            SqlCommand command = new SqlCommand(query, conexión);

            // Abrir la conexión
            conexión.Open();

            // Ejecutar la consulta y obtener los resultados
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // Limpiar el ListView antes de añadir nuevos datos
                listViewusuarios.Items.Clear();

                // Iterar a través de los resultados
                while (reader.Read())
                {
                    // Crear un nuevo ListViewItem
                    ListViewItem item = new ListViewItem(reader["usuario"].ToString());

                    // Añadir el item al ListView
                    listViewusuarios.Items.Add(item);

                    // Añadir la contraseña como subítem (si lo deseas)
                    item.SubItems.Add(reader["contraseña"].ToString());


                }
            }



        }



        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }



        private void listViewusuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            // Obtener el valor del nombre de usuario y la contraseña de los TextBoxes
            string nuevoUsuario = txb_usuario.Text;
            string nuevaContraseña = txb_contraseña.Text;

            // Verificar si los campos no están vacíos
            if (string.IsNullOrWhiteSpace(nuevoUsuario) || string.IsNullOrWhiteSpace(nuevaContraseña))
            {
                MessageBox.Show("Por favor, introduce un nombre de usuario y una contraseña.");
                return;
            }

            // Define la cadena de conexión
            string connectionString = "server=(local)\\SQLEXPRESS;database=master;Integrated Security=SSPI";

            // Consulta SQL para insertar un nuevo usuario
            string query = "INSERT INTO usuarios (usuario, contraseña) VALUES (@usuario, @contraseña)";

            try
            {
                // Usar un bloque using para manejar la conexión de base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Crear un comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Añadir parámetros a la consulta
                        command.Parameters.AddWithValue("@usuario", nuevoUsuario);
                        command.Parameters.AddWithValue("@contraseña", nuevaContraseña);

                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();

                        // Añadir el nuevo usuario a la ListView
                        ListViewItem newItem = new ListViewItem(nuevoUsuario);
                        newItem.SubItems.Add(nuevaContraseña);
                        listViewusuarios.Items.Add(newItem);

                        // Mostrar un mensaje de éxito
                        MessageBox.Show("Usuario añadido correctamente.");
                    }
                }

                // Limpia los TextBoxes después de añadir el usuario
                txb_usuario.Clear();
                txb_contraseña.Clear();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show($"Error al añadir usuario: {ex.Message}");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Verifica que haya un elemento seleccionado en la ListView
            if (listViewusuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
                return;
            }

            // Obtiene el usuario y contraseña seleccionados de la ListView
            ListViewItem selectedItem = listViewusuarios.SelectedItems[0];
            string usuarioSeleccionado = selectedItem.SubItems[0].Text;
            string contraseñaSeleccionada = selectedItem.SubItems[1].Text;

            // Define la cadena de conexión
            string connectionString = "server=(local)\\SQLEXPRESS;database=master;Integrated Security=SSPI";

            // Consulta SQL para eliminar el usuario seleccionado de la base de datos
            string query = "DELETE FROM usuarios WHERE usuario = @usuario AND contraseña = @contraseña";

            try
            {
                // Usar un bloque using para manejar la conexión de base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Crear un comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Añadir parámetros a la consulta
                        command.Parameters.AddWithValue("@usuario", usuarioSeleccionado);
                        command.Parameters.AddWithValue("@contraseña", contraseñaSeleccionada);

                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();

                        // Eliminar el elemento de la ListView
                        listViewusuarios.Items.Remove(selectedItem);

                        // Mostrar un mensaje de éxito
                        MessageBox.Show("Usuario eliminado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}");
            }
        }


    }
}
