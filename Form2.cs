using MySql.Data.MySqlClient;
using proyecto__;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            AdmonBD obj = new AdmonBD();

            string cuenta = textBoxcuenta.Text; // Campo de cuenta
            string contraseña = textBoxcontraseña.Text; // Campo de contraseña
           

            try
            {
                string query = $"SELECT * FROM usuarios WHERE cuenta = '{cuenta}' AND contraseña = '{contraseña}'";
                MySqlCommand command = new MySqlCommand(query, obj.connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // Si se encuentra al menos un registro
                {
                    reader.Read(); // Lee la primera fila (ya que debería ser única)

                    string dbCuenta = reader.GetString("cuenta"); // Obtén la cuenta desde la base de datos

                    reader.Read(); // Lee la primera fila (ya que debería ser única)
                    int usuarioId = reader.GetInt32("id"); // Obtén el ID del usuario desde la base de datos

                    AdmonBD.UsuarioActivoId = usuarioId;
                    MessageBox.Show($"Usuario activo ID: {AdmonBD.UsuarioActivoId}");

                    // Mensaje de depuración para ver los valores
                  //  MessageBox.Show("Cuenta desde la base de datos: " + dbCuenta);
                    MessageBox.Show("Cuenta ingresada: " + cuenta);

                    reader.Close(); // Cierra el reader después de leer los datos

                    if (dbCuenta.Equals("goku@gmail.com", StringComparison.OrdinalIgnoreCase)) // Compara insensiblemente a mayúsculas
                    {
                        MessageBox.Show("Abriendo Formadmin...");
                        Formadmin formadmin = new Formadmin();
                        formadmin.Show(); // Mostrar Formadmin
                        
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Abriendo Formventa...");
                        Formventa form3 = new Formventa(); // Formulario para otros usuarios
                        form3.Show();
                       // this.Hide(); // Ocultar este formulario
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Cuenta o contraseña incorrecta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message);
            }
            finally
            {
                obj.Disconnect();
            }


        }

        private void buttonloggout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
