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
namespace proyecto__
{
    public class AdmonBD
    {

        public MySqlConnection connection;

        public AdmonBD()
        {
            this.Connect();
        }
        public int usuarioact { get; set; }
        public static int UsuarioActivoId { get; set; } = 0; // Almacena el ID del usuario activo

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
        /// ////////////////////////////////////////////////////////////
        /// </summary>
        /// 
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
        public string ObtenerNombreUsuario(string numeroCuenta)
        {
            string nombreUsuario = "Desconocido"; // Valor predeterminado en caso de no encontrar el usuario
            try
            {
                // Consulta SQL ajustada para usar "nombre completo" como el nombre de la columna
                string query = "SELECT nombre FROM usuarios WHERE cuenta = @cuenta";

                Connect(); // Asegúrate de conectar antes de ejecutar la consulta

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Parámetro seguro para evitar inyecciones SQL
                    command.Parameters.AddWithValue("@cuenta", numeroCuenta);

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
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////
    /// /// /////////////////////////////////////////////////////////////////////////////////////////////
    /// /// /////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
  
}
