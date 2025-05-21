using Manejo.Manejadores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TFCAdrianGalilea
{
    public partial class Registro : Form
    {
        private HashSet<string> dnisUsuariosExistentes;
        private HashSet<string> correosUsuariosExistentes;
        private Dictionary<TextBox, (Label, string)> validacionesRegistro;

        public Registro()
        {
            InitializeComponent();

            textBoxContraseña.UseSystemPasswordChar = true;
            buttonVerContraseña.Text = "👁️";


            var usuarioController = new UsuarioController();
            dnisUsuariosExistentes = usuarioController.ObtenerDnisUsuarios().ToHashSet(StringComparer.OrdinalIgnoreCase);
            correosUsuariosExistentes = usuarioController.ObtenerCorreosUsuarios().ToHashSet(StringComparer.OrdinalIgnoreCase);


            validacionesRegistro = new Dictionary<TextBox, (Label, string)>
            {
                { textBoxDNI, (labelDNI, @"^\d{8}[A-HJ-NP-TV-Z]$") },
                { textBoxCorreo, (labelCorreo, @"^[\w\.-]+@[\w\.-]+\.\w{2,4}$") },
                { textBoxContraseña, (labelContraseña, @"^(?=.*[A-Z])(?=.*[\d\W]).{8,}$") }
            };

            foreach (var kvp in validacionesRegistro)
            {
                kvp.Key.TextChanged += ValidarCamposRegistro;
            }

            ValidarCamposRegistro(null, null);
        }

        private void ValidarCamposRegistro(object sender, EventArgs e)
        {
            bool todosValidos = true;

            foreach (var kvp in validacionesRegistro)
            {
                TextBox textBox = kvp.Key;
                Label label = kvp.Value.Item1;
                string regex = kvp.Value.Item2;

                string texto = textBox.Text.Trim();

                if (string.IsNullOrEmpty(texto))
                {
                    label.ForeColor = Color.White;
                    todosValidos = false;
                    continue;
                }

                bool valido = Regex.IsMatch(texto, regex);

                if (textBox == textBoxDNI && valido)
                {
                    bool dniDuplicado = dnisUsuariosExistentes.Contains(texto);

                    if (dniDuplicado)
                    {
                        label.ForeColor = Color.Red;
                        label.Text = "DNI (ya existe)";
                        todosValidos = false;
                        continue;
                    }
                    else
                    {
                        label.Text = "DNI";
                        label.ForeColor = Color.White;
                    }
                }
                if (textBox == textBoxCorreo && valido)
                {
                    bool correoDuplicado = correosUsuariosExistentes.Contains(texto);

                    if (correoDuplicado)
                    {
                        label.ForeColor = Color.Red;
                        label.Text = "Correo (ya existe)";
                        todosValidos = false;
                        continue;
                    }
                    else
                    {
                        label.Text = "Correo";
                        label.ForeColor = Color.White;
                    }
                }


                if (!valido)
                {
                    label.ForeColor = Color.Red;
                    todosValidos = false;
                }
                else if (textBox != textBoxDNI)
                {
                    label.ForeColor = Color.White;
                }
            }

            buttonAceptar.Enabled = todosValidos;
            if (todosValidos)
            {
                buttonAceptar.ForeColor = Color.Green;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            var usuarioController = new UsuarioController();

            var nuevoUsuario = new Manejo.EntidadesDTO.UsuarioDTO
            {
                DniDTO = textBoxDNI.Text.Trim(),
                NombreDTO = textBoxNombre.Text.Trim(),
                ApellidoDTO = textBoxApellido.Text.Trim(),
                CorreoElectronicoDTO = textBoxCorreo.Text.Trim(),
                ContraseñaDTO = textBoxContraseña.Text.Trim()
            };

            if (usuarioController.InsertarUsuario(nuevoUsuario))
            {
                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new IniciarSesion().Show();
            this.Hide();
        }
        private void LimpiarCampos()
        {
            textBoxDNI.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxCorreo.Clear();
            textBoxContraseña.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            new Landing().Show();
            this.Hide();
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

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
