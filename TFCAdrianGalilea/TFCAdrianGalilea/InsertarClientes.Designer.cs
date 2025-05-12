namespace TFCAdrianGalilea
{
    partial class InsertarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.labelCodPostal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.textBoxCodPostal = new System.Windows.Forms.TextBox();
            this.labelInsertar = new System.Windows.Forms.Label();
            this.comboBoxDniUsuario = new System.Windows.Forms.ComboBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.ForeColor = System.Drawing.Color.White;
            this.labelDNI.Location = new System.Drawing.Point(81, 73);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 0;
            this.labelDNI.Text = "DNI";
            this.labelDNI.Click += new System.EventHandler(this.labelDNI_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(81, 149);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.ForeColor = System.Drawing.Color.White;
            this.labelTelefono.Location = new System.Drawing.Point(81, 387);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 2;
            this.labelTelefono.Text = "Telefono";
            this.labelTelefono.Click += new System.EventHandler(this.labelTelefono_Click);
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.ForeColor = System.Drawing.Color.White;
            this.labelCorreo.Location = new System.Drawing.Point(81, 318);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(94, 13);
            this.labelCorreo.TabIndex = 3;
            this.labelCorreo.Text = "Correo Electronico";
            this.labelCorreo.Click += new System.EventHandler(this.labelCorreo_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.ForeColor = System.Drawing.Color.White;
            this.labelApellido.Location = new System.Drawing.Point(81, 239);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 4;
            this.labelApellido.Text = "Apellido";
            this.labelApellido.Click += new System.EventHandler(this.labelApellido_Click);
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.ForeColor = System.Drawing.Color.White;
            this.labelDomicilio.Location = new System.Drawing.Point(81, 457);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(49, 13);
            this.labelDomicilio.TabIndex = 5;
            this.labelDomicilio.Text = "Domicilio";
            this.labelDomicilio.Click += new System.EventHandler(this.labelDomicilio_Click);
            // 
            // labelCodPostal
            // 
            this.labelCodPostal.AutoSize = true;
            this.labelCodPostal.ForeColor = System.Drawing.Color.White;
            this.labelCodPostal.Location = new System.Drawing.Point(81, 538);
            this.labelCodPostal.Name = "labelCodPostal";
            this.labelCodPostal.Size = new System.Drawing.Size(58, 13);
            this.labelCodPostal.TabIndex = 6;
            this.labelCodPostal.Text = "Cod Postal";
            this.labelCodPostal.Click += new System.EventHandler(this.labelCodPostal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(81, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "DNI-Usuario";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(84, 102);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(181, 20);
            this.textBoxDNI.TabIndex = 8;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(84, 192);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(181, 20);
            this.textBoxNombre.TabIndex = 9;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(84, 276);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(181, 20);
            this.textBoxApellido.TabIndex = 10;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(84, 345);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(181, 20);
            this.textBoxCorreo.TabIndex = 11;
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBoxCorreo_TextChanged);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(84, 417);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(181, 20);
            this.textBoxTelefono.TabIndex = 12;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Location = new System.Drawing.Point(84, 492);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(181, 20);
            this.textBoxDomicilio.TabIndex = 13;
            this.textBoxDomicilio.TextChanged += new System.EventHandler(this.textBoxDomicilio_TextChanged);
            // 
            // textBoxCodPostal
            // 
            this.textBoxCodPostal.Location = new System.Drawing.Point(84, 568);
            this.textBoxCodPostal.Name = "textBoxCodPostal";
            this.textBoxCodPostal.Size = new System.Drawing.Size(181, 20);
            this.textBoxCodPostal.TabIndex = 14;
            this.textBoxCodPostal.TextChanged += new System.EventHandler(this.textBoxCodPostal_TextChanged);
            // 
            // labelInsertar
            // 
            this.labelInsertar.AutoSize = true;
            this.labelInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsertar.ForeColor = System.Drawing.Color.White;
            this.labelInsertar.Location = new System.Drawing.Point(104, 26);
            this.labelInsertar.Name = "labelInsertar";
            this.labelInsertar.Size = new System.Drawing.Size(134, 24);
            this.labelInsertar.TabIndex = 16;
            this.labelInsertar.Text = "Insertar Cliente";
            this.labelInsertar.Click += new System.EventHandler(this.labelInsertar_Click);
            // 
            // comboBoxDniUsuario
            // 
            this.comboBoxDniUsuario.FormattingEnabled = true;
            this.comboBoxDniUsuario.Location = new System.Drawing.Point(84, 644);
            this.comboBoxDniUsuario.Name = "comboBoxDniUsuario";
            this.comboBoxDniUsuario.Size = new System.Drawing.Size(181, 21);
            this.comboBoxDniUsuario.TabIndex = 17;
            this.comboBoxDniUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxDniUsuario_SelectedIndexChanged);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAceptar.Location = new System.Drawing.Point(55, 696);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 18;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancelar.Location = new System.Drawing.Point(216, 696);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 19;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // InsertarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(353, 746);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboBoxDniUsuario);
            this.Controls.Add(this.labelInsertar);
            this.Controls.Add(this.textBoxCodPostal);
            this.Controls.Add(this.textBoxDomicilio);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelCodPostal);
            this.Controls.Add(this.labelDomicilio);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDNI);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "InsertarClientes";
            this.Text = "InsertarClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.Label labelCodPostal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.TextBox textBoxCodPostal;
        private System.Windows.Forms.Label labelInsertar;
        private System.Windows.Forms.ComboBox comboBoxDniUsuario;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}