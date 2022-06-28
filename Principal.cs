using Prueba_Trainee_Quark.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Trainee_Quark
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private DataGridViewRow FilaSeleccionada { get; set; }
        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDesde.Value = DateTime.Now.AddDays(-7);
                CargarGrilla();
                btnRegDevolucion.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {

            }
        }
        private void Filtrar(out List<ClsPrestamo> lstPrestamos)
        {
            lstPrestamos = new List<ClsPrestamo>();
            bool ningunFiltro = chkTodos.Checked ? true : (chkDevueltos.Checked ? false : (chkPendientes.Checked ? false : true));
            if (ningunFiltro)
            {
                lstPrestamos = ClsPrestamo.HistorialTransacciones.Where(x =>
                    x.GetFecha_Prestamo().Date >= dtpDesde.Value.Date &&
                    x.GetFecha_Prestamo().Date <= dtpHasta.Value.Date).ToList();
            }
            else if (chkDevueltos.Checked)
            {
                lstPrestamos = ClsPrestamo.HistorialTransacciones.Where(x =>
                x.GetFecha_Prestamo().Date >= dtpDesde.Value.Date &&
                x.GetFecha_Prestamo().Date <= dtpHasta.Value.Date &&
                x.GetFecha_Devolucion() != null).ToList();
            }
            else if (chkPendientes.Checked)
            {
                lstPrestamos = ClsPrestamo.HistorialTransacciones.Where(x =>
                x.GetFecha_Prestamo().Date >= dtpDesde.Value.Date &&
                x.GetFecha_Prestamo().Date <= dtpHasta.Value.Date &&
                x.GetFecha_Devolucion() == null).ToList();
            }
        }
        private void CargarGrilla()
        {
            List<ClsPrestamo> prestamosFiltrados;
            dgvPrestamos.Columns.Clear();
            dgvPrestamos.Rows.Clear();
            dgvPrestamos.Refresh();
            dgvPrestamos.Columns.Add("fecha", "Fecha");
            dgvPrestamos.Columns.Add("libro", "Libro");
            dgvPrestamos.Columns.Add("ejemplar", "Ejemplar");
            dgvPrestamos.Columns.Add("socio", "Socio");
            dgvPrestamos.Columns.Add("fecha_Devolución", "Fecha de Devolución");

            if (ClsPrestamo.HistorialTransacciones != null)
            {
                dgvPrestamos.AutoGenerateColumns = true;


                Filtrar(out prestamosFiltrados);
                foreach (ClsPrestamo prestamo in prestamosFiltrados)
                {
                    DateTime? fecha_devolucion = prestamo.GetFecha_Devolucion();
                    if (fecha_devolucion.HasValue)
                        fecha_devolucion = (DateTime)prestamo.GetFecha_Devolucion();
                    dgvPrestamos.Rows.Add(
                        prestamo.GetFecha_Prestamo().Date,
                        prestamo.GetEjemplar().GetLibro().GetNombre(),
                        prestamo.GetEjemplar().GetId(),
                        prestamo.GetSocio().GetId(),
                        fecha_devolucion.HasValue ? ((DateTime)fecha_devolucion).Date : fecha_devolucion);
                }

                foreach (DataGridViewRow row in dgvPrestamos.Rows)
                {
                    var fecha_Devolucion = (DateTime?)row.Cells["fecha_Devolución"].Value;
                    var fecha_Prestamo = (DateTime?)row.Cells["fecha"].Value;
                    if (fecha_Prestamo == null)
                    {
                        CambiarColorFila(row, Color.White);
                    }
                    else if (fecha_Devolucion != null)
                    {
                        CambiarColorFila(row, Color.Green);
                    }
                    else if (DateTime.Now.AddDays(-5) >= fecha_Prestamo)
                    {
                        CambiarColorFila(row, Color.Red);
                    }
                    else if (fecha_Devolucion == null)
                    {
                        CambiarColorFila(row, Color.Yellow);
                    }  
                }
            }
        }
        private void CambiarColorFila(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell celda in row.Cells)
            {
                celda.Style.BackColor = color;
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        #region Navegar a Otro Formularios
        private void registrarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmSocios abmSocios = new AbmSocios();
            abmSocios.Show();
        }

        private void registrarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmLibros abmLibros = new AbmLibros();
            abmLibros.Show();
        }
        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            AbmPrestamos abmPrestamos = new AbmPrestamos();
            abmPrestamos.Show();
        }

        private void registrarEjemplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmEjemplares abmEjemplares = new AbmEjemplares();
            abmEjemplares.Show();
        }

        private void consultarDisponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmEjemplaresDisponibles abmEjemplaresDisponibles = new AbmEjemplaresDisponibles();
            abmEjemplaresDisponibles.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }
        private void consultarCuposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCupos ConsultCupos = new ConsultarCupos();
            ConsultCupos.Show();
        }
        #endregion
        private void btnRegDevolucion_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilaSeleccionada != null)
                {
                    ClsEjemplar ejemplar = ClsEjemplar.EjemplaresCargados.FirstOrDefault(x => x.GetId() == Convert.ToInt32(FilaSeleccionada.Cells["ejemplar"].Value));
                    ClsSocio socio = ClsSocio.Socios.FirstOrDefault(x => x.GetId() == Convert.ToInt32(FilaSeleccionada.Cells["socio"].Value));
                    ClsPrestamo prestamo = ClsPrestamo.HistorialTransacciones.FirstOrDefault(x =>
                    x.GetEjemplar().GetId() == ejemplar.GetId() &&
                    x.GetSocio().GetId() == socio.GetId() &&
                    x.GetFecha_Prestamo().Date == ((DateTime)FilaSeleccionada.Cells["fecha"].Value).Date);
                    prestamo.RegistrarDevolucion(prestamo);
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FilaSeleccionada = dgvPrestamos.SelectedRows[0];
                if (FilaSeleccionada != null)
                {
                    DateTime? fecha = (DateTime?)FilaSeleccionada.Cells["fecha"].Value;
                    DateTime? fecha_dev = (DateTime?)FilaSeleccionada.Cells["fecha_Devolución"].Value;
                    if (fecha != null && fecha_dev == null)
                    {
                        btnRegDevolucion.Enabled = true;
                        btnRegDevolucion.BackColor = Color.LightSlateGray;
                    }
                    else
                    {
                        btnRegDevolucion.Enabled = false;
                        btnRegDevolucion.BackColor = Color.WhiteSmoke;
                    }
                }
                else
                {
                    btnRegDevolucion.Enabled = false;
                    btnRegDevolucion.BackColor = Color.WhiteSmoke;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
