
namespace Prueba_Trainee_Quark
{
    partial class AbmPrestamos
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
            this.cboSocios = new System.Windows.Forms.ComboBox();
            this.lblRegPrestamo = new System.Windows.Forms.Label();
            this.pnlRegPrestamo = new System.Windows.Forms.Panel();
            this.cboEjemplares = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboLibros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.pnlRegPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSocios
            // 
            this.cboSocios.FormattingEnabled = true;
            this.cboSocios.Location = new System.Drawing.Point(27, 93);
            this.cboSocios.Name = "cboSocios";
            this.cboSocios.Size = new System.Drawing.Size(240, 23);
            this.cboSocios.TabIndex = 0;
            // 
            // lblRegPrestamo
            // 
            this.lblRegPrestamo.AutoSize = true;
            this.lblRegPrestamo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegPrestamo.Location = new System.Drawing.Point(3, 9);
            this.lblRegPrestamo.Name = "lblRegPrestamo";
            this.lblRegPrestamo.Size = new System.Drawing.Size(264, 37);
            this.lblRegPrestamo.TabIndex = 1;
            this.lblRegPrestamo.Text = "Registrar Prestamo";
            // 
            // pnlRegPrestamo
            // 
            this.pnlRegPrestamo.Controls.Add(this.cboEjemplares);
            this.pnlRegPrestamo.Controls.Add(this.label2);
            this.pnlRegPrestamo.Controls.Add(this.btnCancelar);
            this.pnlRegPrestamo.Controls.Add(this.btnRegistrar);
            this.pnlRegPrestamo.Controls.Add(this.cboLibros);
            this.pnlRegPrestamo.Controls.Add(this.label1);
            this.pnlRegPrestamo.Controls.Add(this.lblRegPrestamo);
            this.pnlRegPrestamo.Controls.Add(this.cboSocios);
            this.pnlRegPrestamo.Controls.Add(this.lblSocio);
            this.pnlRegPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegPrestamo.Location = new System.Drawing.Point(0, 0);
            this.pnlRegPrestamo.Name = "pnlRegPrestamo";
            this.pnlRegPrestamo.Size = new System.Drawing.Size(296, 325);
            this.pnlRegPrestamo.TabIndex = 2;
            // 
            // cboEjemplares
            // 
            this.cboEjemplares.FormattingEnabled = true;
            this.cboEjemplares.Location = new System.Drawing.Point(27, 208);
            this.cboEjemplares.Name = "cboEjemplares";
            this.cboEjemplares.Size = new System.Drawing.Size(240, 23);
            this.cboEjemplares.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ejemplar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(27, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 37);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(162, 276);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 37);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboLibros
            // 
            this.cboLibros.FormattingEnabled = true;
            this.cboLibros.Location = new System.Drawing.Point(27, 152);
            this.cboLibros.Name = "cboLibros";
            this.cboLibros.Size = new System.Drawing.Size(240, 23);
            this.cboLibros.TabIndex = 2;
            this.cboLibros.SelectedIndexChanged += new System.EventHandler(this.cboLibros_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libro";
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSocio.Location = new System.Drawing.Point(27, 69);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(52, 21);
            this.lblSocio.TabIndex = 1;
            this.lblSocio.Text = "Socio";
            // 
            // AbmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(296, 325);
            this.Controls.Add(this.pnlRegPrestamo);
            this.Name = "AbmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Prestamo";
            this.Load += new System.EventHandler(this.AbmPrestamos_Load);
            this.pnlRegPrestamo.ResumeLayout(false);
            this.pnlRegPrestamo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSocios;
        private System.Windows.Forms.Label lblRegPrestamo;
        private System.Windows.Forms.Panel pnlRegPrestamo;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.ComboBox cboLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboEjemplares;
        private System.Windows.Forms.Label label2;
    }
}