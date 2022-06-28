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
    public partial class AbmSocios : Form
    {
        public AbmSocios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool vip = chkVIP.Checked;
            if (vip)
                new ClsSociosVIP().RegistrarSocio(txtNombre.Text, txtApellido.Text, nmrCuota.Value);
            else
                new ClsSocio().RegistrarSocio(txtNombre.Text, txtApellido.Text);
            InicializarEntradas();
            DialogResult resultado = MessageBox.Show("Socio Registrado.", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void chkVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (nmrCuota.Enabled)
                nmrCuota.Enabled = false;
            else
                nmrCuota.Enabled = true;
        }

        private void AbmSocios_Load(object sender, EventArgs e)
        {
            InicializarEntradas();
        }
        private void InicializarEntradas()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            nmrCuota.Value = 0;
            chkVIP.Checked = false;
        }

        private void pnlRegPrestamo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
