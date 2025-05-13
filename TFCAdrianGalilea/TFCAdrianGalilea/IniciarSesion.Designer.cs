namespace TFCAdrianGalilea
{
    partial class IniciarSesion
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
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelInsertar = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.buttonVerContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(92, 237);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(181, 20);
            this.textBoxContraseña.TabIndex = 2;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.ForeColor = System.Drawing.Color.White;
            this.labelContraseña.Location = new System.Drawing.Point(89, 210);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 54;
            this.labelContraseña.Text = "Contraseña";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(222, 326);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 53;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(61, 326);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelInsertar
            // 
            this.labelInsertar.AutoSize = true;
            this.labelInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsertar.ForeColor = System.Drawing.Color.White;
            this.labelInsertar.Location = new System.Drawing.Point(122, 53);
            this.labelInsertar.Name = "labelInsertar";
            this.labelInsertar.Size = new System.Drawing.Size(122, 24);
            this.labelInsertar.TabIndex = 51;
            this.labelInsertar.Text = "Iniciar Sesión";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(92, 129);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(181, 20);
            this.textBoxDNI.TabIndex = 1;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.ForeColor = System.Drawing.Color.White;
            this.labelDNI.Location = new System.Drawing.Point(89, 100);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 43;
            this.labelDNI.Text = "DNI";
            // 
            // buttonVerContraseña
            // 
            this.buttonVerContraseña.Location = new System.Drawing.Point(279, 234);
            this.buttonVerContraseña.Name = "buttonVerContraseña";
            this.buttonVerContraseña.Size = new System.Drawing.Size(30, 23);
            this.buttonVerContraseña.TabIndex = 56;
            this.buttonVerContraseña.UseVisualStyleBackColor = true;
            this.buttonVerContraseña.Click += new System.EventHandler(this.buttonVerContraseña_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(353, 410);
            this.Controls.Add(this.buttonVerContraseña);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelInsertar);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.labelDNI);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelInsertar;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Button buttonVerContraseña;
    }
}