using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Prueba_Trainee_Quark.Models
{
    class ClsEjemplar
    {

        public static List<ClsEjemplar> EjemplaresCargados;
        #region Atributos
        private int Id { get; set; }
        private int NroEdicion { get; set; }
        private string Ubicacion { get; set; }
        private ClsLibro Libro { get; set; }
        #endregion
        #region GET
        public int GetId()
        {
            return Id;
        }
        public int GetNroEdicion()
        {
            return NroEdicion;
        }
        public string GetUbicacion()
        {
            return Ubicacion;
        }
        public ClsLibro GetLibro()
        {
            return Libro;
        }
        #endregion
        #region SET
        public void SetId()
        {
            int ultimoId = 0;
            if (EjemplaresCargados != null && EjemplaresCargados.Count() != 0)
            {
                ultimoId = EjemplaresCargados.Max(x => x.GetId());
            }
            Id = ultimoId + 1;
        }
        public void SetNroEdicion(int nroEdicion)
        {
            NroEdicion = nroEdicion;
        }
        public void SetUbicacion(string ubicacion)
        {
            Ubicacion = ubicacion;
        }
        public void SetLibro(ClsLibro libro)
        {
            Libro = libro;
        }
        #endregion
        public ClsEjemplar()
        {
            if (EjemplaresCargados == null)
            {
                EjemplaresCargados = new List<ClsEjemplar>();
            }
        }
        public void RegistrarEjemplar(string ubicacion, int nroEdicion, ClsLibro libro, int cant)
        {
            for (int i = 1; i <= cant; i++)
            {
                ClsEjemplar nuevoEjemplar = new ClsEjemplar();
                nuevoEjemplar.SetUbicacion(ubicacion);
                nuevoEjemplar.SetLibro(libro);
                nuevoEjemplar.SetNroEdicion(nroEdicion);
                nuevoEjemplar.SetId();
                libro.AgregarEjemplar(nuevoEjemplar);
                EjemplaresCargados.Add(nuevoEjemplar);
            }
        }
    }
}
