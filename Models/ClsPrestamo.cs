using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Prueba_Trainee_Quark.Reglas_De_Negocio;

namespace Prueba_Trainee_Quark.Models
{
    class ClsPrestamo
    {
        #region Atributos
        private ClsEjemplar Ejemplar { get; set; }
        private ClsSocio Socio { get; set; }
        private DateTime Fecha_Prestamo { get; set; }
        private DateTime? Fecha_Devolucion { get; set; }
        #endregion
        #region GET
        public ClsEjemplar GetEjemplar()
        {
            return Ejemplar;
        }
        public ClsSocio GetSocio()
        {
            return Socio;
        }
        public DateTime GetFecha_Prestamo()
        {
            return Fecha_Prestamo;
        }
        public DateTime? GetFecha_Devolucion()
        {
            return Fecha_Devolucion;
        }
        #endregion
        #region SET
        public void SetEjemplar(ClsEjemplar ejemplar)
        {
            Ejemplar = ejemplar;
        }
        public void SetSocio(ClsSocio socio)
        {
            Socio = socio;
        }
        public void SetFecha_Prestamo(DateTime fecha_Prestamo)
        {
            Fecha_Prestamo = fecha_Prestamo;
        }
        public void SetFecha_Devolucion(DateTime fecha_Devolucion)
        {
            Fecha_Devolucion = fecha_Devolucion;
        }
        #endregion
        public ClsPrestamo(ClsEjemplar ejemplar, ClsSocio socio)
        {
            if (ReglasDeNegocio.HistorialTransacciones == null)
            {
                ReglasDeNegocio.HistorialTransacciones = new List<ClsPrestamo>();
            }
            RegistrarPrestamo(ejemplar, socio);
        }
        public void RegistrarPrestamo(ClsEjemplar ejemplar, ClsSocio socio)
        {
            SetEjemplar(ejemplar);
            SetSocio(socio);
            SetFecha_Prestamo(DateTime.Now);
            ReglasDeNegocio.HistorialTransacciones.Add(this);
            ejemplar.GetLibro().PrestarEjemplar();
            socio.RetirarEjemplar(ejemplar);
        }
        public void RegistrarDevolucion(ClsPrestamo prestamo)
        {
            if (ReglasDeNegocio.HistorialTransacciones == null)
            {
                ReglasDeNegocio.HistorialTransacciones = new List<ClsPrestamo>();
            }
            ClsPrestamo prestamoEncontrado = ReglasDeNegocio.HistorialTransacciones.FirstOrDefault(x => 
            x.GetSocio().GetId() == prestamo.GetSocio().GetId() &&
            x.GetEjemplar().GetId() == prestamo.GetEjemplar().GetId() &&
            x.GetFecha_Prestamo() == prestamo.GetFecha_Prestamo()); //Busco el prestamo en el historial.

            if (prestamoEncontrado.GetFecha_Devolucion() == null)
            {
                ClsSocio socio = prestamoEncontrado.Socio;
                ClsEjemplar ejemplar = prestamoEncontrado.Ejemplar;
                ClsLibro libro = ejemplar.GetLibro();

                socio.DevolverEjemplar(prestamoEncontrado.Ejemplar);
                libro.RegistrarReingreso(prestamoEncontrado.Ejemplar);

                prestamoEncontrado.Fecha_Devolucion = DateTime.Now; //Seteo la fecha de devolución al último para que si falla el proceso no se registre devuelto.
            }
        }
    }
}
