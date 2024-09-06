using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conexion;

namespace negocio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear una instancia de la clase Conexion
            Conexion conexion = new Conexion();

            try
            {
                // Abrir la conexión
                conexion.OpenConnection();

                // Realizar operaciones con la base de datos aquí...

            }
            catch (Exception ex)
            {
                // Manejar excepciones según sea necesario
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // Cerrar la conexión
                conexion.CloseConnection();
            }
        }
    }
}