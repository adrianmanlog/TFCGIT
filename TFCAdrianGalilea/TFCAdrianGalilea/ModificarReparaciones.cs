using Manejo.EntidadesDTO;
using Manejo.Manejadores;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TFCAdrianGalilea
{
    public partial class ModificarReparaciones : Form
    {
        private readonly int idReparacion;

        public ModificarReparaciones(ReparacionDTO reparacion)
        {
            InitializeComponent();
            idReparacion = reparacion.IdReparacionDTO;
            this.Load += ModificarReparaciones_Load;
            CargarDatosReparacion(reparacion);
        }

        private void ModificarReparaciones_Load(object sender, EventArgs e)
        {
            var controladorClientes = new ClienteController();
            var listaClientes = controladorClientes.ObtenerClientes();

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

            var reparacion = new ReparacionDTO
            {
                IdReparacionDTO = idReparacion,
                FechaDTO = dateTimePickerfecha.Value,
                ModeloVehiculoDTO = textBoxModeloVehiculo.Text,
                MatriculaVehiculoDTO = textBoxMatricula.Text.Trim().ToUpper(),
                DescripcionDTO = textBoxDescripcion.Text,
                PrecioDTO = precio,
                DniClienteDTO = comboBoxDniCLiente.SelectedValue.ToString()
            };

            var controlador = new ReparacionesController();
            if (controlador.ModificarReparacion(reparacion))
            {
                MessageBox.Show("Reparación modificada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al modificar la reparación.");
            }
        }

        private void ConectarEventos()
        {
            dateTimePickerfecha.TextChanged += (s, e) => ValidarCampos();
            textBoxModeloVehiculo.TextChanged += (s, e) => ValidarCampos();
            textBoxMatricula.TextChanged += (s, e) => ValidarCampos();
            textBoxDescripcion.TextChanged += (s, e) => ValidarCampos();
            textBoxPrecio.TextChanged += (s, e) => ValidarCampos();
            textBoxPrecio.KeyPress += TextBoxPrecio_KeyPress;
            comboBoxDniCLiente.SelectedIndexChanged += (s, e) => ValidarCampos();
        }

        private void TextBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char separadorDecimal = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];

            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if ((e.KeyChar == '.' || e.KeyChar == ',') && !textBoxPrecio.Text.Contains('.') && !textBoxPrecio.Text.Contains(','))
                return;

            e.Handled = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosReparacion(ReparacionDTO reparacion)
        {
            dateTimePickerfecha.Text = reparacion.FechaDTO.ToString("dd-MM-yyyy");
            textBoxModeloVehiculo.Text = reparacion.ModeloVehiculoDTO;
            textBoxMatricula.Text = reparacion.MatriculaVehiculoDTO;
            textBoxDescripcion.Text = reparacion.DescripcionDTO;
            textBoxPrecio.Text = reparacion.PrecioDTO.ToString("F2");
            comboBoxDniCLiente.SelectedValue = reparacion.DniClienteDTO;

            ValidarCampos();
        }
    }
}
