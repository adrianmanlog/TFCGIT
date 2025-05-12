using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var reparacion = new Manejo.EntidadesDTO.ReparacionDTO
            {
                FechaDTO = DateTime.Parse(textBoxfecha.Text),
                ModeloVehiculoDTO = textBoxModeloVehiculo.Text,
                MatriculaVehiculoDTO = textBoxMatricula.Text,
                DescripcionDTO = textBoxDescripcion.Text,
                PrecioDTO = decimal.Parse(textBoxPrecio.Text),
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
        private void VaciarCampos()
        {
            textBoxfecha.Clear();
            textBoxModeloVehiculo.Clear();
            textBoxMatricula.Clear();
            textBoxDescripcion.Clear();
            textBoxPrecio.Clear();

            comboBoxDniCLiente.SelectedIndex = -1;

            buttonAceptar.Enabled = false;
        }
    }
}
