using Manejo.Manejadores;
using Manejo.EntidadesDTO;
using System;
using System.Linq;
using System.Windows.Forms;
using Manejo.Manejadores.Controladores;

namespace TFCAdrianGalilea
{
    public partial class ModificarFactura : Form
    {
        private ClienteController clienteController = new ClienteController();
        private ReparacionesController reparacionesController = new ReparacionesController();
        private FacturaController facturaController = new FacturaController();

        private int idFactura;

        public ModificarFactura(int idFactura)
        {
            InitializeComponent();
            this.idFactura = idFactura;

            this.Load += ModificarFactura_Load;

            buttonAceptar.Click += BtnAceptar_Click;
        }

        private void ModificarFactura_Load(object sender, EventArgs e)
        {
            CargarDatosComboBox();
            CargarDatosFactura();
        }

        private void CargarDatosComboBox()
        {
            var listaClientes = clienteController.ObtenerClientes();
            comboBoxDNICLiente.DataSource = listaClientes
                .Select(c => new { Dni = c.DniDTO })
                .ToList();
            comboBoxDNICLiente.DisplayMember = "Dni";
            comboBoxDNICLiente.ValueMember = "Dni";

            var listaReparaciones = reparacionesController.ObtenerReparaciones();
            comboBoxIDReparacion.DataSource = listaReparaciones
                .Select(r => new { Id = r.IdReparacionDTO })
                .ToList();
            comboBoxIDReparacion.DisplayMember = "Id";
            comboBoxIDReparacion.ValueMember = "Id";
        }

        private void CargarDatosFactura()
        {
            var factura = facturaController.ObtenerFacturaPorId(idFactura);
            if (factura != null)
            {
                if (factura.FechaDTO >= dateTimePickerFecha.MinDate && factura.FechaDTO <= dateTimePickerFecha.MaxDate)
                {
                    dateTimePickerFecha.Value = factura.FechaDTO;
                }
                else
                {
                    dateTimePickerFecha.Value = DateTime.Now;
                }

                if (comboBoxDNICLiente.Items.Cast<dynamic>().Any(i => i.Dni == factura.DniClienteDTO))
                {
                    comboBoxDNICLiente.SelectedValue = factura.DniClienteDTO;
                }

                if (comboBoxIDReparacion.Items.Cast<dynamic>().Any(i => i.Id == factura.IdReparacionDTO))
                {
                    comboBoxIDReparacion.SelectedValue = factura.IdReparacionDTO;
                }
            }
            else
            {
                MessageBox.Show("Factura no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dateTimePickerFecha.Value;
                string dniCliente = comboBoxDNICLiente.SelectedValue.ToString();
                int idReparacion = Convert.ToInt32(comboBoxIDReparacion.SelectedValue);

                var facturaDTO = new FacturaDTO
                {
                    IdFacturaDTO = idFactura,
                    FechaDTO = fecha,
                    DniClienteDTO = dniCliente,
                    IdReparacionDTO = idReparacion
                };

                bool exito = facturaController.ModificarFactura(facturaDTO);

                if (exito)
                {
                    MessageBox.Show("Factura modificada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al modificar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
