namespace TFCAdrianGalilea
{
    partial class InsertarReparaciones
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
            this.labelInsertar = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // labelInsertar
            // 
            this.labelInsertar.AutoSize = true;
            this.labelInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsertar.ForeColor = System.Drawing.Color.White;
            this.labelInsertar.Location = new System.Drawing.Point(87, 35);
            this.labelInsertar.Name = "labelInsertar";
            this.labelInsertar.Size = new System.Drawing.Size(173, 24);
            this.labelInsertar.TabIndex = 17;
            this.labelInsertar.Text = "Insertar Reparación";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(211, 695);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 37;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(50, 695);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 36;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // comboBoxDniCLiente
            // 
            this.comboBoxDniCLiente.FormattingEnabled = true;
            this.comboBoxDniCLiente.Location = new System.Drawing.Point(84, 610);
            this.comboBoxDniCLiente.Name = "comboBoxDniCLiente";
            this.comboBoxDniCLiente.Size = new System.Drawing.Size(181, 21);
            this.comboBoxDniCLiente.TabIndex = 35;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(84, 529);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(181, 20);
            this.textBoxPrecio.TabIndex = 33;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(84, 354);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(181, 120);
            this.textBoxDescripcion.TabIndex = 32;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(84, 282);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(181, 20);
            this.textBoxMatricula.TabIndex = 31;
            // 
            // textBoxModeloVehiculo
            // 
            this.textBoxModeloVehiculo.Location = new System.Drawing.Point(84, 213);
            this.textBoxModeloVehiculo.Name = "textBoxModeloVehiculo";
            this.textBoxModeloVehiculo.Size = new System.Drawing.Size(181, 20);
            this.textBoxModeloVehiculo.TabIndex = 30;
            // 
            // textBoxfecha
            // 
            this.textBoxfecha.Location = new System.Drawing.Point(84, 129);
            this.textBoxfecha.Name = "textBoxfecha";
            this.textBoxfecha.Size = new System.Drawing.Size(181, 20);
            this.textBoxfecha.TabIndex = 29;
            // 
            // labelDNICliente
            // 
            this.labelDNICliente.AutoSize = true;
            this.labelDNICliente.ForeColor = System.Drawing.Color.White;
            this.labelDNICliente.Location = new System.Drawing.Point(81, 581);
            this.labelDNICliente.Name = "labelDNICliente";
            this.labelDNICliente.Size = new System.Drawing.Size(61, 13);
            this.labelDNICliente.TabIndex = 27;
            this.labelDNICliente.Text = "DNI-Cliente";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(81, 494);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 25;
            this.labelPrecio.Text = "Precio";
            // 
            // labelModeloVehiculo
            // 
            this.labelModeloVehiculo.AutoSize = true;
            this.labelModeloVehiculo.ForeColor = System.Drawing.Color.White;
            this.labelModeloVehiculo.Location = new System.Drawing.Point(81, 176);
            this.labelModeloVehiculo.Name = "labelModeloVehiculo";
            this.labelModeloVehiculo.Size = new System.Drawing.Size(87, 13);
            this.labelModeloVehiculo.TabIndex = 24;
            this.labelModeloVehiculo.Text = "Modelo vehículo";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.ForeColor = System.Drawing.Color.White;
            this.labelMatricula.Location = new System.Drawing.Point(81, 255);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(95, 13);
            this.labelMatricula.TabIndex = 23;
            this.labelMatricula.Text = "Matricula vehículo";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(81, 324);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 22;
            this.labelDescripcion.Text = "Descripción";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(81, 86);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 21;
            this.labelFecha.Text = "Fecha";
            // 
            // InsertarReparaciones
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
            this.Controls.Add(this.labelInsertar);
            this.Name = "InsertarReparaciones";
            this.Text = "InsertarReparaciones";
            this.Load += new System.EventHandler(this.InsertarReparaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInsertar;
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
    }
}