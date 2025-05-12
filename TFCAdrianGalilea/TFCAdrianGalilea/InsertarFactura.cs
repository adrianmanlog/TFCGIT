using Manejo.Manejadores;
using Manejo.EntidadesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Manejo.Manejadores.Controladores;

namespace TFCAdrianGalilea
{
    public partial class InsertarFactura : Form
    {
        private ClienteController clienteController = new ClienteController();
        private ReparacionesController reparacionesController = new ReparacionesController();
        private FacturaController facturaController = new FacturaController();

        public InsertarFactura()
        {
            InitializeComponent();
            this.Load += InsertarFactura_Load;
        }

        private void InsertarFactura_Load(object sender, EventArgs e)
        {
            CargarDatosComboBox();
        }

        private void CargarDatosComboBox()
        {
            // Cargar clientes
            var listaClientes = clienteController.ObtenerClientes();
            comboBoxDNICLiente.DataSource = listaClientes
                .Select(c => new { Dni = c.DniDTO })
                .ToList();
            comboBoxDNICLiente.DisplayMember = "Dni";
            comboBoxDNICLiente.ValueMember = "Dni";

            // Cargar reparaciones
            var listaReparaciones = reparacionesController.ObtenerReparaciones();

            if (listaReparaciones == null || listaReparaciones.Count == 0)
            {
                MessageBox.Show("No hay reparaciones disponibles para asociar a la factura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxIDReparacion.DataSource = null;
                return;
            }

            comboBoxIDReparacion.DataSource = listaReparaciones
                .Select(r => new { Id = r.IdReparacionDTO }) // Asegúrate de usar la propiedad correcta
                .ToList();
            comboBoxIDReparacion.DisplayMember = "Id";
            comboBoxIDReparacion.ValueMember = "Id";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDNICLiente.SelectedValue == null || comboBoxIDReparacion.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecciona un cliente y una reparación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fecha = dateTimePickerFecha.Value;
                string dniCliente = comboBoxDNICLiente.SelectedValue.ToString();
                int idReparacion = Convert.ToInt32(comboBoxIDReparacion.SelectedValue);

                var facturaDTO = new FacturaDTO
                {
                    FechaDTO = fecha,
                    DniClienteDTO = dniCliente,
                    IdReparacionDTO = idReparacion
                };

                bool exito = facturaController.InsertarFactura(facturaDTO);

                if (exito)
                {
                    MessageBox.Show("Factura insertada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
