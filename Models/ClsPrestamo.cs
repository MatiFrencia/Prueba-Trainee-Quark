using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba_Trainee_Quark.Models
{
    class ClsPrestamo
    {
        public static List<ClsPrestamo> HistorialTransacciones;
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
            if (HistorialTransacciones == null)
            {
                HistorialTransacciones = new List<ClsPrestamo>();
            }
            RegistrarPrestamo(ejemplar, socio);
        }
        public void RegistrarPrestamo(ClsEjemplar ejemplar, ClsSocio socio)
        {
            SetEjemplar(ejemplar);
            SetSocio(socio);
            SetFecha_Prestamo(DateTime.Now);
            HistorialTransacciones.Add(this);
            ejemplar.GetLibro().PrestarEjemplar();
            socio.RetirarEjemplar(ejemplar);
        }
        public void RegistrarDevolucion(ClsPrestamo prestamo)
        {
            if (HistorialTransacciones == null)
            {
                HistorialTransacciones = new List<ClsPrestamo>();
            }
            ClsPrestamo prestamoEncontrado = HistorialTransacciones.Find(x => x == prestamo); //Busco el prestamo en el historial.
            
            ClsSocio socio = prestamoEncontrado.Socio;
            ClsEjemplar ejemplar = prestamoEncontrado.Ejemplar;
            ClsLibro libro = ejemplar.GetLibro();

            socio.DevolverEjemplar(prestamoEncontrado.Ejemplar);
            libro.RegistrarReingreso(prestamoEncontrado.Ejemplar);

            prestamoEncontrado.Fecha_Devolucion = DateTime.Now; //Seteo la fecha de devolución al último para que si falla el proceso no se registre devuelto.
        }
    }
}
