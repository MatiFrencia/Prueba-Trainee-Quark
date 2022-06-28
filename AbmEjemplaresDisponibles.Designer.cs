
namespace Prueba_Trainee_Quark
{
    partial class AbmEjemplaresDisponibles
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
            this.pnlRegPrestamo = new System.Windows.Forms.Panel();
            this.cboLibros = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegPrestamo = new System.Windows.Forms.Label();
            this.pnlRegPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegPrestamo
            // 
            this.pnlRegPrestamo.Controls.Add(this.cboLibros);
            this.pnlRegPrestamo.Controls.Add(this.btnCancelar);
            this.pnlRegPrestamo.Controls.Add(this.btnConsultar);
            this.pnlRegPrestamo.Controls.Add(this.lblNombre);
            this.pnlRegPrestamo.Controls.Add(this.lblRegPrestamo);
            this.pnlRegPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegPrestamo.Location = new System.Drawing.Point(0, 0);
            this.pnlRegPrestamo.Name = "pnlRegPrestamo";
            this.pnlRegPrestamo.Size = new System.Drawing.Size(285, 179);
            this.pnlRegPrestamo.TabIndex = 4;
            // 
            // cboLibros
            // 
            this.cboLibros.FormattingEnabled = true;
            this.cboLibros.Location = new System.Drawing.Point(25, 74);
            this.cboLibros.Name = "cboLibros";
            this.cboLibros.Size = new System.Drawing.Size(240, 23);
            this.cboLibros.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(25, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 37);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(160, 130);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(105, 37);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(23, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 21);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Ingrese Libro";
            // 
            // lblRegPrestamo
            // 
            this.lblRegPrestamo.AutoSize = true;
            this.lblRegPrestamo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegPrestamo.Location = new System.Drawing.Point(3, 9);
            this.lblRegPrestamo.Name = "lblRegPrestamo";
            this.lblRegPrestamo.Size = new System.Drawing.Size(211, 37);
            this.lblRegPrestamo.TabIndex = 1;
            this.lblRegPrestamo.Text = "Registrar Socio";
            // 
            // AbmEjemplaresDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 179);
            this.Controls.Add(this.pnlRegPrestamo);
            this.Name = "AbmEjemplaresDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplares Disponibles";
            this.Load += new System.EventHandler(this.AbmEjemplaresDisponibles_Load);
            this.pnlRegPrestamo.ResumeLayout(false);
            this.pnlRegPrestamo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegPrestamo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegPrestamo;
        private System.Windows.Forms.ComboBox cboLibros;
    }
}