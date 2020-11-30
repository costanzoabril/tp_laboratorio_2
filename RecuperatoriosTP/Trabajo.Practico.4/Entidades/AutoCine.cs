using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class AutoCine
    {
        #region Atributos
        static List<Entrada> peliculas;
        static List<Estacionamiento> estacionamientos;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        static AutoCine()
        {
            peliculas = new List<Entrada>();
            estacionamientos = new List<Estacionamiento>();
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Getter y setter de peliculas
        /// </summary>
        public static List<Entrada> Peliculas
        {
            get 
            { 
                return peliculas; 
            }
            set 
            { 
                peliculas = value; 
            }
        }

        /// <summary>
        /// Getter y setter de estacionamientos
        /// </summary>
        public static List<Estacionamiento> Estacionamientos
        {
            get
            {
                return estacionamientos;
            }
            set
            {
                estacionamientos = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Agrega una nueva entrada pelicula pasada por parametro a la base de datos
        /// </summary>
        /// <param name="nuevaPeli"></param>
        /// <returns></returns>
        public static bool AgregarPelicula(Entrada nuevaPeli)
        {
            bool todoOk = false;
            ConexionBD.ObtenerPeliculas();

            if (!(nuevaPeli is null))
            {
                if (Peliculas + nuevaPeli)
                {
                    if (ConexionBD.InsertarPelicula(nuevaPeli))
                    {
                        todoOk = true;
                        ConexionBD.ObtenerPeliculas();
                    }
                    else
                    {
                        throw new ProductoException();
                    }
                }
            }
            else
            {
                throw new ProductoException("El producto es nulo");
            }

            return todoOk;
        }

        /// <summary>
        /// Agrega una nueva ubicacion de estacionamiento pasada por parametro en la base de datos
        /// </summary>
        /// <param name="nuevo"></param>
        /// <returns></returns>
        public static bool AgregarEstacionamiento(Estacionamiento nuevo)
        {
            bool todoOk = false;
            ConexionBD.ObtenerPeliculas();

            if (!(nuevo is null))
            {
                if (Estacionamientos + nuevo)
                {
                    if (ConexionBD.InsertarEstacionamiento(nuevo))
                    {
                        todoOk = true;
                        ConexionBD.ObtenerPeliculas();
                    }
                    else
                    {
                        throw new ProductoException();
                    }
                }
            }
            else
            {
                throw new ProductoException("El producto es nulo");
            }

            return todoOk;
        }
        #endregion
    }
}
