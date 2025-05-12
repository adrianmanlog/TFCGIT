using Manejo.EntidadesDTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFCAdrianGalilea
{
    public class ClienteCardControl : UserControl
    {
        public event EventHandler<string> EliminarClick;
        public event EventHandler<string> EditarClick;

        private Label lblNombre;
        private Label lblDni;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblDomicilio;
        private Label lblCodigoPostal;

        private Button btnEditar;
        private Button btnEliminar;

        private ClienteDTO cliente;

        public ClienteCardControl(ClienteDTO cliente)
        {
            this.cliente = cliente;
            InitializeComponents();
            MostrarDatos();
        }

        private void InitializeComponents()
        {
            this.Size = new Size(300, 200);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(23, 24, 29);
            
            lblDni = new Label { Location = new Point(10, 10), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblNombre = new Label { Location = new Point(10, 30), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblCorreo = new Label { Location = new Point(10, 50), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblTelefono = new Label { Location = new Point(10, 70), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblDomicilio = new Label { Location = new Point(10, 90), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblCodigoPostal = new Label { Location = new Point(10, 110), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };

            btnEditar = new Button
            {
                Text = "Editar",
                Location = new Point(10, 140),
                Size = new Size(80, 30),
                ForeColor = Color.White,
            };
            btnEditar.Click += (s, e) => EditarClick?.Invoke(this, cliente.DniDTO);

            btnEliminar = new Button
            {
                Text = "Eliminar",
                Location = new Point(100, 140),
                Size = new Size(80, 30),
                BackColor = Color.LightCoral
            };
            btnEliminar.Click += (s, e) => EliminarClick?.Invoke(this, cliente.DniDTO);

            this.Controls.AddRange(new Control[] {
                lblDni, lblNombre, lblCorreo, lblTelefono,
                lblDomicilio, lblCodigoPostal, btnEditar, btnEliminar
            });
        }

        private void MostrarDatos()
        {
            lblDni.Text = $"DNI: {cliente.DniDTO}";
            lblNombre.Text = $"Nombre: {cliente.NombreDTO} {cliente.ApellidoDTO}";
            lblCorreo.Text = $"Correo: {cliente.CorreoElectronicoDTO}";
            lblTelefono.Text = $"Teléfono: {cliente.TelefonoDTO}";
            lblDomicilio.Text = $"Domicilio: {cliente.DomicilioDTO}";
            lblCodigoPostal.Text = $"CP: {cliente.CodigoPostalDTO}";
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ClienteCardControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Name = "ClienteCardControl";
            this.ResumeLayout(false);

        }
    }
}
