using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using conexion; // Asegúrate de tener una referencia al proyecto de conexión

namespace negocio.clients
{
    public interface IRegister
    {
        void CrearCliente(string nombreCompleto, string direccion, string correo, string celNumero, string documentoIdentidad);
    }

    public class Register : IRegister
    {
        private Conexion _conexion;

        public Register()
        {
            _conexion = new Conexion(); // Usa la clase de conexión del proyecto "conexion"
        }

        public void CrearCliente(string nombreCompleto, string direccion, string correo, string celNumero, string documentoIdentidad)
        {
            try
            {
                DateTime fechaCreacion = DateTime.Now;

                _conexion.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand("crear_cliente", _conexion.GetConnection()))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_nombre_completo", nombreCompleto);
                    cmd.Parameters.AddWithValue("p_direccion", direccion);
                    cmd.Parameters.AddWithValue("p_correo", correo);
                    cmd.Parameters.AddWithValue("p_cel_numero", celNumero);
                    cmd.Parameters.AddWithValue("p_documento_identidad", documentoIdentidad);
                    cmd.Parameters.AddWithValue("p_fecha_creacion", fechaCreacion);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                _conexion.CloseConnection();
            }
        }
    }
}