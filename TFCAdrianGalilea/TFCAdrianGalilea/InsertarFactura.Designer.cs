namespace TFCAdrianGalilea
{
    partial class InsertarFactura
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
            this.comboBoxIDReparacion = new System.Windows.Forms.ComboBox();
            this.labelInsertar = new System.Windows.Forms.Label();
            this.labelIDReparacion = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.comboBoxDNICLiente = new System.Windows.Forms.ComboBox();
            this.labelDNICliente = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(216, 308);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 38;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(55, 308);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 37;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // comboBoxIDReparacion
            // 
            this.comboBoxIDReparacion.FormattingEnabled = true;
            this.comboBoxIDReparacion.Location = new System.Drawing.Point(87, 254);
            this.comboBoxIDReparacion.Name = "comboBoxIDReparacion";
            this.comboBoxIDReparacion.Size = new System.Drawing.Size(181, 21);
            this.comboBoxIDReparacion.TabIndex = 36;
            // 
            // labelInsertar
            // 
            this.labelInsertar.AutoSize = true;
            this.labelInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsertar.ForeColor = System.Drawing.Color.White;
            this.labelInsertar.Location = new System.Drawing.Point(107, 27);
            this.labelInsertar.Name = "labelInsertar";
            this.labelInsertar.Size = new System.Drawing.Size(131, 24);
            this.labelInsertar.TabIndex = 35;
            this.labelInsertar.Text = "Insertar factura";
            // 
            // labelIDReparacion
            // 
            this.labelIDReparacion.AutoSize = true;
            this.labelIDReparacion.ForeColor = System.Drawing.Color.White;
            this.labelIDReparacion.Location = new System.Drawing.Point(84, 225);
            this.labelIDReparacion.Name = "labelIDReparacion";
            this.labelIDReparacion.Size = new System.Drawing.Size(53, 9);
            this.labelIDReparacion.TabIndex = 27;
            this.labelIDReparacion.Text = "ID-Reparacion*";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(84, 74);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 20;
            this.labelFecha.Text = "Fecha";
            // 
            // comboBoxDNICLiente
            // 
            this.comboBoxDNICLiente.FormattingEnabled = true;
            this.comboBoxDNICLiente.Location = new System.Drawing.Point(87, 176);
            this.comboBoxDNICLiente.Name = "comboBoxDNICLiente";
            this.comboBoxDNICLiente.Size = new System.Drawing.Size(181, 21);
            this.comboBoxDNICLiente.TabIndex = 40;
            // 
            // labelDNICliente
            // 
            this.labelDNICliente.AutoSize = true;
            this.labelDNICliente.ForeColor = System.Drawing.Color.White;
            this.labelDNICliente.Location = new System.Drawing.Point(84, 147);
            this.labelDNICliente.Name = "labelDNICliente";
            this.labelDNICliente.Size = new System.Drawing.Size(43, 9);
            this.labelDNICliente.TabIndex = 39;
            this.labelDNICliente.Text = "DNI-Cliente*";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(87, 104);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha.TabIndex = 41;
            // 
            // InsertarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(353, 395);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.comboBoxDNICLiente);
            this.Controls.Add(this.labelDNICliente);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboBoxIDReparacion);
            this.Controls.Add(this.labelInsertar);
            this.Controls.Add(this.labelIDReparacion);
            this.Controls.Add(this.labelFecha);
            this.Name = "InsertarFactura";
            this.Text = "InsertarFactura";
            this.Load += new System.EventHandler(this.InsertarFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox comboBoxIDReparacion;
        private System.Windows.Forms.Label labelInsertar;
        private System.Windows.Forms.Label labelIDReparacion;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.ComboBox comboBoxDNICLiente;
        private System.Windows.Forms.Label labelDNICliente;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
    }
}