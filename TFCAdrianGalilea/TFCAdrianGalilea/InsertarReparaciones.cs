using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TFCAdrianGalilea
{
    public partial class InsertarReparaciones : Form
    {
        public InsertarReparaciones()
        {
            InitializeComponent();
        }

        private void InsertarReparaciones_Load(object sender, EventArgs e)
        {
            var controladorClientes = new Manejo.Manejadores.ClienteController();
            var listaClientes = controladorClientes.ObtenerClientes();

            if (listaClientes == null || !listaClientes.Any())
            {
                MessageBox.Show("No hay clientes activos. No se puede registrar una reparación.");
                comboBoxDniCLiente.Enabled = false;
                buttonAceptar.Enabled = false;
                return;
            }

            comboBoxDniCLiente.DataSource = listaClientes;
            comboBoxDniCLiente.DisplayMember = "DniDTO";
            comboBoxDniCLiente.ValueMember = "DniDTO";

            ConectarEventos();
            ValidarCampos();
        }

        private void ValidarCampos()
        {
            string patronMatricula = @"^[0-9]{4}[A-Z]{3}$";
            bool matriculaValida = Regex.IsMatch(textBoxMatricula.Text.Trim(), patronMatricula);

            labelMatricula.ForeColor = matriculaValida ? Color.White : Color.Red;
            bool precioValido = decimal.TryParse(
                textBoxPrecio.Text.Replace(',', '.'),
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out _
            );

            bool camposCompletos =
                !string.IsNullOrWhiteSpace(dateTimePickerfecha.Text) &&
                !string.IsNullOrWhiteSpace(textBoxModeloVehiculo.Text) &&
                matriculaValida &&
                !string.IsNullOrWhiteSpace(textBoxDescripcion.Text) &&
                textBoxDescripcion.Text.Length <= 255 &&
                precioValido &&
                comboBoxDniCLiente.SelectedItem != null;

            buttonAceptar.Enabled = camposCompletos;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxPrecio.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precio))
            {
                MessageBox.Show("El precio no es válido.");
                return;
            }

            if (!Regex.IsMatch(textBoxMatricula.Text.Trim(), @"^[0-9]{4}[A-Z]{3}$"))
            {
                MessageBox.Show("La matrícula debe tener el formato correcto (Ej: 1234ABC).");
                return;
            }

            var reparacion = new Manejo.EntidadesDTO.ReparacionDTO
            {
                FechaDTO = dateTimePickerfecha.Value,
                ModeloVehiculoDTO = textBoxModeloVehiculo.Text,
                MatriculaVehiculoDTO = textBoxMatricula.Text.Trim().ToUpper(),
                DescripcionDTO = textBoxDescripcion.Text,
                PrecioDTO = precio,
                DniClienteDTO = comboBoxDniCLiente.SelectedValue.ToString()
            };

            var controladorReparaciones = new Manejo.Manejadores.ReparacionesController();
            if (controladorReparaciones.InsertarReparacion(reparacion))
            {
                MessageBox.Show("Reparación insertada correctamente.");
                VaciarCampos();
                this.Close();
            }
        }

        private void ConectarEventos()
        {
            dateTimePickerfecha.ValueChanged += (s, e) => ValidarCampos();
            textBoxModeloVehiculo.TextChanged += (s, e) => ValidarCampos();
            textBoxMatricula.TextChanged += (s, e) => ValidarCampos();
            textBoxDescripcion.TextChanged += (s, e) => ValidarCampos();
            textBoxPrecio.TextChanged += (s, e) => ValidarCampos();
            comboBoxDniCLiente.SelectedIndexChanged += (s, e) => ValidarCampos();

            textBoxPrecio.KeyPress += TextBoxPrecio_KeyPress;
        }

        private void TextBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VaciarCampos()
        {
            textBoxModeloVehiculo.Clear();
            textBoxMatricula.Clear();
            textBoxDescripcion.Clear();
            textBoxPrecio.Clear();
            comboBoxDniCLiente.SelectedIndex = -1;
            buttonAceptar.Enabled = false;
        }
    }
}
