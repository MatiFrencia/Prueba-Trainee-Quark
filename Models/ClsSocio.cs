using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Prueba_Trainee_Quark.Models
{
    class ClsSocio
    {
        public static List<ClsSocio> Socios;
        #region Atributos
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private int Cant_Max { get; set; }
        private List<ClsEjemplar> Ejemplares_Retirados { get; set; }
        #endregion
        #region GET
        public int GetId()
        {
            return Id;
        }
        public string GetNombreCompleto()
        {
            return Apellido + " " + Nombre;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetApellido()
        {
            return Apellido;
        }
        public int GetCant_Max()
        {
            return Cant_Max;
        }
        public List<ClsEjemplar> GetEjemplares_Retirados()
        {
            return Ejemplares_Retirados;
        }
        #endregion
        #region SET
        public void SetId()
        {
            int ultimoId = 0;
            if (Socios != null && Socios.Count() != 0)
            {
                ultimoId = Socios.Max(x => x.GetId());
            }
            Id = ultimoId + 1;
        }
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void SetApellido(string apellido)
        {
            Apellido = apellido;
        }
        public void SetCant_Max(int cant_Max)
        {
            Cant_Max = cant_Max;
        }
        public void SetEjemplares_Retirados(List<ClsEjemplar> ejemplares_Retirados)
        {
            Ejemplares_Retirados = Ejemplares_Retirados;
        }
        #endregion
        public ClsSocio()
        {
            Inicializar();
            SetCant_Max(1);
        }
        public void Inicializar()
        {
            Ejemplares_Retirados = new List<ClsEjemplar>();
            if (Socios == null)
            {
                Socios = new List<ClsSocio>();
            }
        }

        public void RegistrarSocio(string nombre, string apellido)
        {
            ClsSocio nuevoSocio = new ClsSocio();
            nuevoSocio.SetId();
            nuevoSocio.SetNombre(nombre);
            nuevoSocio.SetApellido(apellido);
            Socios.Add(nuevoSocio);
        }
        public bool ConsultarCupos()
        {
            bool disponible = true;
            if (Ejemplares_Retirados.Count == Cant_Max)
                disponible = false;
            return disponible;
        }
        public void RetirarEjemplar(ClsEjemplar ejemplar)
        {
            Ejemplares_Retirados.Add(ejemplar);
        }
        public void DevolverEjemplar(ClsEjemplar ejemplar)
        {
            Ejemplares_Retirados.Remove(ejemplar);
        }
        public void AgregarEjemplar(ClsEjemplar ejemplar)
        {
            Ejemplares_Retirados.Add(ejemplar);
        }
    }
}
