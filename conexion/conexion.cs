using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DotNetEnv;

namespace conexion
{
    public class Conexion
    {
        private MySqlConnection _connection;
        private bool _isConnected;

        // Datos de conexión directamente en la clase
        private const string Host = "localhost";
        private const int Port = 3307;
        private const string Database = "SistemaVentas";
        private const string User = "root";
        private const string Password = "112233sql";

        public Conexion(bool connectAutomatically = true)
        {
            try
            {
                // Crear la cadena de conexión
                string connectionString = $"Server={Host};" +
                                          $"Port={Port};" +
                                          $"Database={Database};" +
                                          $"User ID={User};" +
                                          $"Password={Password};";

                // Inicializar la conexión
                _connection = new MySqlConnection(connectionString);

                // Intentar conectar automáticamente si connectAutomatically es true
                _isConnected = false;
                if (connectAutomatically)
                {
                    OpenConnection();
                }
            }
            catch (Exception)
            {
                throw; // Re-lanzar la excepción para que sea manejada externamente si es necesario
            }
        }

        public MySqlConnection GetConnection()
        {
            return _connection;
        }

        public void OpenConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                    _isConnected = true;
                }
            }
            catch (MySqlException)
            {
                _isConnected = false;
                throw; // Re-lanzar la excepción para que pueda ser manejada externamente si es necesario
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
                _isConnected = false;
            }
        }

        public bool IsConnected()
        {
            return _isConnected;
        }
    }
}