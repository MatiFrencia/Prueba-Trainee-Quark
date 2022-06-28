using Prueba_Trainee_Quark.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prueba_Trainee_Quark
{
    public partial class ConsultarCupos : Form
    {
        public ConsultarCupos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSocios.SelectedItem != null)
                {
                    ClsSocio socio = (ClsSocio)((dynamic)cboSocios.SelectedItem).Value;
                    if (socio.ConsultarCupos())
                        MessageBox.Show($"El socio tiene {socio.GetCant_Max() - ClsSocio.Socios.Count} cupos disponibles.", "Disponibles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"El socio no tiene cupos disponibles.", "Sin cupos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConsultarCupos_Load(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }
    }
}
