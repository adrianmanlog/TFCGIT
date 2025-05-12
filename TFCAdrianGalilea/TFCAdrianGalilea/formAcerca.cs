using Manejo.Manejadores.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFCAdrianGalilea
{
    public partial class formAcerca : Form
    {
        private FacturaController facturaController = new FacturaController();
        public formAcerca()
        {
            InitializeComponent();
            this.Load += formAcerca_Load;
        }

        private void formAcerca_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CargarFacturas();
        }
        private void CargarFacturas()
        {
            var facturas = facturaController.ObtenerFacturas();
            flowLayoutPanel1.Controls.Clear();

            foreach (var factura in facturas)
            {
                var card = new FacturaCardControl(factura);
                card.EditarClick += Card_EditarClick;
                card.EliminarClick += Card_EliminarClick;
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void Card_EditarClick(object sender, int idFactura)
        {
            var formEditar = new ModificarFactura(idFactura);
            formEditar.FormClosed += (s, args) => CargarFacturas();
            formEditar.Show();
        }

        private void Card_EliminarClick(object sender, int idFactura)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar esta factura?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (facturaController.EliminarFactura(idFactura))
                {
                    MessageBox.Show("Factura eliminada correctamente.");
                    CargarFacturas();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la factura.");
                }
            }
        }

        private void buttonInsertarFactura_Click(object sender, EventArgs e)
        {
            var formInsertar = new InsertarFactura();
            formInsertar.FormClosed += (s, args) => CargarFacturas();
            formInsertar.Show();
        }

    }
}
