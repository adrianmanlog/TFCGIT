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
    public class ReparacionCardControl : UserControl
    {
        public event EventHandler<int> EliminarClick;
        public event EventHandler<int> EditarClick;

        private Label lblId;
        private Label lblFecha;
        private Label lblModelo;
        private Label lblMatricula;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblDniCliente;

        private Button btnEditar;
        private Button btnEliminar;

        private ReparacionDTO reparacion;

        public ReparacionCardControl(ReparacionDTO reparacion)
        {
            this.reparacion = reparacion;
            InitializeComponents();
            MostrarDatos();
        }

        private void InitializeComponents()
        {
            this.Size = new Size(320, 230);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(23, 24, 29);

            lblId = new Label { Location = new Point(10, 10), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblFecha = new Label { Location = new Point(10, 30), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblModelo = new Label { Location = new Point(10, 50), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblMatricula = new Label { Location = new Point(10, 70), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblDescripcion = new Label { Location = new Point(10, 90), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblPrecio = new Label { Location = new Point(10, 110), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblDniCliente = new Label { Location = new Point(10, 130), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };


            btnEditar = new Button
            {
                Text = "Editar",
                Location = new Point(10, 170),
                Size = new Size(80, 30),
                ForeColor = Color.White,
            };
            btnEditar.Click += (s, e) => EditarClick?.Invoke(this, reparacion.IdReparacionDTO);

            btnEliminar = new Button
            {
                Text = "Eliminar",
                Location = new Point(100, 170),
                Size = new Size(80, 30),
                BackColor = Color.LightCoral
            };
            btnEliminar.Click += (s, e) => EliminarClick?.Invoke(this, reparacion.IdReparacionDTO);

            this.Controls.AddRange(new Control[] {
                lblId, lblFecha, lblModelo, lblMatricula,
                lblDescripcion, lblPrecio, lblDniCliente,
                btnEditar, btnEliminar
            });
        }

        private void MostrarDatos()
        {
            lblId.Text = $"ID: {reparacion.IdReparacionDTO}";
            lblFecha.Text = $"Fecha: {reparacion.FechaDTO:dd/MM/yyyy}";
            lblModelo.Text = $"Modelo: {reparacion.ModeloVehiculoDTO}";
            lblMatricula.Text = $"Matrícula: {reparacion.MatriculaVehiculoDTO}";
            lblDescripcion.Text = $"Descripción: {reparacion.DescripcionDTO}";
            lblPrecio.Text = $"Precio: {reparacion.PrecioDTO:C}";
            lblDniCliente.Text = $"DNI Cliente: {reparacion.DniClienteDTO}";
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ReparacionCardControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Name = "ReparacionCardControl";
            this.ResumeLayout(false);

        }
    }
}
