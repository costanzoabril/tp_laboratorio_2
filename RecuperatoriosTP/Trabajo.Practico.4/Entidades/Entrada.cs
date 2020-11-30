using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrada : Producto
    {
        #region Enum y atributos
        public enum EGenero
        {
            CienciaFiccion,
            Infantil,
            Romance,
            Suspenso,
            Drama,
            Otro
        }

        string pelicula;
        EGenero genero;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="pelicula"></param>
        /// <param name="genero"></param>
        public Entrada(float precio, string pelicula, EGenero genero)
            : base(precio)
        {
            this.pelicula = pelicula;
            this.genero = genero;
        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="pelicula"></param>
        /// <param name="genero"></param>
        public Entrada(string precio, string pelicula, EGenero genero)
            : base(precio)
        {
            this.pelicula = pelicula;
            this.genero = genero;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Getter de peliculas
        /// </summary>
        public string Pelicula
        {
            get
            {
                return this.pelicula;
            }
        }

        /// <summary>
        /// Getter de genero
        /// </summary>
        public EGenero Genero
        {
            get
            {
                return this.genero;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Permite mapear el atributo genero
        /// </summary>
        /// <param name="genero"></param>
        /// <returns></returns>
        public static Entrada.EGenero MapearEnum(string genero)
        {
            Entrada.EGenero g;
            switch (genero)
            {
                case "Infantil":
                    g = Entrada.EGenero.Infantil;
                    break;
                case "CienciaFiccion":
                    g = Entrada.EGenero.CienciaFiccion;
                    break;
                case "Drama":
                    g = Entrada.EGenero.Drama;
                    break;            
                case "Romance":
                    g = Entrada.EGenero.Romance;
                    break;
                case "Suspenso":
                    g = Entrada.EGenero.Suspenso;
                    break;
                default:
                    g = Entrada.EGenero.Otro;
                    break;
            }
            return g;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del metodo ToString que imprime la informacion de la entrada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ENTRADA");
            sb.AppendFormat("Pelicula: {0}\n", this.pelicula);
            sb.AppendFormat(" Precio: ${0}", this.Precio);

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador ==, una entrada es igual a una lista de entradas si esta pertenece a la lista
        /// </summary>
        /// <param name="e"></param>
        /// <param name="es"></param>
        /// <returns></returns>
        public static bool operator ==(Entrada e, List<Entrada> es)
        {
            bool retorno = false;

            foreach (Entrada item in es)
            {
                if (item == e)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga de operador !=, son distintas si la entrada no pertenece a la lista de entradas
        /// </summary>
        /// <param name="unProducto"></param>
        /// <param name="misProductos"></param>
        /// <returns>True si es distinto, false si no</returns>
        public static bool operator !=(Entrada e, List<Entrada> es)
        {
            return !(e == es);
        }

        /// <summary>
        /// Sobrecarga del operador +, agrega una pelicula a la lista
        /// </summary>
        /// <param name="entradas"></param>
        /// <param name="entrada"></param>
        /// <returns></returns>
        public static bool operator +(List<Entrada> es, Entrada e)
        {
            bool retorno = false;

            if (e != es)
            {
                es.Add(e);
                retorno = true;
            }
               
            return retorno;
        }
        #endregion
    }
}
