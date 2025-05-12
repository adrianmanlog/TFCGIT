using Manejo.Manejadores;
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
    public partial class formSubmenu1 : Form
    {
        public formSubmenu1()
        {
            InitializeComponent();
            this.Load += formSubmenu1_Load;
        }

        private void formSubmenu1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CargarClientes();
        }
        private void CargarClientes()
        {
            var controller = new ClienteController();
            var clientes = controller.ObtenerClientes();
            flowLayoutPanel1.Controls.Clear();

            foreach (var cliente in clientes)
            {
                var card = new ClienteCardControl(cliente);
                card.EditarClick += Card_EditarClick;
                card.EliminarClick += Card_EliminarClick;
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void Card_EditarClick(object sender, string dni)
        {
            var controller = new ClienteController();
            var cliente = controller.ObtenerClientes().FirstOrDefault(c => c.DniDTO == dni);

            if (cliente != null)
            {
                var formEditar = new ModificarClientes(cliente);
                formEditar.FormClosed += (s, args) => CargarClientes();
                formEditar.Show();
            }
        }

        private void Card_EliminarClick(object sender, string dni)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar esta reparación?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var controller = new ClienteController();
                if (controller.EliminarCliente(dni))
                {
                    MessageBox.Show("Reparación eliminada correctamente.");
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la reparación.");
                }
            }
        }

        private void buttonInsertarCliente_Click_1(object sender, EventArgs e)
        {
            var formInsertar = new InsertarClientes();
            formInsertar.FormClosed += (s, args) => CargarClientes();
            formInsertar.Show();
        }


    }
}
