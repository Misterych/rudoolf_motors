using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using conexion; // Asegúrate de que tienes esta referencia
using System.Text.RegularExpressions;

namespace rudoolf_motors
{
    public partial class Inicio_seccion : Form
    {
        private Conexion conexion;

        public Inicio_seccion()
        {
            InitializeComponent();
            // Inicializa la conexión a la base de datos
            conexion = new Conexion();
        }

        private void Inicio_seccion_Load(object sender, EventArgs e)
        {

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void mostrar_ocultar_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar u ocultar la contraseña
            contraseña.UseSystemPasswordChar = !mostrar_ocultar.Checked;
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string correo = this.correo.Text;
            string clave = this.contraseña.Text;

            // Validar correo electrónico
            if (!EsCorreoValido(correo))
            {
                MessageBox.Show("Correo electrónico no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Encriptar clave
            string hashed_clave = ObtenerHashSHA256(clave);

            try
            {
                // Abrir conexión a la base de datos
                conexion.OpenConnection();

                MySqlConnection connection = conexion.GetConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM Usuarios WHERE correo = @correo AND clave = @clave", connection);
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@clave", hashed_clave);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    // Si las credenciales son correctas, redirigir al formulario 'panel_admin'
                    this.Hide(); // Oculta el formulario de inicio de sesión
                    panel_admin panelAdminForm = new panel_admin(); // Asegúrate de que tienes una clase llamada panel_admin
                    panelAdminForm.Show(); // Muestra el formulario de panel_admin
                }
                else
                {
                    MessageBox.Show("Correo o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al verificar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión
                conexion.CloseConnection();
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool EsCorreoValido(string correo)
        {
            // Expresión regular para validar el correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, pattern);
        }

        private string ObtenerHashSHA256(string texto)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
