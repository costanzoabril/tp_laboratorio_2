﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using Archivos;

namespace Clases_Instanciables
{
    public class Universidad
    {
        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Enumerado
        public enum EClases 
        {   
            Programacion, 
            Laboratorio, 
            Legislacion, 
            SPD 
        }
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Imprime los datos de las jornadas (private)
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>String con todos los datos</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");

            foreach (Jornada j in uni.Jornadas)
            {
                sb.AppendLine(j.ToString());
            }

            return sb.ToString();
        }
        /// <summary>
        /// Imprime los datos de las jornadas (public)
        /// </summary>
        /// <returns>String que retorna el metodo MostrarDatos</returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        /// <summary>
        /// Se encarga de guardar los datos de la universidad que recibe.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>True si se pudo serializar, false si se lanzo una excepcion.</returns>
        public static bool Guardar(Universidad uni)
        {
            bool retorno;
            Xml<Universidad> guardar = new Xml<Universidad>();

            try
            {
                retorno = guardar.Guardar("Universidad.xml", uni);
            }
            catch (Excepciones.ArchivosException)
            {
                retorno = false;
            }

            return retorno;
        }
        /// <summary>
        /// Se encarga de leer los objetos dentro del archivo Universidad.xml
        /// </summary>
        /// <returns>Objeto de tipo Universidad, que puede o no ser null, dependiendo de si pudo leer correctamente</returns>
        public static Universidad Leer()
        {
            Universidad universidad; ;
            Xml<Universidad> cargar = new Xml<Universidad>();

            try
            {
                cargar.Leer("Universidad.xml", out universidad);
            }
            catch (Excepciones.ArchivosException)
            {
                universidad = null;
            }

            return universidad;
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno alumno in g.Alumnos)
            {
                if (a == alumno)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;

            foreach (Profesor prof in g.Instructores)
            {
                if (i == prof)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        public static Profesor operator ==(Universidad u, Universidad.EClases clase)
        {
            Profesor prof = null;

            foreach (Profesor p in u.Instructores)
            {
                if (p == clase)
                {
                    prof = p;
                    break;
                }
            }

            if (prof is null)
            {
                throw new SinProfesorException();
            }

            return prof;
        }
        public static Profesor operator !=(Universidad u, Universidad.EClases clase)
        {
            Profesor prof = null;

            foreach (Profesor p in u.Instructores)
            {
                if (p != clase)
                {
                    prof = p;
                    break;
                }
            }

            return prof;
        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesor = (g == clase);
            Jornada j = new Jornada(clase, profesor);

            foreach (Alumno alumno in g.Alumnos)
            {

                j += alumno;
            }

            g.Jornadas.Add(j);

            return g;
        }
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return u;
        }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.Instructores.Add(i);
            }

            return u;
        }
        #endregion
    }
}
