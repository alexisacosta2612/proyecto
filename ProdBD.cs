using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using proyecto;
using Microsoft.VisualBasic.Devices;
using static proyecto.products;

namespace proyecto
{
    public class ProdBD
    {


        public MySqlConnection connection;
       public MySqlConnection connection2;


        public ProdBD()
        {
            this.Connect();
            this.Connecti2();

        }
        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
  public void Disconnect2()
        {
            if (connection2 != null && connection2.State == System.Data.ConnectionState.Open)
            {
                connection2.Close();
                MessageBox.Show("Conexion cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        public int obtenerStock(int id)
                          {
    int stock = 0;
    try
    {
        string query = "SELECT stock FROM inventario WHERE id = @id";
        using (MySqlCommand cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                stock = reader.GetInt32("stock");
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error al obtener el stock del producto: {ex.Message}");
    }
    return stock;
}
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        /// 
        public int obtenerTotalProductos()
        {
            int total = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM inventario";  // Contamos todos los productos
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    total = Convert.ToInt32(cmd.ExecuteScalar());  // Ejecutamos la consulta y obtenemos el resultado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el total de productos: {ex.Message}");
            }
            return total;
        }

        public int getstock(int id)
        {
            int stock = 0;
            try
            {
                string query = "SELECT stock FROM inventario WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        stock = reader.GetInt32("stock");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el stock del producto: {ex.Message}");
            }
            return stock;
        }/// <summary>
         /// ///////////////////////METODO CONSULTAR////////////////////////
         /// </summary>
         /// <returns></returns>
        public List<products> consult()
        {
            List<products> data = new List<products>();
            products item;
            int id;
            string namepicture;
            string productdescription;
            int price;
            int stock;
            try
            {
                string query = "SELECT * FROM inventario";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    namepicture = Convert.ToString(reader["namepicture"]) ?? "";
                    productdescription = Convert.ToString(reader["productdescription"]) ?? "";
                    price = Convert.ToInt32(reader["price"]);
                    stock = Convert.ToInt32(reader["stock"]);


                    item = new products(id, namepicture, productdescription, price, stock);
                    data.Add(item);

                }
                reader.Close();
                data.ForEach((p) =>
                {
                    //MessageBox.Show(p.Id + "," + p.Producto + "," + p.Imagen + "," + p.Precio);

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return data;
        }
        /// <summary>
        /// /////////////////////////////////////METODO ACTUALIZAR////////////////////////////////////////
        /// </summary>
      
        public void actualizar(int Id, string Namepicture, string Productdescription, int Price, int Stock)
        {
            try
            {
                string query = "UPDATE inventario SET id=" + "'" + Id + "'" + ",namepicture=" + "'" + Namepicture + "'" + ",productdescription=" + "'" + Productdescription + "'" + ",price=" + "'" + Price + "'" + ",stock=" + "'" + Stock + "'" + "where id=" + Id + ";";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualizacion: " + ex.Message);
                this.Disconnect();
            }
        }
        /// <summary>
        /// ///////
        /// </summary>
        //////////////////////////////////////////////////ACTUALIZAR STOCK/////////////////////////////////////////
        ///
        public void Actualizarstock(int idproduct,int cantidadcomprada)
        {
            try
            {
                string query = "UPDATE inventario SET stock=stock -@cantidad WHERE id =@idproducto";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cantidad", cantidadcomprada);
                    cmd.Parameters.AddWithValue("@idProducto", idproduct);

                   
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al actualizar el stock: {ex.Message}");
            }
        }
        /// <summary>
        /// //////////////////////////////ELIMINAR////////////////////////////////////////
        /// </summary>
        
        public void eliminar(int idp)
        {
            string query = "";
            try
            {
                query = "DELETE FROM inventario WHERE id=" + idp + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
                this.Disconnect();
            }
        }/// <summary>
         /// ////////////////////////////INSERTAR////////////////////////////////////////
         /// </summary>
        
        public void insertar(int Idd, string Namepicturee, string Productdescriptionn, int Pricee, int Stockk)
        {
            string query = "";
            try
            {


                query = "INSERT INTO inventario (id,namepicture,productdescription,price,stock) VALUES ("
               + "'" + Idd + "',"
               + "'" + Namepicturee + "',"
               + "'" + Productdescriptionn + "', "
               + "'" + Pricee + "',"
               + "'" + Stockk + "')";


                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nClave duplicada" + ex.Message);
                this.Disconnect();
            }

        }
        //...
        public products const_regprod(int idp)
        {
            products item = null;
            int id;
            string namepicture;
            string productdescription;
            int price;
            int stock;
            try
            {
                string query = "SELECT * FROM inventario where id=" + idp + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())  //solo encontrara un registro da una vuelta
                {
                    id = Convert.ToInt32(reader["id"]);
                    namepicture = Convert.ToString(reader["namepicture"]) ?? "";
                    productdescription = Convert.ToString(reader["productdescription"]) ?? "";
                    price = Convert.ToInt32(reader["price"]);
                    stock = Convert.ToInt32(reader["stock"]);

                    item = new products(id, namepicture, productdescription, price, stock);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de inventario: " + ex.Message);
                this.Disconnect();
            }
            return item;

        }

        //-----------------------------------------------------METODOS AGREGADOS ------------------------------------------
        public string ObtenerNombreUsuario(string numeroCuenta)
        {
            string nombreUsuario = "Desconocido"; // Valor predeterminado en caso de no encontrar el usuario
            try
            {
                // Consulta SQL ajustada para usar "nombre completo" como el nombre de la columna
                string query = "SELECT `nombre` FROM usuarios WHERE cuenta = @numeroCuenta";

                Connecti2(); // Asegúrate de conectar antes de ejecutar la consulta

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Parámetro seguro para evitar inyecciones SQL
                    command.Parameters.AddWithValue("@numeroCuenta", numeroCuenta);

                    // Ejecutar la consulta
                    object resultado = command.ExecuteScalar();
                    if (resultado != null)
                    {
                        nombreUsuario = resultado.ToString(); // Convertir el resultado al nombre del usuario
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el nombre del usuario: {ex.Message}");
            }
            finally
            {
                Disconnect2(); // Asegúrate de cerrar la conexión
            }

            return nombreUsuario;
        }
        

        public List<products> ObtenerProductos()
        {
            List<products> productos = new List<products>();
            string query = "SELECT * FROM inventario";

            Connect();
            using (MySqlCommand comando = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            productos.Add(new products
                            {
                                Id = reader.GetInt32(0),
                                Namepicture = reader.GetString(1),
                                Productdescription = reader.GetString(2),
                                Price = reader.GetInt32(3),
                                Stock = reader.GetInt32(4)
                            });
                        }
                        catch (FormatException ex)
                        {
                            // Handle the exception (e.g., log it, skip the record, etc.)
                            Console.WriteLine($"Error al leer los datos de product: {ex.Message}");
                        }
                    }
                }
            }
            Disconnect();

            return productos;
        }

        public List<(string cuenta, string contraseña)> ObtenerUsuarios()
        {
            List<(string, string)> usuarios = new List<(string, string)>();
            try
            {
                // Consulta SQL para obtener los datos de la tabla `registro`
                string query = "SELECT registros, contraseña FROM usuarios";
                Connect(); // Conecta a la base de datos

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Leer los datos de cada usuario y agregarlos a la lista
                        string cuenta = reader["cuenta"].ToString();
                        string contraseña = reader["contraseña"].ToString();

                        usuarios.Add((cuenta, contraseña));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos de usuarios: {ex.Message}");
            }
            finally
            {
                Disconnect(); // Asegurarse de cerrar la conexión
            }

            return usuarios;
        }

        public List<(string descripcion, int existencias, int precio)> ObtenerDatosGrafica()
        {
            List<(string, int, int)> datos = new List<(string, int, int)>();
            try
            {
                string query = "SELECT descripcion, existencias, precio FROM stock";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    int existencias = Convert.ToInt32(reader["existencias"]);
                    int precio = Convert.ToInt32(reader["precio"]);

                    datos.Add((descripcion, existencias, precio));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos : {ex.Message}");
            }

            return datos;
        }


        public void Connect()
            {
                string cadena = "Server=localhost; Database=products; User=root; Password=; SslMode=none;";
                try
                {
                    connection = new MySqlConnection(cadena);
                    connection.Open();
                    MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        public void Connecti2()
        {
            //Datos especiales para hacer la conexion a el servidor de datos
            string cadena2 = "Server=localhost;Database=registros; User=root; Password=; SslMode=none;";
            try
            {
                connection2 = new MySqlConnection(cadena2);
                connection2.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datosss: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public class RegistroVentas
        {
            private Venta cabeza;

            public RegistroVentas()
            {
                cabeza = null;
            }

            public void AgregarVenta(string usuario, DateTime fecha, List<products> productosVendidos, decimal total)
            {
                Venta nuevaVenta = new Venta(usuario, fecha, productosVendidos, total);

                if (cabeza == null)
                {
                    cabeza = nuevaVenta;
                }
                else
                {
                    Venta actual = cabeza;
                    while (actual.Siguiente != null)
                    {
                        actual = actual.Siguiente;
                    }
                    actual.Siguiente = nuevaVenta;
                }
            }

            public void MostrarVentas(RichTextBox richTextBox)
            {
                Venta actual = cabeza;
                richTextBox.Clear();

                while (actual != null)
                {
                    richTextBox.AppendText($"Usuario: {actual.Usuario}\n");
                    richTextBox.AppendText($"Fecha: {actual.Fecha}\n");
                    richTextBox.AppendText("Productos Vendidos:\n");
                    foreach (var producto in actual.ProductosVendidos)
                    {
                        richTextBox.AppendText($"  - ID: {producto.Id}, Descripción: {producto.Productdescription}, Cantidad: {producto.Cantidad}, Precio Unitario: {producto.Price}\n");
                    }
                    richTextBox.AppendText($"Total: {actual.Total}\n\n");

                    actual = actual.Siguiente;
                }
            }
        }




    }
}

