
namespace Prueba_Trainee_Quark
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEjemplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDisponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCuposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.chkDevueltos = new System.Windows.Forms.CheckBox();
            this.chkPendientes = new System.Windows.Forms.CheckBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegDevolucion = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.sociosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(745, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menú";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarLibroToolStripMenuItem,
            this.registrarEjemplarToolStripMenuItem,
            this.consultarDisponibilidadToolStripMenuItem});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // registrarLibroToolStripMenuItem
            // 
            this.registrarLibroToolStripMenuItem.Name = "registrarLibroToolStripMenuItem";
            this.registrarLibroToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.registrarLibroToolStripMenuItem.Text = "Registrar Libro";
            this.registrarLibroToolStripMenuItem.Click += new System.EventHandler(this.registrarLibroToolStripMenuItem_Click);
            // 
            // registrarEjemplarToolStripMenuItem
            // 
            this.registrarEjemplarToolStripMenuItem.Name = "registrarEjemplarToolStripMenuItem";
            this.registrarEjemplarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.registrarEjemplarToolStripMenuItem.Text = "Registrar Ejemplar";
            this.registrarEjemplarToolStripMenuItem.Click += new System.EventHandler(this.registrarEjemplarToolStripMenuItem_Click);
            // 
            // consultarDisponibilidadToolStripMenuItem
            // 
            this.consultarDisponibilidadToolStripMenuItem.Name = "consultarDisponibilidadToolStripMenuItem";
            this.consultarDisponibilidadToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.consultarDisponibilidadToolStripMenuItem.Text = "Consultar Disponibilidad";
            this.consultarDisponibilidadToolStripMenuItem.Click += new System.EventHandler(this.consultarDisponibilidadToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarSocioToolStripMenuItem,
            this.consultarCuposToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // registrarSocioToolStripMenuItem
            // 
            this.registrarSocioToolStripMenuItem.Name = "registrarSocioToolStripMenuItem";
            this.registrarSocioToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.registrarSocioToolStripMenuItem.Text = "Registrar Socio";
            this.registrarSocioToolStripMenuItem.Click += new System.EventHandler(this.registrarSocioToolStripMenuItem_Click);
            // 
            // consultarCuposToolStripMenuItem
            // 
            this.consultarCuposToolStripMenuItem.Name = "consultarCuposToolStripMenuItem";
            this.consultarCuposToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.consultarCuposToolStripMenuItem.Text = "Consultar Cupos";
            this.consultarCuposToolStripMenuItem.Click += new System.EventHandler(this.consultarCuposToolStripMenuItem_Click);
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRegistrarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPrestamo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(514, 117);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(209, 37);
            this.btnRegistrarPrestamo.TabIndex = 2;
            this.btnRegistrarPrestamo.Text = "Registrar Préstamo";
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = false;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(15, 160);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowTemplate.Height = 25;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(708, 233);
            this.dgvPrestamos.TabIndex = 3;
            this.dgvPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(15, 117);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(105, 37);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.AutoSize = true;
            this.lblPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.lblPrestamos.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrestamos.Location = new System.Drawing.Point(3, 24);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(257, 62);
            this.lblPrestamos.TabIndex = 5;
            this.lblPrestamos.Text = "Prestamos";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(595, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 37);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(418, 81);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(57, 19);
            this.chkTodos.TabIndex = 7;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // chkDevueltos
            // 
            this.chkDevueltos.AutoSize = true;
            this.chkDevueltos.Location = new System.Drawing.Point(418, 104);
            this.chkDevueltos.Name = "chkDevueltos";
            this.chkDevueltos.Size = new System.Drawing.Size(78, 19);
            this.chkDevueltos.TabIndex = 8;
            this.chkDevueltos.Text = "Devueltos";
            this.chkDevueltos.UseVisualStyleBackColor = true;
            // 
            // chkPendientes
            // 
            this.chkPendientes.AutoSize = true;
            this.chkPendientes.Location = new System.Drawing.Point(418, 129);
            this.chkPendientes.Name = "chkPendientes";
            this.chkPendientes.Size = new System.Drawing.Size(90, 19);
            this.chkPendientes.TabIndex = 9;
            this.chkPendientes.Text = "Sin devolver";
            this.chkPendientes.UseVisualStyleBackColor = true;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(146, 122);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(103, 25);
            this.dtpDesde.TabIndex = 10;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(283, 122);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(103, 25);
            this.dtpHasta.TabIndex = 11;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDesde.Location = new System.Drawing.Point(146, 98);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(61, 21);
            this.lblDesde.TabIndex = 12;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHasta.Location = new System.Drawing.Point(283, 98);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(57, 21);
            this.lblHasta.TabIndex = 13;
            this.lblHasta.Text = "Hasta:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnRegDevolucion);
            this.panel1.Controls.Add(this.lblHasta);
            this.panel1.Controls.Add(this.lblPrestamos);
            this.panel1.Controls.Add(this.lblDesde);
            this.panel1.Controls.Add(this.btnRegistrarPrestamo);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.dgvPrestamos);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.chkPendientes);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.chkDevueltos);
            this.panel1.Controls.Add(this.chkTodos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 450);
            this.panel1.TabIndex = 14;
            // 
            // btnRegDevolucion
            // 
            this.btnRegDevolucion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegDevolucion.Enabled = false;
            this.btnRegDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegDevolucion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegDevolucion.Location = new System.Drawing.Point(514, 74);
            this.btnRegDevolucion.Name = "btnRegDevolucion";
            this.btnRegDevolucion.Size = new System.Drawing.Size(209, 37);
            this.btnRegDevolucion.TabIndex = 14;
            this.btnRegDevolucion.Text = "Registrar Devolución";
            this.btnRegDevolucion.UseVisualStyleBackColor = false;
            this.btnRegDevolucion.Click += new System.EventHandler(this.btnRegDevolucion_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menu;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BibLIOX";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEjemplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSocioToolStripMenuItem;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.CheckBox chkDevueltos;
        private System.Windows.Forms.CheckBox chkPendientes;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem consultarDisponibilidadToolStripMenuItem;
        private System.Windows.Forms.Button btnRegDevolucion;
        private System.Windows.Forms.ToolStripMenuItem consultarCuposToolStripMenuItem;
    }
}

