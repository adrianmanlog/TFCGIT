using Manejo.Manejadores;
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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
            textBoxContraseña.UseSystemPasswordChar = true;
            buttonVerContraseña.Text = "👁️";
        }

        private void buttonVerContraseña_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.UseSystemPasswordChar)
            {
                textBoxContraseña.UseSystemPasswordChar = false;
                buttonVerContraseña.Text = "🚫";
            }
            else
            {
                textBoxContraseña.UseSystemPasswordChar = true;
                buttonVerContraseña.Text = "👁️";
            }
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string dni = textBoxDNI.Text.Trim();
            string contraseña = textBoxContraseña.Text;

            var usuarioController = new UsuarioController();

            var dnisExistentes = usuarioController.ObtenerDnisUsuarios();

            if (!dnisExistentes.Contains(dni))
            {
                MessageBox.Show("El usuario no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool credencialesValidas = usuarioController.ValidarCredenciales(dni, contraseña);

            if (!credencialesValidas)
            {
                MessageBox.Show("DNI o Contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            new Form1().Show();
            this.Hide();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            new Landing().Show();
            this.Hide();
        }
    }
}
