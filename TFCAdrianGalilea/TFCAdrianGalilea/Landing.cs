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
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            new Registro().Show();
            this.Hide();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            new IniciarSesion().Show();
            this.Hide();
        }

        internal class Show
        {
            public Show()
            {
            }
        }
    }
}
