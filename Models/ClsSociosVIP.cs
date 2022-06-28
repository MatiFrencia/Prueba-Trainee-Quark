using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba_Trainee_Quark.Models
{
    class ClsSociosVIP: ClsSocio
    {
        #region Atributos
        private decimal CuotaMensual { get; set; }
        #endregion
        #region GET
        public decimal GetCuotaMensual()
        {
            return CuotaMensual;
        }
        #endregion
        #region SET
        public void SetCuotaMensual(decimal cuotaMensual)
        {
            CuotaMensual = cuotaMensual;
        }
        #endregion
        public ClsSociosVIP()
        {
            Inicializar();
            SetCant_Max(3);
        }
        new public void Inicializar()
        {
            SetEjemplares_Retirados(new List<ClsEjemplar>());
        }
        public void RegistrarSocio(string nombre, string apellido, decimal cuotaMensual)
        {
            ClsSociosVIP nuevoSocioVIP = new ClsSociosVIP();
            nuevoSocioVIP.SetId();
            nuevoSocioVIP.SetNombre(nombre);
            nuevoSocioVIP.SetApellido(apellido);
            nuevoSocioVIP.SetCuotaMensual(cuotaMensual);
            Socios.Add(nuevoSocioVIP);
        }
    }
}
