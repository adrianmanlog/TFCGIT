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
            // formSubmenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(543, 544);
            this.Controls.Add(this.buttonInsertarCliente);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "formSubmenu1";
            this.Text = "formSubmenu1";
            this.Load += new System.EventHandler(this.formSubmenu1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonInsertarCliente;
    }
}