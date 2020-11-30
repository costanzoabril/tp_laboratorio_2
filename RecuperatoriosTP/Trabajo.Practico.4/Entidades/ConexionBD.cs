using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Excepciones;

namespace Entidades
{
    public static class ConexionBD
    {
        static SqlConnection conexion;

        /// <summary>
        /// Constrcutor por defecto
        /// </summary>
        static ConexionBD()
        {
            conexion = new SqlConnection(@"Data Source=localhost\SQLEXPRESS03; Initial Catalog=AutoCine; Integrated security=true;");
        }

        #region Metodos
        /// <summary>
        /// Obtiene las peliculas de la base de datos
        /// </summary>
        public static void ObtenerPeliculas()
        {
            List<Entrada> auxPeliculas = new List<Entrada>();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM CARTELERA";

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    auxPeliculas.Add(new Entrada(
                        float.Parse(datos["Precio"].ToString()),
                        datos["Pelicula"].ToString(),
                        Entrada.MapearEnum(datos["Genero"].ToString())                                            
                        ));
                }
            }
            catch (Exception ex)
            {
                throw new ConexionException("No se pudo conectar a la base de datos" + ex.Message.ToString());
            }
            finally
            {
                conexion.Close();
            }

            AutoCine.Peliculas = auxPeliculas;
        }

        /// <summary>
        /// Obtiene de la base de datos los datos del estacionamiento
        /// </summary>
        public static void ObtenerEstacionamientos()
        {
            List<Estacionamiento> auxEstacionamiento = new List<Estacionamiento>();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM ESTACIONAMIENTO";

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader datos = comando.ExecuteReader();

                while (datos.Read())
                {
                    auxEstacionamiento.Add(new Estacionamiento(
                        float.Parse(datos["Precio"].ToString()),
                        datos["Ubicacion"].ToString()
                        ));
                }
            }
            catch (Exception ex)
            {
                throw new ConexionException("No se pudo conectar a la base de datos" + ex.Message.ToString());
            }
            finally
            {
                conexion.Close();
            }

            AutoCine.Estacionamientos = auxEstacionamiento;
        }

        /// <summary>
        /// Inserta una pelicula en la base de datos
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool InsertarPelicula(Entrada e)
        {
            SqlCommand comando = new SqlCommand();
            bool todoOk = false;

            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO CARTELERA " +
                    "(Pelicula, Genero, Precio) VALUES(@Pelicula, @Genero, @Precio)";

                comando.Parameters.Clear();
                comando.Parameters.Add(new SqlParameter("@Pelicula", e.Pelicula));
                comando.Parameters.Add(new SqlParameter("@Genero", e.Genero.ToString()));
                comando.Parameters.Add(new SqlParameter("@Precio", e.Precio));

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
                todoOk = true;

            }
            catch (Exception ex)
            {
                throw new ArchivoException("No se pudo conectar a la base de datos" + ex.Message.ToString());
            }
            finally
            {
                conexion.Close();
            }

            return todoOk;
        }

        /// <summary>
        /// Inserta un nuevo lugar del estacionamiento en la base de datos
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool InsertarEstacionamiento(Estacionamiento e)
        {
            SqlCommand comando = new SqlCommand();
            bool todoOk = false;

            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO ESTACIONAMIENTO " +
                    "(Ubicacion, Precio) VALUES(@Ubicacion, @Precio)";

                comando.Parameters.Clear();
                comando.Parameters.Add(new SqlParameter("@Ubicacion", e.Ubicacion));
                comando.Parameters.Add(new SqlParameter("@Precio", e.Precio));

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
                todoOk = true;

            }
            catch (Exception ex)
            {
                throw new ArchivoException("No se pudo conectar a la base de datos" + ex.Message.ToString());
            }
            finally
            {
                conexion.Close();
            }

            return todoOk;
        }
        #endregion
    }
}
