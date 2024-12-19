using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
using proyecto;
using System.Data;
using System.Security.Cryptography;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
namespace proyecto__
{
    public class AdmonBD
    {

       public MySqlConnection connection;
       // private MySqlConnection connection = new MySqlConnection("server=localhost;database=usuarios;uid=root;pwd=tupassword;");


        public AdmonBD()
        {
            this.Connect();
        }
      

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //...
        public virtual List<registros> consulta()
        {
            List<registros> data = new List<registros>();
            registros item;
            int id;
            string name;
            string cuenta;
            string contraseña;
            int monto;
            try
            {
                string query = "SELECT * FROM usuarios";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["name"]) ?? "";
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    contraseña = Convert.ToString(reader["contraseña"]) ?? "";
                    monto = Convert.ToInt32(reader["monto"]);


                    item = new registros(id, name, cuenta, contraseña, monto);
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
        /// ////////////////////////////////////////////////////////////***********8888/////////////////////
        /// </summary>
        /// 
        public void logear(string cuenta, string contraseña)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT tipo_usuario, nombre FROM usuarios WHERE cuenta = @cuenta AND contraseña = @contraseña", connection);
                command.Parameters.AddWithValue("@cuenta", cuenta);
                command.Parameters.AddWithValue("@contraseña", contraseña);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string nombre = reader["nombre"]?.ToString() ?? string.Empty;
                    string tipoUsuario = reader["tipo_usuario"]?.ToString() ?? string.Empty;
                    MessageBox.Show("Bienvenido");

                    if (tipoUsuario == "admin")
                    {
                        new Formadmin(nombre).Show();
                    }
                    else if (tipoUsuario == "usuario")
                    {
                        new Formventa(nombre).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message);
            }
            finally
            {
                this.Disconnect();
            }
        }





        public string ObtenerCorreoUsuario(string cuenta)
        {
            string correo = string.Empty;
            try
            {
                string query = "SELECT cuenta FROM usuarios WHERE cuenta = @cuenta";  // Aqui ajustas el query segun tu base de datos
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cuenta", cuenta);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        correo = reader.GetString("correo");  // Asegúrate de que el nombre del campo sea correcto
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener correo: {ex.Message}");
            }
            return correo;
        }
/// <summary>
/// ////////
/// </summary>
/// <param name="numeroCuenta"></param>
/// <returns></returns>
      

        public registros const_reguser(int idp)
        {
            registros item = null;
            int id;
            string name;
            string cuenta;
            string contraseña;
            int monto;
            try
            {
                string query = "SELECT * FROM usuarios where id=" + idp + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())  //solo encontrara un registro da una vuelta
                {
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["name"]) ?? "";
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    contraseña = Convert.ToString(reader["contraseña"]) ?? "";
                    monto = Convert.ToInt32(reader["monto"]);

                    item = new registros(id, name, cuenta, contraseña, monto);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de usuarios: " + ex.Message);
                this.Disconnect();
            }
            return item;


        }
        //...........................
        public string ObtenerNombreUsuario(string nombre)
        {
            string nombreUsuario = "Desconocido"; // Valor predeterminado en caso de no encontrar el usuario
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el nombre del usuario: {ex.Message}");
            }
            finally
            {
                Disconnect(); // Asegúrate de cerrar la conexión
            }

            return nombreUsuario;
        }
        /// <summary>
        /// //////////////////////////////////////
        /// </summary>
        public void Connect()
        {
            string cadena = "Server=localhost; Database=registros; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string ObtenerTipoUsuarioPorNombre(string nombre)
        {
            string tipoUsuario = string.Empty; // Valor por defecto si no se encuentra el tipo de usuario.

            try
            {
                // Consulta para obtener el tipo de usuario basado en el nombre proporcionado.
                string query = "SELECT tipo_usuario FROM usuarios WHERE nombre = @nombre";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    // Ejecutar la consulta y leer el resultado
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())  // Si encuentra el registro
                    {
                        tipoUsuario = reader["tipo_usuario"].ToString();  // Obtener el tipo de usuario.
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario no encontrado.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el tipo de usuario: {ex.Message}");
            }

            return tipoUsuario;  // Retorna el tipo de usuario.
        }
        /// <summary>
        /// //COMPRA USUARIO
        /// 
        /// </summary>
        public void ActualizarVENTAS(string nombre , int Monto)
        {
            try
            {
                Connect();
                string query = "UPDATE usuario SET monto = monto + @monto WHERE nombre = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@monto", Monto); // Agregar el monto a la base de datos
                    cmd.Parameters.AddWithValue("@nombre", nombre);       // Identificador del usuarioo


                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el monto: {ex.Message}");
            }
        }
        public void RealizarCompra(string cuenta, int montoCompra)
        {
            try
            {
                // Conectar a la base de datos
                Connect();

                
                using (var transaction = connection.BeginTransaction())
                {
                    // Obtener el monto actual del usuario
                    string querySelect = "SELECT monto FROM usuarios WHERE nombre = @nombre";
                    using (MySqlCommand commandSelect = new MySqlCommand(querySelect, connection, transaction))
                    {
                        commandSelect.Parameters.AddWithValue("@cuenta", cuenta);
                        object result = commandSelect.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Usuario no encontrado.");
                            return;
                        }

                        int montoActual = Convert.ToInt32(result);

                        // Calcular el nuevo monto
                        int nuevoMonto = montoActual - montoCompra;
                        if (nuevoMonto < 0)
                        {
                            MessageBox.Show("Fondos insuficientes.");
                            return;
                        }

                        // Actualizar el monto del usuario
                        string queryUpdate = "UPDATE usuarios SET monto = @nuevoMonto WHERE cuenta = @cuenta";
                        using (MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection, transaction))
                        {
                            commandUpdate.Parameters.AddWithValue("@nuevoMonto", nuevoMonto);
                            commandUpdate.Parameters.AddWithValue("@cuenta", cuenta);
                            commandUpdate.ExecuteNonQuery();
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                        MessageBox.Show("Compra realizada exitosamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la compra: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////
    /// /// /////////////////////////////////////////////////////////////////////////////////////////////
    /// /// /////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
  
}
