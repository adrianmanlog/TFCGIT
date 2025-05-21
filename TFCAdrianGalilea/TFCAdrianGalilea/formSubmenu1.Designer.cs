namespace TFCAdrianGalilea
{
    partial class formSubmenu1
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
            this.buttonInsertarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(739, 501);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonInsertarCliente
            // 
            this.buttonInsertarCliente.Location = new System.Drawing.Point(4, 2);
            this.buttonInsertarCliente.Name = "buttonInsertarCliente";
            this.buttonInsertarCliente.Size = new System.Drawing.Size(111, 46);
            this.buttonInsertarCliente.TabIndex = 1;
            this.buttonInsertarCliente.Text = "Insertar cliente";
            this.buttonInsertarCliente.UseVisualStyleBackColor = true;
            this.buttonInsertarCliente.Click += new System.EventHandler(this.buttonInsertarCliente_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No se puede eliminar un cliente si tiene una reparación o factura asociados";
            // 
            // formSubmenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(543, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsertarCliente);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "formSubmenu1";
            this.Text = "formSubmenu1";
            this.Load += new System.EventHandler(this.formSubmenu1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonInsertarCliente;
        private System.Windows.Forms.Label label1;
    }
}