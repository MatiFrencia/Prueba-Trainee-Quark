
namespace Prueba_Trainee_Quark
{
    partial class AbmEjemplares
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
            this.nmrEdicion = new System.Windows.Forms.NumericUpDown();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblRegEjemplar = new System.Windows.Forms.Label();
            this.lblNroEdicion = new System.Windows.Forms.Label();
            this.nmrCant = new System.Windows.Forms.NumericUpDown();
            this.lblCant = new System.Windows.Forms.Label();
            this.pnlRegPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCant)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegPrestamo
            // 
            this.pnlRegPrestamo.Controls.Add(this.lblCant);
            this.pnlRegPrestamo.Controls.Add(this.nmrCant);
            this.pnlRegPrestamo.Controls.Add(this.cboLibros);
            this.pnlRegPrestamo.Controls.Add(this.nmrEdicion);
            this.pnlRegPrestamo.Controls.Add(this.lblUbicacion);
            this.pnlRegPrestamo.Controls.Add(this.txtUbicacion);
            this.pnlRegPrestamo.Controls.Add(this.btnCancelar);
            this.pnlRegPrestamo.Controls.Add(this.btnRegistrar);
            this.pnlRegPrestamo.Controls.Add(this.lblLibro);
            this.pnlRegPrestamo.Controls.Add(this.lblRegEjemplar);
            this.pnlRegPrestamo.Controls.Add(this.lblNroEdicion);
            this.pnlRegPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegPrestamo.Location = new System.Drawing.Point(0, 0);
            this.pnlRegPrestamo.Name = "pnlRegPrestamo";
            this.pnlRegPrestamo.Size = new System.Drawing.Size(285, 330);
            this.pnlRegPrestamo.TabIndex = 5;
            // 
            // cboLibros
            // 
            this.cboLibros.FormattingEnabled = true;
            this.cboLibros.Location = new System.Drawing.Point(27, 172);
            this.cboLibros.Name = "cboLibros";
            this.cboLibros.Size = new System.Drawing.Size(240, 23);
            this.cboLibros.TabIndex = 3;
            // 
            // nmrEdicion
            // 
            this.nmrEdicion.Location = new System.Drawing.Point(27, 236);
            this.nmrEdicion.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrEdicion.Name = "nmrEdicion";
            this.nmrEdicion.Size = new System.Drawing.Size(240, 23);
            this.nmrEdicion.TabIndex = 4;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUbicacion.Location = new System.Drawing.Point(27, 90);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(87, 21);
            this.lblUbicacion.TabIndex = 11;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(27, 114);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(240, 23);
            this.txtUbicacion.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(27, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(162, 278);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 37);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLibro.Location = new System.Drawing.Point(27, 148);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(49, 21);
            this.lblLibro.TabIndex = 3;
            this.lblLibro.Text = "Libro";
            // 
            // lblRegEjemplar
            // 
            this.lblRegEjemplar.AutoSize = true;
            this.lblRegEjemplar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegEjemplar.Location = new System.Drawing.Point(3, 9);
            this.lblRegEjemplar.Name = "lblRegEjemplar";
            this.lblRegEjemplar.Size = new System.Drawing.Size(254, 37);
            this.lblRegEjemplar.TabIndex = 1;
            this.lblRegEjemplar.Text = "Registrar Ejemplar";
            // 
            // lblNroEdicion
            // 
            this.lblNroEdicion.AutoSize = true;
            this.lblNroEdicion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroEdicion.Location = new System.Drawing.Point(27, 212);
            this.lblNroEdicion.Name = "lblNroEdicion";
            this.lblNroEdicion.Size = new System.Drawing.Size(80, 21);
            this.lblNroEdicion.TabIndex = 1;
            this.lblNroEdicion.Text = "# Edición";
            // 
            // nmrCant
            // 
            this.nmrCant.Location = new System.Drawing.Point(112, 56);
            this.nmrCant.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrCant.Name = "nmrCant";
            this.nmrCant.Size = new System.Drawing.Size(155, 23);
            this.nmrCant.TabIndex = 1;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCant.Location = new System.Drawing.Point(27, 58);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(79, 21);
            this.lblCant.TabIndex = 13;
            this.lblCant.Text = "Cantidad";
            // 
            // AbmEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 330);
            this.Controls.Add(this.pnlRegPrestamo);
            this.Name = "AbmEjemplares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Ejemplar";
            this.Load += new System.EventHandler(this.AbmEjemplares_Load);
            this.pnlRegPrestamo.ResumeLayout(false);
            this.pnlRegPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegPrestamo;
        private System.Windows.Forms.NumericUpDown nmrEdicion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblRegEjemplar;
        private System.Windows.Forms.Label lblNroEdicion;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox cboLibros;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.NumericUpDown nmrCant;
    }
}