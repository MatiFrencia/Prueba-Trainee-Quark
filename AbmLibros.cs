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
    public partial class AbmLibros : Form
    {
        public AbmLibros()
        {
            InitializeComponent();
            InicializarEntradas();
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
                if (!string.IsNullOrEmpty(txtAutor.Text) && !string.IsNullOrEmpty(txtNombre.Text))
                {
                    new ClsLibro().RegistrarLibro(txtNombre.Text, Convert.ToInt32(nmrISBN.Value), txtAutor.Text);
                    InicializarEntradas();
                    MessageBox.Show("Libro Registrado.", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, rellene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void InicializarEntradas()
        {
            txtNombre.Text = "";
            txtAutor.Text = "";
            nmrISBN.Value= 0;
        }
    }
}
