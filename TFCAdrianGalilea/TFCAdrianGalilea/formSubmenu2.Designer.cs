namespace TFCAdrianGalilea
{
    partial class formSubmenu2
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonInsertarReparacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-3, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(739, 501);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonInsertarReparacion
            // 
            this.buttonInsertarReparacion.Location = new System.Drawing.Point(0, 4);
            this.buttonInsertarReparacion.Name = "buttonInsertarReparacion";
            this.buttonInsertarReparacion.Size = new System.Drawing.Size(111, 46);
            this.buttonInsertarReparacion.TabIndex = 2;
            this.buttonInsertarReparacion.Text = "Insertar reparación";
            this.buttonInsertarReparacion.UseVisualStyleBackColor = true;
            this.buttonInsertarReparacion.Click += new System.EventHandler(this.buttonInsertarReparacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "No se puede eliminar una reparación si tiene una factura asociada";
            // 
            // formSubmenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(543, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsertarReparacion);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSubmenu2";
            this.Text = "formSubmenu2";
            this.Load += new System.EventHandler(this.formSubmenu2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonInsertarReparacion;
        private System.Windows.Forms.Label label1;
    }
}