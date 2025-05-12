namespace TFCAdrianGalilea
{
    partial class formAcerca
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
            this.buttonInsertarFactura = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonInsertarFactura
            // 
            this.buttonInsertarFactura.Location = new System.Drawing.Point(3, 2);
            this.buttonInsertarFactura.Name = "buttonInsertarFactura";
            this.buttonInsertarFactura.Size = new System.Drawing.Size(111, 46);
            this.buttonInsertarFactura.TabIndex = 3;
            this.buttonInsertarFactura.Text = "Insertar factura";
            this.buttonInsertarFactura.UseVisualStyleBackColor = true;
            this.buttonInsertarFactura.Click += new System.EventHandler(this.buttonInsertarFactura_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(739, 501);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // formAcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(543, 544);
            this.Controls.Add(this.buttonInsertarFactura);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAcerca";
            this.Text = "formAcerca";
            this.Load += new System.EventHandler(this.formAcerca_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertarFactura;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}