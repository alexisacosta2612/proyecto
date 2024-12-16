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

namespace proyecto
{
    public class ProdBD
    {
       

            public MySqlConnection connection;

            public ProdBD()
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
            //...
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
            }
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



        }
    }

