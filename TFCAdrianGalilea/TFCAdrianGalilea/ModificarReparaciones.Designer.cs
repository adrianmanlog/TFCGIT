namespace TFCAdrianGalilea
{
    partial class ModificarReparaciones
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.comboBoxDniCLiente = new System.Windows.Forms.ComboBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxModeloVehiculo = new System.Windows.Forms.TextBox();
            this.textBoxfecha = new System.Windows.Forms.TextBox();
            this.labelDNICliente = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelModeloVehiculo = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelModificar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(219, 692);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 52;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(58, 692);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 51;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // comboBoxDniCLiente
            // 
            this.comboBoxDniCLiente.FormattingEnabled = true;
            this.comboBoxDniCLiente.Location = new System.Drawing.Point(92, 607);
            this.comboBoxDniCLiente.Name = "comboBoxDniCLiente";
            this.comboBoxDniCLiente.Size = new System.Drawing.Size(181, 21);
            this.comboBoxDniCLiente.TabIndex = 50;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(92, 526);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(181, 20);
            this.textBoxPrecio.TabIndex = 49;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(92, 351);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(181, 120);
            this.textBoxDescripcion.TabIndex = 48;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(92, 279);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(181, 20);
            this.textBoxMatricula.TabIndex = 47;
            // 
            // textBoxModeloVehiculo
            // 
            this.textBoxModeloVehiculo.Location = new System.Drawing.Point(92, 210);
            this.textBoxModeloVehiculo.Name = "textBoxModeloVehiculo";
            this.textBoxModeloVehiculo.Size = new System.Drawing.Size(181, 20);
            this.textBoxModeloVehiculo.TabIndex = 46;
            // 
            // textBoxfecha
            // 
            this.textBoxfecha.Location = new System.Drawing.Point(92, 126);
            this.textBoxfecha.Name = "textBoxfecha";
            this.textBoxfecha.Size = new System.Drawing.Size(181, 20);
            this.textBoxfecha.TabIndex = 45;
            // 
            // labelDNICliente
            // 
            this.labelDNICliente.AutoSize = true;
            this.labelDNICliente.ForeColor = System.Drawing.Color.White;
            this.labelDNICliente.Location = new System.Drawing.Point(89, 578);
            this.labelDNICliente.Name = "labelDNICliente";
            this.labelDNICliente.Size = new System.Drawing.Size(61, 13);
            this.labelDNICliente.TabIndex = 44;
            this.labelDNICliente.Text = "DNI-Cliente";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(89, 491);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 43;
            this.labelPrecio.Text = "Precio";
            // 
            // labelModeloVehiculo
            // 
            this.labelModeloVehiculo.AutoSize = true;
            this.labelModeloVehiculo.ForeColor = System.Drawing.Color.White;
            this.labelModeloVehiculo.Location = new System.Drawing.Point(89, 173);
            this.labelModeloVehiculo.Name = "labelModeloVehiculo";
            this.labelModeloVehiculo.Size = new System.Drawing.Size(87, 13);
            this.labelModeloVehiculo.TabIndex = 42;
            this.labelModeloVehiculo.Text = "Modelo vehículo";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.ForeColor = System.Drawing.Color.White;
            this.labelMatricula.Location = new System.Drawing.Point(89, 252);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(95, 13);
            this.labelMatricula.TabIndex = 41;
            this.labelMatricula.Text = "Matricula vehículo";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(89, 321);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 40;
            this.labelDescripcion.Text = "Descripción";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(89, 83);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 39;
            this.labelFecha.Text = "Fecha";
            // 
            // labelModificar
            // 
            this.labelModificar.AutoSize = true;
            this.labelModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificar.ForeColor = System.Drawing.Color.White;
            this.labelModificar.Location = new System.Drawing.Point(88, 31);
            this.labelModificar.Name = "labelModificar";
            this.labelModificar.Size = new System.Drawing.Size(188, 24);
            this.labelModificar.TabIndex = 38;
            this.labelModificar.Text = "Modificar Reparacion";
            // 
            // ModificarReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(353, 746);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboBoxDniCLiente);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.textBoxModeloVehiculo);
            this.Controls.Add(this.textBoxfecha);
            this.Controls.Add(this.labelDNICliente);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelModeloVehiculo);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelModificar);
            this.Name = "ModificarReparaciones";
            this.Text = "ModificarReparaciones";
            this.Load += new System.EventHandler(this.ModificarReparaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox comboBoxDniCLiente;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxModeloVehiculo;
        private System.Windows.Forms.TextBox textBoxfecha;
        private System.Windows.Forms.Label labelDNICliente;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelModeloVehiculo;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelModificar;
    }
}