using Manejo.Manejadores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TFCAdrianGalilea
{
    public partial class ModificarClientes : Form
    {
        private Dictionary<TextBox, (Label, string)> validaciones;
        private Manejo.EntidadesDTO.ClienteDTO clienteOriginal;

        public ModificarClientes(Manejo.EntidadesDTO.ClienteDTO cliente)
        {
            InitializeComponent();

            validaciones = new Dictionary<TextBox, (Label, string)>
            {
                { textBoxCorreo, (labelCorreo, @"^[\w\.-]+@[\w\.-]+\.\w{2,4}$") },
                { textBoxTelefono, (labelTelefono, @"^\d{9}$") },
                { textBoxCodPostal, (labelCodPostal, @"^\d{5}$") }
            };

            foreach (var kvp in validaciones)
            {
                kvp.Key.TextChanged += ValidarCampos;
            }

            ValidarCampos(null, null);
            clienteOriginal = cliente;

            textBoxNombre.Text = cliente.NombreDTO;
            textBoxApellido.Text = cliente.ApellidoDTO;
            textBoxCorreo.Text = cliente.CorreoElectronicoDTO;
            textBoxTelefono.Text = cliente.TelefonoDTO;
            textBoxDomicilio.Text = cliente.DomicilioDTO;
            textBoxCodPostal.Text = cliente.CodigoPostalDTO;
            comboBoxDniUsuario.Text = cliente.DniUsuarioDTO;
            comboBoxDniUsuario.Text = "16636730W";

        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            bool todosValidos = true;

            foreach (var kvp in validaciones)
            {
                TextBox textBox = kvp.Key;
                Label label = kvp.Value.Item1;
                string regex = kvp.Value.Item2;

                if (!Regex.IsMatch(textBox.Text, regex))
                {
                    label.ForeColor = Color.Red;
                    todosValidos = false;
                }
                else
                {
                    label.ForeColor = Color.White;
                }
            }

            buttonAceptar.Enabled = todosValidos;
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            var cliente = new Manejo.EntidadesDTO.ClienteDTO
            {
                DniDTO = clienteOriginal.DniDTO,
                NombreDTO = textBoxNombre.Text.Trim(),
                ApellidoDTO = textBoxApellido.Text.Trim(),
                CorreoElectronicoDTO = textBoxCorreo.Text.Trim(),
                TelefonoDTO = textBoxTelefono.Text.Trim(),
                DomicilioDTO = textBoxDomicilio.Text.Trim(),
                CodigoPostalDTO = textBoxCodPostal.Text.Trim(),
                DniUsuarioDTO = comboBoxDniUsuario.Text.Trim()
            };

            var clienteController = new Manejo.Manejadores.ClienteController();

            if (clienteController.ModificarCliente(cliente))
            {
                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al modificar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
