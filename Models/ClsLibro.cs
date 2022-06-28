using System;
using System.Collections.Generic;
using System.Text;
using Prueba_Trainee_Quark.Reglas_De_Negocio;


namespace Prueba_Trainee_Quark.Models
{
    class ClsLibro
    {
        #region Atributos
        private string Nombre { get; set; }
        private int Cod_ISBN { get; set; }
        private string Autor { get; set; }
        private List<ClsEjemplar> LstEjemplares { get; set; }
        #endregion
        #region GET
        public string GetNombre()
        {
            return Nombre;
        }
        public int GetCod_ISBN()
        {
            return Cod_ISBN;
        }
        public string GetAutor()
        {
            return Autor;
        }
        public List<ClsEjemplar> GetLstEjemplares()
        {
            return LstEjemplares;
        }
        #endregion
        #region SET
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void SetCod_ISBN(int cod_ISBN)
        {
            Cod_ISBN = cod_ISBN;
        }
        public void SetAutor(string autor)
        {
            Autor = autor;
        }
        public void SetLstEjemplares(List<ClsEjemplar> lstEjemplares)
        {
            LstEjemplares = lstEjemplares;
        }
        #endregion
        public ClsLibro()
        {
            if (ReglasDeNegocio.LibrosCargados == null)
            {
                ReglasDeNegocio.LibrosCargados = new List<ClsLibro>();
            }
            LstEjemplares = new List<ClsEjemplar>();
        }
        public void RegistrarLibro(string nombre, int cod_ISBN, string autor)
        {
            ClsLibro nuevoLibro = new ClsLibro();
            nuevoLibro.SetNombre(nombre);
            nuevoLibro.SetCod_ISBN(cod_ISBN);
            nuevoLibro.SetAutor(autor);
            ReglasDeNegocio.LibrosCargados.Add(nuevoLibro);
        }
        public void RegistrarEjemplar(int nroEdicion, string ubicacion)
        {
            ClsEjemplar ejemplar = new ClsEjemplar();
            ejemplar.SetNroEdicion(nroEdicion);
            ejemplar.SetUbicacion(ubicacion);
            ejemplar.SetLibro(this);
            LstEjemplares.Add(ejemplar);
        }
        public bool ConsultarDisponibilidad()
        {
            bool disponible = false;
            if (LstEjemplares.Count != 0)
                disponible = true;
            return disponible;
        }
        public ClsEjemplar PrestarEjemplar()
        {
            ClsEjemplar ejemplar = LstEjemplares[0];
            LstEjemplares.Remove(LstEjemplares[0]);
            return ejemplar;
        }
        public void RegistrarReingreso(ClsEjemplar ejemplar)
        {
            LstEjemplares.Add(ejemplar);
        }
        public void AgregarEjemplar(ClsEjemplar ejemplar)
        {
            LstEjemplares.Add(ejemplar);
        }
    }
}
