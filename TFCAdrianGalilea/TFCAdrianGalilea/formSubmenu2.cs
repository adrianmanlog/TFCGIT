
using Manejo.Manejadores;
using Manejo.EntidadesDTO;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.Drawing;


namespace TFCAdrianGalilea
{
    public partial class formSubmenu2 : Form
    {
        public formSubmenu2()
        {
            InitializeComponent();
            this.Load += formSubmenu2_Load;
        }

        private void formSubmenu2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CargarReparaciones();
        }

        private void CargarReparaciones()
        {
            var controller = new ReparacionesController();
            var reparaciones = controller.ObtenerReparaciones();
            flowLayoutPanel1.Controls.Clear();

            if (reparaciones == null || !reparaciones.Any())
            {
                Label mensaje = new Label
                {
                    Text = "No hay reparaciones para mostrar.",
                    ForeColor = Color.White,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    Margin = new Padding(10),
                };
                flowLayoutPanel1.Controls.Add(mensaje);
                return;
            }

            foreach (var reparacion in reparaciones)
            {
                var card = new ReparacionCardControl(reparacion);
                card.EditarClick += Card_EditarClick;
                card.EliminarClick += Card_EliminarClick;
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void Card_EditarClick(object sender, int idReparacion)
        {
            var controller = new ReparacionesController();
            var reparacion = controller.ObtenerReparacionPorId(idReparacion);

            if (reparacion != null)
            {
                var formEditar = new ModificarReparaciones(reparacion);
                formEditar.FormClosed += (s, args) => CargarReparaciones();
                formEditar.Show();
            }
        }

        private void Card_EliminarClick(object sender, int idReparacion)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar esta reparación?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var controller = new ReparacionesController();
                if (controller.EliminarReparacion(idReparacion))
                {
                    MessageBox.Show("Reparación eliminada correctamente.");
                    CargarReparaciones();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la reparación.");
                }
            }
        }

        private void buttonInsertarReparacion_Click(object sender, EventArgs e)
        {
            var controladorClientes = new Manejo.Manejadores.ClienteController();
            var listaClientes = controladorClientes.ObtenerClientes();
            if (listaClientes == null || !listaClientes.Any())
            {
                MessageBox.Show("No hay clientes. No se puede registrar una reparación.");

                return;
            }
            var formInsertar = new InsertarReparaciones();
            formInsertar.FormClosed += (s, args) => CargarReparaciones();
            formInsertar.Show();
        }

    }
}
