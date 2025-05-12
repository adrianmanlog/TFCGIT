namespace TFCAdrianGalilea
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btham = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHome = new System.Windows.Forms.Panel();
            this.BtHome = new System.Windows.Forms.Button();
            this.btSubmenu1 = new System.Windows.Forms.Button();
            this.btSubmenu2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btAcerca = new System.Windows.Forms.Button();
            this.btAjustes = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btham)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(661, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reparaciones Gorostiaga";
            // 
            // btham
            // 
            this.btham.Image = ((System.Drawing.Image)(resources.GetObject("btham.Image")));
            this.btham.Location = new System.Drawing.Point(12, 3);
            this.btham.Name = "btham";
            this.btham.Size = new System.Drawing.Size(34, 31);
            this.btham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btham.TabIndex = 1;
            this.btham.TabStop = false;
            this.btham.Click += new System.EventHandler(this.btham_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.pnHome);
            this.sidebar.Controls.Add(this.btSubmenu1);
            this.sidebar.Controls.Add(this.btSubmenu2);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Controls.Add(this.btAcerca);
            this.sidebar.Controls.Add(this.btAjustes);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 34);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(251, 544);
            this.sidebar.TabIndex = 1;
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.BtHome);
            this.pnHome.Location = new System.Drawing.Point(3, 3);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(248, 43);
            this.pnHome.TabIndex = 3;
            // 
            // BtHome
            // 
            this.BtHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.BtHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHome.ForeColor = System.Drawing.Color.White;
            this.BtHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtHome.Location = new System.Drawing.Point(-31, -6);
            this.BtHome.Name = "BtHome";
            this.BtHome.Size = new System.Drawing.Size(311, 64);
            this.BtHome.TabIndex = 2;
            this.BtHome.Text = "Home";
            this.BtHome.UseVisualStyleBackColor = false;
            this.BtHome.Click += new System.EventHandler(this.BtHome_Click);
            // 
            // btSubmenu1
            // 
            this.btSubmenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btSubmenu1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmenu1.ForeColor = System.Drawing.Color.White;
            this.btSubmenu1.Location = new System.Drawing.Point(3, 52);
            this.btSubmenu1.Name = "btSubmenu1";
            this.btSubmenu1.Size = new System.Drawing.Size(248, 70);
            this.btSubmenu1.TabIndex = 2;
            this.btSubmenu1.Text = "Clientes";
            this.btSubmenu1.UseVisualStyleBackColor = false;
            this.btSubmenu1.Click += new System.EventHandler(this.btSubmenu1_Click);
            // 
            // btSubmenu2
            // 
            this.btSubmenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btSubmenu2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmenu2.ForeColor = System.Drawing.Color.White;
            this.btSubmenu2.Location = new System.Drawing.Point(3, 128);
            this.btSubmenu2.Name = "btSubmenu2";
            this.btSubmenu2.Size = new System.Drawing.Size(248, 75);
            this.btSubmenu2.TabIndex = 2;
            this.btSubmenu2.Text = "Reparaciones";
            this.btSubmenu2.UseVisualStyleBackColor = false;
            this.btSubmenu2.Click += new System.EventHandler(this.btSubmenu2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btAcerca
            // 
            this.btAcerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btAcerca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcerca.ForeColor = System.Drawing.Color.White;
            this.btAcerca.Location = new System.Drawing.Point(3, 291);
            this.btAcerca.Name = "btAcerca";
            this.btAcerca.Size = new System.Drawing.Size(248, 78);
            this.btAcerca.TabIndex = 3;
            this.btAcerca.Text = "Acerca";
            this.btAcerca.UseVisualStyleBackColor = false;
            this.btAcerca.Click += new System.EventHandler(this.btAcerca_Click);
            // 
            // btAjustes
            // 
            this.btAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btAjustes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjustes.ForeColor = System.Drawing.Color.White;
            this.btAjustes.Location = new System.Drawing.Point(3, 375);
            this.btAjustes.Name = "btAjustes";
            this.btAjustes.Size = new System.Drawing.Size(248, 76);
            this.btAjustes.TabIndex = 3;
            this.btAjustes.Text = "Ajustes";
            this.btAjustes.UseVisualStyleBackColor = false;
            this.btAjustes.Click += new System.EventHandler(this.btAjustes_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btham)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btham;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button BtHome;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Button btAcerca;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btSubmenu1;
        private System.Windows.Forms.Button btSubmenu2;
        private System.Windows.Forms.Button btAjustes;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}

