using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Prueba_Trainee_Quark.Models;
using System.Linq;
using Prueba_Trainee_Quark.Reglas_De_Negocio;

namespace Prueba_Trainee_Quark
{
    public partial class AbmEjemplaresDisponibles : Form
    {
        public AbmEjemplaresDisponibles()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboLibros.SelectedItem != null)
            {
                ClsLibro libroSeleccionado = (ClsLibro)((dynamic)cboLibros.SelectedItem).Value;
                string mensaje = $"No se encontraron ejemplares disponibles del libro {libroSeleccionado.GetNombre()}";
                if (libroSeleccionado.ConsultarDisponibilidad())
                    mensaje = $"Ejemplares disponibles de '{libroSeleccionado.GetNombre()}' encontrados: {libroSeleccionado.GetLstEjemplares().Count}";
                DialogResult resultado = MessageBox.Show(mensaje, "Ejemplares Disponibles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (resultado == DialogResult.OK)
                {
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Por favor, seleccione un libro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (resultado == DialogResult.OK)
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }
        private void CargarLibros()
        {
            if (ReglasDeNegocio.LibrosCargados != null)
            {
                foreach (ClsLibro libro in ReglasDeNegocio.LibrosCargados)
                {
                    cboLibros.Items.Add(KeyValuePair.Create(libro.GetNombre(), libro));
                }
                cboLibros.ValueMember = "Value";
                cboLibros.DisplayMember = "Key";
                cboLibros.SelectedValue = "Value";
            }
        }
        private void AbmEjemplaresDisponibles_Load(object sender, EventArgs e)
        {
            InicializarEntradas();
        }
        private void InicializarEntradas()
        {
            cboLibros.Text = "Seleccionar...";
            cboLibros.Items.Clear();
            CargarLibros();
        }
    }
}
