﻿using Manejo.Manejadores;
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
            flowLayoutPanel1.Controls.Clear();
            var listaClientes = controller.ObtenerClientes();

            if (listaClientes == null || !listaClientes.Any())
            {
                Label mensaje = new Label
                {
                    Text = "No hay clientes para mostrar.",
                    ForeColor = Color.White,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    Margin = new Padding(10),
                };
                flowLayoutPanel1.Controls.Add(mensaje);
                return;
            }

            foreach (var cliente in listaClientes)
            {
                ClienteCardControl card = new ClienteCardControl(cliente);
                card.EliminarClick += Card_EliminarClick;
                card.EditarClick += Card_EditarClick;

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
            if (MessageBox.Show("¿Seguro que deseas eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var controller = new ClienteController();
                if (controller.EliminarCliente(dni))
                {
                    MessageBox.Show("Cliente eliminado correctamente.");
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente.");
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
