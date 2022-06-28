using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Prueba_Trainee_Quark.Models;

namespace Prueba_Trainee_Quark
{
    public partial class AbmPrestamos : Form
    {
        public AbmPrestamos()
        {
            InitializeComponent();
        }

        private void AbmPrestamos_Load(object sender, EventArgs e)
        {
            InicializarEntradas();
        }
        private void CargarLibros()
        {
            if (ClsLibro.LibrosCargados != null)
            {
                foreach (ClsLibro libro in ClsLibro.LibrosCargados)
                {
                    cboLibros.Items.Add(KeyValuePair.Create(libro.GetNombre(), libro));
                }
                cboLibros.DisplayMember = "Key";
                cboLibros.ValueMember = "Value";
            }
        }
        private void CargarSocios()
        {
            if (ClsSocio.Socios != null)
            {
                foreach (ClsSocio socio in ClsSocio.Socios)
                {
                    cboSocios.Items.Add(KeyValuePair.Create(socio.GetNombreCompleto(), socio));
                }
                cboSocios.DisplayMember = "Key";
                cboSocios.ValueMember = "Value";
            }
        }
        private void CargarEjemplares(ClsLibro libro)
        {
            cboEjemplares.Items.Clear();
            if (libro.GetLstEjemplares() != null)
            {
                foreach (ClsEjemplar ejemplar in libro.GetLstEjemplares())
                {
                    cboEjemplares.Items.Add(KeyValuePair.Create(ejemplar.GetUbicacion(), ejemplar));
                }
                cboEjemplares.DisplayMember = "Key";
                cboEjemplares.ValueMember = "Value";
            }
            cboEjemplares.Text = "Seleccionar...";
        }
        private void cboLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLibros.SelectedItem != null)
            {
                ClsLibro libroSeleccionado = (ClsLibro)((dynamic)cboLibros.SelectedItem).Value;
                CargarEjemplares(libroSeleccionado);
            }
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
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboEjemplares.SelectedItem != null && cboSocios.SelectedItem != null)
            {
                ClsEjemplar ejemplar = (ClsEjemplar)((dynamic)cboEjemplares.SelectedItem).Value;
                ClsSocio socio = (ClsSocio)((dynamic)cboSocios.SelectedItem).Value;
                new ClsPrestamo(ejemplar, socio);
                InicializarEntradas();
                DialogResult resultado = MessageBox.Show("Prestamo Registrado.", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void InicializarEntradas()
        {
            cboSocios.Text = "Seleccionar...";
            cboLibros.Text = "Seleccionar...";
            cboEjemplares.Items.Clear();
            cboLibros.Items.Clear();
            cboSocios.Items.Clear();
            CargarSocios();
            CargarLibros();
            cboEjemplares.Text = "Seleccionar un libro primero...";
        }
    }
}
