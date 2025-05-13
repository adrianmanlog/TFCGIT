
using Manejo.EntidadesDTO;
using Manejo.Manejadores;
using System;
using System.Linq;
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
        }

        private void ValidarCampos()
        {
            bool camposCompletos =
                !string.IsNullOrWhiteSpace(textBoxfecha.Text) &&
                !string.IsNullOrWhiteSpace(textBoxModeloVehiculo.Text) &&
                !string.IsNullOrWhiteSpace(textBoxMatricula.Text) &&
                !string.IsNullOrWhiteSpace(textBoxDescripcion.Text) &&
                textBoxDescripcion.Text.Length <= 255 &&
                !string.IsNullOrWhiteSpace(textBoxPrecio.Text) &&
                comboBoxDniCLiente.SelectedItem != null;

            buttonAceptar.Enabled = camposCompletos;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            var reparacion = new ReparacionDTO
            {
                IdReparacionDTO = idReparacion,
                FechaDTO = DateTime.Parse(textBoxfecha.Text),
                ModeloVehiculoDTO = textBoxModeloVehiculo.Text,
                MatriculaVehiculoDTO = textBoxMatricula.Text,
                DescripcionDTO = textBoxDescripcion.Text,
                PrecioDTO = decimal.Parse(textBoxPrecio.Text),
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
            textBoxfecha.TextChanged += (s, e) => ValidarCampos();
            textBoxModeloVehiculo.TextChanged += (s, e) => ValidarCampos();
            textBoxMatricula.TextChanged += (s, e) => ValidarCampos();
            textBoxDescripcion.TextChanged += (s, e) => ValidarCampos();
            textBoxPrecio.TextChanged += (s, e) => ValidarCampos();
            comboBoxDniCLiente.SelectedIndexChanged += (s, e) => ValidarCampos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosReparacion(ReparacionDTO reparacion)
        {
            textBoxfecha.Text = reparacion.FechaDTO.ToString("dd-MM-yyyy");
            textBoxModeloVehiculo.Text = reparacion.ModeloVehiculoDTO;
            textBoxMatricula.Text = reparacion.MatriculaVehiculoDTO;
            textBoxDescripcion.Text = reparacion.DescripcionDTO;
            textBoxPrecio.Text = reparacion.PrecioDTO.ToString("F2");
            comboBoxDniCLiente.SelectedValue = reparacion.DniClienteDTO;

            ValidarCampos();
        }
    }
}
