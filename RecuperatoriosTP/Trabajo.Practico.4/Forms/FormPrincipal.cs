using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;
using Excepciones;
using Archivos;

namespace Forms
{
    public partial class FormPrincipal : Form
    {
        #region Atributos
        string pathConexion = "Data Source=localhost\\SQLEXPRESS03; Initial Catalog=AutoCine; Integrated security=true;";

        public SqlDataAdapter daPeliculas;
        public SqlDataAdapter daEstacionamiento;
        public DataTable dtPeliculas;
        public DataTable dtEstacionamiento;
        Venta<Producto> compra;

        public event MiVenta RealizarVenta;

        Thread thVentasVigentes;
        #endregion

        #region Constructor
        public FormPrincipal()
        {
            InitializeComponent();
            RealizarVenta += GenerarAvisoTicketDescuento;
            RealizarVenta += GenerarTicketVenta;
            RealizarVenta += IniciarThread;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Instancia e inicia el thread
        /// </summary>
        private void IniciarThread()
        {
            thVentasVigentes = new Thread(this.MostrarVentasVigentes);
            thVentasVigentes.Start();
        }

        /// <summary>
        /// Genera un aviso si el precio total supera los 2500
        /// </summary>
        public void GenerarAvisoTicketDescuento()
        {
            if (compra.PrecioTotal > 2500)
            {
                MessageBox.Show("Compra mayor a 2500, dar ticket de descuento para proxima compra");
            }
        }

        /// <summary>
        /// Guarda el ticket en un archivo de texto
        /// </summary>
        public void GenerarTicketVenta()
        {
            Texto txt = new Texto();

            try
            {
                txt.Guardar("ventas.txt", this.textBoxTicket.Text);

            }
            catch (ArchivoException)
            {
                MessageBox.Show("Error al guardar ticket en archivo de texto.");
            }

        }

        /// <summary>
        /// Lleva a cabo el thread que borra las ventas no vigentes
        /// </summary>
        private void MostrarVentasVigentes()
        {
            while (true)
            {
                Thread.Sleep(6000);

                if (this.textBoxVentas.InvokeRequired)
                {
                    this.textBoxVentas.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.textBoxVentas.Text = string.Empty;
                    });

                    Thread.Sleep(3000);
                }
            }

        }
        #endregion

        #region Configuracion de DataTables y DataAdapters
        private void configurarDataTables()
        {
            CrearDataTablePeliculas();
            CrearDataTableEstacionamiento();
            ConfigurarGrillaPeliculas();
            ConfigurarGrillaEstacionamiento();
            ConfigurarDataAdapterPeliculas();
            ConfigurarDataAdapterEstacionamiento();
            CargarGrillaPeliculas();
            CargarGrillaEstacionamiento();
        }
        private bool CrearDataTablePeliculas()
        {
            bool res = true;

            try
            {
                this.dtPeliculas = new DataTable("Pelicula");

                this.dtPeliculas.Columns.Add("Pelicula", typeof(string));
                this.dtPeliculas.Columns.Add("Genero", typeof(string));
                this.dtPeliculas.Columns.Add("Precio", typeof(float));

            }
            catch
            {
                res = false;
            }

            return res;
        }
        private bool CrearDataTableEstacionamiento()
        {
            bool res = true;

            try
            {
                this.dtEstacionamiento = new DataTable("Estacionamiento");

                this.dtEstacionamiento.Columns.Add("Ubicacion", typeof(string));
                this.dtEstacionamiento.Columns.Add("Precio", typeof(float));

            }
            catch
            {
                res = false;
            }

            return res;
        }
        private bool ConfigurarGrillaPeliculas()
        {
            bool res = true;

            try
            {
                //Color de fondo para las filas
                this.dgvEntradas.RowsDefaultCellStyle.BackColor = Color.Lavender;

                //Color de las lineas de separacion
                this.dgvEntradas.GridColor = Color.Black;

                //Evito la multiseleccion
                this.dgvEntradas.MultiSelect = false;

                //Genero que solo se pueda editar a traves de codigo (no graficamente)
                this.dgvEntradas.EditMode = DataGridViewEditMode.EditProgrammatically;

                //Selecciono toda la grilla a la vez
                this.dgvEntradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //Saco los encabezados de las filas
                this.dgvEntradas.RowHeadersVisible = false;

                //Hago que se ajusten automaticamente en tamaño
                this.dgvEntradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.dgvEntradas.DataSource = this.dtPeliculas;
            }
            catch
            {
                res = false;
            }

            return res;
        }
        private bool ConfigurarGrillaEstacionamiento()
        {
            bool res = true;

            try
            {
                //Color de fondo para las filas
                this.dgvEstacionamiento.RowsDefaultCellStyle.BackColor = Color.Lavender;

                //Color de las lineas de separacion
                this.dgvEstacionamiento.GridColor = Color.Black;

                //Evito la multiseleccion
                this.dgvEstacionamiento.MultiSelect = false;

                //Genero que solo se pueda editar a traves de codigo (no graficamente)
                this.dgvEstacionamiento.EditMode = DataGridViewEditMode.EditProgrammatically;

                //Selecciono toda la grilla a la vez
                this.dgvEstacionamiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //Saco los encabezados de las filas
                this.dgvEstacionamiento.RowHeadersVisible = false;

                //Hago que se ajusten automaticamente en tamaño
                this.dgvEstacionamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.dgvEstacionamiento.DataSource = this.dtEstacionamiento;
            }
            catch
            {
                res = false;
            }

            return res;
        }
        private bool ConfigurarDataAdapterPeliculas()
        {
            bool rta = true;

            try
            {
                SqlConnection conexion = new SqlConnection(pathConexion);

                this.daPeliculas = new SqlDataAdapter();

                this.daPeliculas.SelectCommand = new SqlCommand("SELECT * FROM CARTELERA", conexion);
                this.daPeliculas.InsertCommand = new SqlCommand("INSERT INTO ENTRADAS (Pelicula, Genero, Precio)" +
                                                       "VALUES (@Pelicula, @Genero, @Precio)", conexion);
                this.daPeliculas.UpdateCommand = new SqlCommand("UPDATE ENTRADAS SET Pelicula=@Pelicula, Genero=@Genero, " +
                                                       "Precio=@Precio WHERE Pelicula=@Pelicula", conexion);
                this.daPeliculas.DeleteCommand = new SqlCommand("DELETE FROM ENTRADAS WHERE Pelicula=@Pelicula", conexion);

                this.daPeliculas.InsertCommand.Parameters.Add("@Pelicula", SqlDbType.VarChar, 50, "Pelicula");
                this.daPeliculas.InsertCommand.Parameters.Add("@Genero", SqlDbType.VarChar, 50, "Genero");
                this.daPeliculas.InsertCommand.Parameters.Add("@Precio", SqlDbType.Float, 10, "Precio");

                this.daPeliculas.UpdateCommand.Parameters.Add("@Pelicula", SqlDbType.VarChar, 50, "Pelicula");
                this.daPeliculas.UpdateCommand.Parameters.Add("@Genero", SqlDbType.VarChar, 50, "Genero");
                this.daPeliculas.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Float, 10, "Precio");

                this.daPeliculas.DeleteCommand.Parameters.Add("@Pelicula", SqlDbType.VarChar, 50, "Pelicula");
            }
            catch (Exception e)
            {
                rta = false;
                MessageBox.Show(e.Message);
            }

            return rta;

        }
        private bool ConfigurarDataAdapterEstacionamiento()
        {
            bool rta = true;

            try
            {
                SqlConnection conexion = new SqlConnection(pathConexion);

                this.daEstacionamiento = new SqlDataAdapter();

                this.daEstacionamiento.SelectCommand = new SqlCommand("SELECT * FROM ESTACIONAMIENTO", conexion);
                this.daEstacionamiento.InsertCommand = new SqlCommand("INSERT INTO ESTACIONAMIENTO (Ubicacion, Precio)" +
                                                       "VALUES (@Ubicacion, @Precio)", conexion);
                this.daEstacionamiento.UpdateCommand = new SqlCommand("UPDATE ESTACIONAMIENTO SET Ubicacion=@Ubicacion, " +
                                                       "Precio=@Precio WHERE Ubicacion=@Ubicacion", conexion);
                this.daEstacionamiento.DeleteCommand = new SqlCommand("DELETE FROM ESTACIONAMIENTO WHERE Ubicacion=@Ubicacion", conexion);

                this.daEstacionamiento.InsertCommand.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50, "Ubicacion");
                this.daEstacionamiento.InsertCommand.Parameters.Add("@Precio", SqlDbType.Float, 10, "Precio");

                this.daEstacionamiento.UpdateCommand.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50, "Ubicacion");
                this.daEstacionamiento.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Float, 10, "Precio");

                this.daEstacionamiento.DeleteCommand.Parameters.Add("@Ubicacion", SqlDbType.Int, 10, "Ubicacio");
            }
            catch (Exception e)
            {
                rta = false;
                MessageBox.Show(e.Message);
            }

            return rta;

        }
        private bool CargarGrillaPeliculas()
        {
            bool res = true;

            try
            {
                this.daPeliculas.Fill(this.dtPeliculas);
            }
            catch (Exception e)
            {
                res = false;
                MessageBox.Show(e.Message);
            }

            return res;
        }
        private bool CargarGrillaEstacionamiento()
        {
            bool res = true;

            try
            {
                this.daEstacionamiento.Fill(this.dtEstacionamiento);
            }
            catch (Exception e)
            {
                res = false;
                MessageBox.Show(e.Message);
            }

            return res;
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Configura las DataTables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {          
            try
            {
                configurarDataTables();
                compra = new Venta<Producto>();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  
        /// <summary>
        /// Agrega una pelicula a la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarP_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = this.dgvEntradas.SelectedRows[0].Index;

                DataRow fila = this.dtPeliculas.Rows[indice];

                string pelicula = fila["Pelicula"].ToString();
                Entrada.EGenero genero = Entrada.MapearEnum(fila["Genero"].ToString());
                float precio = float.Parse(fila["Precio"].ToString());

                Entrada entrada = new Entrada(precio, pelicula, genero);
                compra.Agregar(entrada);
                       
                textBoxTicket.Text = "";
                textBoxTicket.Text += compra.MostrarCompra(compra);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Agrega un estacionamiento a la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarE_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = this.dgvEstacionamiento.SelectedRows[0].Index;

                DataRow fila = this.dtEstacionamiento.Rows[indice];

                float precio = float.Parse(fila["Precio"].ToString());
                string ubicacion = fila["Ubicacion"].ToString();              

                Estacionamiento estacionamiento = new Estacionamiento(precio, ubicacion);
                compra.Agregar(estacionamiento);

                textBoxTicket.Text = "";
                textBoxTicket.Text += compra.MostrarCompra(compra);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /// <summary>
       /// Agrega una pelicula a la base de datos
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void botonAgregarPBD_Click(object sender, EventArgs e)
        {
            FormAgregarPelicula nuevoForm = new FormAgregarPelicula();

            if (nuevoForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AutoCine.AgregarPelicula(nuevoForm.nuevaEntrada);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                DataRow fila = this.dtPeliculas.NewRow();

                fila["Pelicula"] = nuevoForm.nuevaEntrada.Pelicula;
                fila["Genero"] = nuevoForm.nuevaEntrada.Genero;
                fila["Precio"] = nuevoForm.nuevaEntrada.Precio;

                 this.dtPeliculas.Rows.Add(fila);
                this.dtPeliculas.AcceptChanges();
            }
            else
            {
                MessageBox.Show("Usted ha cancelado la adicion");
            }         
        }

        /// <summary>
        /// Cuando el form se cierra, aborta el thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(thVentasVigentes != null)
                thVentasVigentes.Abort();
            }         
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Dispose();
        }

        /// <summary>
        /// Agrega un estacionamiento a la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarEDB_Click(object sender, EventArgs e)
        {
            FormAgregarEstacionamiento nuevoForm = new FormAgregarEstacionamiento();

            if (nuevoForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AutoCine.AgregarEstacionamiento(nuevoForm.nuevo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                DataRow fila = this.dtEstacionamiento.NewRow();

                fila["Ubicacion"] = nuevoForm.nuevo.Ubicacion;
                fila["Precio"] = nuevoForm.nuevo.Precio;

                this.dtEstacionamiento.Rows.Add(fila);
                this.dtEstacionamiento.AcceptChanges();
            }
            else
            {
                MessageBox.Show("Usted ha cancelado la adicion");
            }          
        }

        /// <summary>
        /// Genera una venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonVender_Click(object sender, EventArgs e)
        {
            if(textBoxTicket.Text != "")
            {
                RealizarVenta.Invoke();
                compra.Productos.Clear();
                textBoxVentas.Text += textBoxTicket.Text;
                textBoxTicket.Text = "";
            }
            else
            {
                MessageBox.Show("No hay nada para vender");
            }
            
        }
        #endregion
    }
}
