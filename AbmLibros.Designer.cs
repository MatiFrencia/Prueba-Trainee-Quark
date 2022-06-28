
namespace Prueba_Trainee_Quark
{
    partial class AbmLibros
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
            this.nmrISBN = new System.Windows.Forms.NumericUpDown();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblRegLibro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlRegPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrISBN)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegPrestamo
            // 
            this.pnlRegPrestamo.Controls.Add(this.nmrISBN);
            this.pnlRegPrestamo.Controls.Add(this.lblISBN);
            this.pnlRegPrestamo.Controls.Add(this.txtAutor);
            this.pnlRegPrestamo.Controls.Add(this.txtNombre);
            this.pnlRegPrestamo.Controls.Add(this.btnCancelar);
            this.pnlRegPrestamo.Controls.Add(this.btnRegistrar);
            this.pnlRegPrestamo.Controls.Add(this.lblAutor);
            this.pnlRegPrestamo.Controls.Add(this.lblRegLibro);
            this.pnlRegPrestamo.Controls.Add(this.lblNombre);
            this.pnlRegPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegPrestamo.Location = new System.Drawing.Point(0, 0);
            this.pnlRegPrestamo.Name = "pnlRegPrestamo";
            this.pnlRegPrestamo.Size = new System.Drawing.Size(295, 341);
            this.pnlRegPrestamo.TabIndex = 4;
            // 
            // nmrISBN
            // 
            this.nmrISBN.Location = new System.Drawing.Point(29, 216);
            this.nmrISBN.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrISBN.Name = "nmrISBN";
            this.nmrISBN.Size = new System.Drawing.Size(238, 23);
            this.nmrISBN.TabIndex = 3;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblISBN.Location = new System.Drawing.Point(25, 191);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(106, 21);
            this.lblISBN.TabIndex = 11;
            this.lblISBN.Text = "Código ISBN";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(29, 156);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(238, 23);
            this.txtAutor.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(29, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(29, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 37);
            this.btnCancelar.TabIndex = 4;
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
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAutor.Location = new System.Drawing.Point(27, 128);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(53, 21);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor";
            // 
            // lblRegLibro
            // 
            this.lblRegLibro.AutoSize = true;
            this.lblRegLibro.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegLibro.Location = new System.Drawing.Point(3, 9);
            this.lblRegLibro.Name = "lblRegLibro";
            this.lblRegLibro.Size = new System.Drawing.Size(208, 37);
            this.lblRegLibro.TabIndex = 1;
            this.lblRegLibro.Text = "Registrar Libro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(27, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // AbmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 341);
            this.Controls.Add(this.pnlRegPrestamo);
            this.Name = "AbmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Libro";
            this.pnlRegPrestamo.ResumeLayout(false);
            this.pnlRegPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrISBN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegPrestamo;
        private System.Windows.Forms.NumericUpDown nmrISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblRegLibro;
        private System.Windows.Forms.Label lblNombre;
    }
}