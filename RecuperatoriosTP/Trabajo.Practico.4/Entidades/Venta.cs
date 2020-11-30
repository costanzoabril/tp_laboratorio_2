using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Entidades
{
    public delegate void MiVenta();
    public class Venta<T> where T : Producto
    {
        protected List<T> productos;

        /// <summary>
        /// Constructor por defecto que inicia la lista de productos
        /// </summary>
        public Venta()
        {
            productos = new List<T>();
        }

        #region Propiedades
        /// <summary>
        /// Getter y setter de productos
        /// </summary>
        public List<T> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
            }
        }

        /// <summary>
        /// Getter del precio total de la venta
        /// </summary>
        public double PrecioTotal
        {
            get
            {
                return ObtenerPrecio(this);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Obtiene el precio total de una venta
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public static float ObtenerPrecio(Venta<T> l)
        {
            float acumulador = 0;

            foreach (T item in l.productos)
            {
                acumulador += item.Precio;
            }

            return acumulador;
        }

        /// <summary>
        /// Imprime la informacion de la compra
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public string MostrarCompra(Venta<T> l)
        {

            StringBuilder sb = new StringBuilder();

            foreach (T item in l.productos)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("------------------------------");
            sb.AppendLine("TOTAL: " + this.PrecioTotal);
            sb.AppendLine("------------------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Agrega un producto a la venta
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Venta<T> Agregar(T p)
        {
            return (this + p);
        }
        #endregion

        /// <summary>
        /// Sobrecarga del operador +, agrega un producto a la venta
        /// </summary>
        /// <param name="l"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static Venta<T> operator +(Venta<T> l, T producto)
        {

            if (l != null && producto != null)
            {
                l.productos.Add(producto);
            }

            return l;
        }

    }
}
