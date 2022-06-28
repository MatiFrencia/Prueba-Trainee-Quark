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
    public partial class AbmEjemplares : Form
    {
        public AbmEjemplares()
        {
            InitializeComponent();
        }
        private void AbmEjemplares_Load(object sender, EventArgs e)
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
                cboLibros.ValueMember = "Value";
                cboLibros.DisplayMember = "Key";
                cboLibros.SelectedValue = "Value";
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
            try
            {
                if (nmrCant.Value == 0)
                    MessageBox.Show("Ingrese una cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (cboLibros.SelectedItem != null)
                    {
                        if (!string.IsNullOrEmpty(txtUbicacion.Text))
                        {
                            ClsLibro libro = (ClsLibro)((dynamic)cboLibros.SelectedItem).Value;
                            new ClsEjemplar().RegistrarEjemplar(txtUbicacion.Text, Convert.ToInt32(nmrEdicion.Value), libro, Convert.ToInt32(nmrCant.Value));
                            InicializarEntradas();
                            MessageBox.Show("Ejemplar Registrado.", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Por favor, rellene todos los campos.", "Advertencias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void InicializarEntradas()
        {
            txtUbicacion.Text = "";
            cboLibros.Text = "Seleccionar...";
            nmrEdicion.Value = 0;
            nmrCant.Value = 0;
            cboLibros.Items.Clear();
            CargarLibros();
        }
    }
}
