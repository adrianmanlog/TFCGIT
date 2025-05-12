using Manejo.Manejadores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TFCAdrianGalilea
{
    public partial class InsertarClientes : Form
    {
        private readonly ClienteController clienteController;
        private Dictionary<TextBox, (Label, string)> validaciones;
        private HashSet<string> dnisExistentes;
        private ToolTip toolTip;

        public InsertarClientes()
        {
            InitializeComponent();

            clienteController = new ClienteController();

            dnisExistentes = clienteController.ObtenerClientes()
                                              .Select(c => c.DniDTO)
                                              .ToHashSet(StringComparer.OrdinalIgnoreCase);

            validaciones = new Dictionary<TextBox, (Label, string)>
            {
                { textBoxDNI, (labelDNI, @"^\d{8}[A-HJ-NP-TV-Z]$") },
                { textBoxCorreo, (labelCorreo, @"^[\w\.-]+@[\w\.-]+\.\w{2,4}$") },
                { textBoxTelefono, (labelTelefono, @"^\d{9}$") },
                { textBoxCodPostal, (labelCodPostal, @"^\d{5}$") }
            };

            foreach (var kvp in validaciones)
            {
                kvp.Key.TextChanged += ValidarCampos;
            }

            toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Warning;
            toolTip.ToolTipTitle = "DNI duplicado";

            ValidarCampos(null, null);
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

                bool valido = Regex.IsMatch(textBox.Text, regex);

                if (textBox == textBoxDNI && valido)
                {
                    string dniIngresado = textBox.Text.Trim();
                    bool dniDuplicado = dnisExistentes.Contains(dniIngresado);

                    if (dniDuplicado)
                    {
                        label.ForeColor = Color.Red;
                        label.Text = "DNI (ya existe)";
                        toolTip.Show("Este DNI ya está registrado en la base de datos.", textBoxDNI, 0, -40, 3000);
                        todosValidos = false;
                        continue;
                    }
                    else
                    {
                        label.Text = "DNI";
                        toolTip.Hide(textBoxDNI);
                    }
                }

                if (!valido)
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
            Manejo.EntidadesDTO.ClienteDTO cliente = new Manejo.EntidadesDTO.ClienteDTO
            {
                DniDTO = textBoxDNI.Text.Trim(),
                NombreDTO = textBoxNombre.Text.Trim(),
                ApellidoDTO = textBoxApellido.Text.Trim(),
                TelefonoDTO = textBoxTelefono.Text.Trim(),
                CorreoElectronicoDTO = textBoxCorreo.Text.Trim(),
                DomicilioDTO = textBoxDomicilio.Text.Trim(),
                CodigoPostalDTO = textBoxCodPostal.Text.Trim()
            };

            Manejo.Manejadores.ClienteController clienteController = new Manejo.Manejadores.ClienteController();

            if (clienteController.InsertarCliente(cliente))
            {
                MessageBox.Show("Cliente insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar el cliente. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            textBoxDNI.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
            textBoxDomicilio.Clear();
            textBoxCodPostal.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDniUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelInsertar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void labelCodPostal_Click(object sender, EventArgs e)
        {

        }

        private void labelDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelCorreo_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefono_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void labelDNI_Click(object sender, EventArgs e)
        {

        }
    }
}
