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
    public partial class Form1 : Form
    {
        formHome formHome;
        formSubmenu1 menuSubmenu1;
        formSubmenu2 menuSubmenu2;
        formAcerca formAcerca;
        formAjustes formAjustes;

        public Form1()
        {
            InitializeComponent();
        }


        private void btMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 52)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 251)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btham_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtHome_Click(sender, e);
        }

        private void BtHome_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (formHome == null)
            {
                formHome = new formHome();
                formHome.FormClosed += forHome_FormClosed;
                formHome.MdiParent = this;
                formHome.Dock = DockStyle.Fill;
                formHome.Show();
            }
        }

        private void forHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHome = null;
        }

        private void btSubmenu1_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (menuSubmenu1 == null)
            {
                menuSubmenu1 = new formSubmenu1();
                menuSubmenu1.FormClosed += menuSubmenu1_FormClosed;
                menuSubmenu1.MdiParent = this;
                menuSubmenu1.Dock = DockStyle.Fill;
                menuSubmenu1.Show();
            }
        }

        private void menuSubmenu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuSubmenu1 = null;
        }

        private void btSubmenu2_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (menuSubmenu2 == null)
            {
                menuSubmenu2 = new formSubmenu2();
                menuSubmenu2.FormClosed += menuSubmenu2_FormClosed;
                menuSubmenu2.MdiParent = this;
                menuSubmenu2.Dock = DockStyle.Fill;
                menuSubmenu2.Show();
            }
        }

        private void menuSubmenu2_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuSubmenu2 = null;
        }

        private void btAjustes_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (formAjustes == null)
            {
                formAjustes = new formAjustes();
                formAjustes.FormClosed += formAjustes_FormClosed;
                formAjustes.MdiParent = this;
                formAjustes.Dock = DockStyle.Fill;
                formAjustes.Show();
            }
        }

        private void formAjustes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAjustes = null;
        }

        private void btAcerca_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            if (formAcerca == null)
            {
                formAcerca = new formAcerca();
                formAcerca.FormClosed += formAcerca_FormClosed;
                formAcerca.MdiParent = this;
                formAcerca.Dock = DockStyle.Fill;
                formAcerca.Show();
            }
        }

        private void formAcerca_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAcerca = null;
        }

        private void CerrarFormularios()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new Manejo.Manejadores.PruebaDeConexion().GetPruebaDeConexion())
            {
                label1.Text = "La conexión es correcta";
            }
            else
            {
                label1.Text = "Conexión con la BD no disponible";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Landing().Show();
            this.Hide();
        }
    }
}
