using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio.clients;

namespace rudoolf_motors.clients
{
    public partial class register : Form
    {
        private IRegister _registerClient; // Interfaz para el registro de clientes

        public register()
        {
            InitializeComponent();
            _registerClient = new Register(); // Instancia de la clase Register del proyecto negocio
        }

        private void nombre_completo_TextChanged(object sender, EventArgs e)
        {
            // Lógica opcional cuando el texto cambia
        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {
            // Lógica opcional cuando el texto cambia
        }

        private void correo_TextChanged(object sender, EventArgs e)
        {
            // Lógica opcional cuando el texto cambia
        }

        private void numero_cel_TextChanged(object sender, EventArgs e)
        {
            // Lógica opcional cuando el texto cambia
        }

        private void documento_identidad_TextChanged(object sender, EventArgs e)
        {
            // Lógica opcional cuando el texto cambia
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            // Asignar los valores de los TextBox a las variables
            string nombreCompleto = nombre_completo.Text; // nombre_completo es un TextBox
            string direccion = this.direccion.Text; // direccion es un TextBox
            string correo = this.correo.Text; // correo es un TextBox
            string numeroCel = numero_cel.Text; // numero_cel es un TextBox
            string documentoIdentidad = documento_identidad.Text; // documento_identidad es un TextBox

            try
            {
                // Validación de correo electrónico
                if (!EsCorreoValido(correo))
                {
                    resultado.Text = "Correo electrónico no válido.";
                    return;
                }

                // Llamada al procedimiento almacenado para crear el cliente
                _registerClient.CrearCliente(nombreCompleto, direccion, correo, numeroCel, documentoIdentidad);
                resultado.Text = "Cliente creado exitosamente.";
            }
            catch (Exception ex)
            {
                resultado.Text = $"Error al crear el cliente: {ex.Message}";
            }
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            // No se requiere lógica para el label resultado
        }

        private bool EsCorreoValido(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }
    }
}