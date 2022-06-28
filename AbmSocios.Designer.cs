
namespace Prueba_Trainee_Quark
{
    partial class AbmSocios
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
            this.chkVIP = new System.Windows.Forms.CheckBox();
            this.nmrCuota = new System.Windows.Forms.NumericUpDown();
            this.lblCuota = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegPrestamo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pnlRegPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCuota)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegPrestamo
            // 
            this.pnlRegPrestamo.Controls.Add(this.chkVIP);
            this.pnlRegPrestamo.Controls.Add(this.nmrCuota);
            this.pnlRegPrestamo.Controls.Add(this.lblCuota);
            this.pnlRegPrestamo.Controls.Add(this.txtNombre);
            this.pnlRegPrestamo.Controls.Add(this.txtApellido);
            this.pnlRegPrestamo.Controls.Add(this.btnCancelar);
            this.pnlRegPrestamo.Controls.Add(this.btnRegistrar);
            this.pnlRegPrestamo.Controls.Add(this.lblNombre);
            this.pnlRegPrestamo.Controls.Add(this.lblRegPrestamo);
            this.pnlRegPrestamo.Controls.Add(this.lblApellido);
            this.pnlRegPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegPrestamo.Location = new System.Drawing.Point(0, 0);
            this.pnlRegPrestamo.Name = "pnlRegPrestamo";
            this.pnlRegPrestamo.Size = new System.Drawing.Size(299, 327);
            this.pnlRegPrestamo.TabIndex = 3;
            // 
            // chkVIP
            // 
            this.chkVIP.AutoSize = true;
            this.chkVIP.Location = new System.Drawing.Point(155, 195);
            this.chkVIP.Name = "chkVIP";
            this.chkVIP.Size = new System.Drawing.Size(43, 19);
            this.chkVIP.TabIndex = 3;
            this.chkVIP.Text = "VIP";
            this.chkVIP.UseVisualStyleBackColor = true;
            this.chkVIP.CheckedChanged += new System.EventHandler(this.chkVIP_CheckedChanged);
            // 
            // nmrCuota
            // 
            this.nmrCuota.DecimalPlaces = 2;
            this.nmrCuota.Enabled = false;
            this.nmrCuota.Location = new System.Drawing.Point(25, 215);
            this.nmrCuota.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrCuota.Name = "nmrCuota";
            this.nmrCuota.Size = new System.Drawing.Size(240, 23);
            this.nmrCuota.TabIndex = 4;
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuota.Location = new System.Drawing.Point(25, 191);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(124, 21);
            this.lblCuota.TabIndex = 11;
            this.lblCuota.Text = "Cuota Mensual";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(25, 166);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(240, 23);
            this.txtApellido.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(25, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 37);
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
            this.btnRegistrar.Location = new System.Drawing.Point(160, 278);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 37);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(23, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 21);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
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
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(25, 141);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(75, 21);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // AbmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 327);
            this.Controls.Add(this.pnlRegPrestamo);
            this.Name = "AbmSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Socio";
            this.Load += new System.EventHandler(this.AbmSocios_Load);
            this.pnlRegPrestamo.ResumeLayout(false);
            this.pnlRegPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCuota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegPrestamo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegPrestamo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nmrCuota;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.CheckBox chkVIP;
    }
}