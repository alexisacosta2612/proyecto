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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cuentaIngresada = txtCuenta.Text;
            string contraseñaIngresada = txtContrasena.Text;

            // Crear instancia de la base de datos y obtener los usuarios
            ProdBD obj = new ProdBD();
            var usuarios = obj.ObtenerUsuarios();

            // Validar credenciales
            bool credencialesValidas = usuarios.Any(u => u.cuenta == cuentaIngresada && u.contraseña == contraseñaIngresada);

            if (credencialesValidas)
            {
                // Si las credenciales son válidas, pasar al siguiente formulario
                MessageBox.Show("Inicio de sesión exitoso");
                FormGrafica formCompra = new FormGrafica(cuentaIngresada);
                formCompra.StartPosition = FormStartPosition.CenterScreen;
                formCompra.Show();
                this.Hide(); // Ocultar el formulario de inicio de sesión
            }
            else
            {
                // Si las credenciales no son válidas, mostrar mensaje de error
                MessageBox.Show("Credenciales incorrectas. Por favor, intente nuevamente.");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ProdBD bd = new ProdBD(); // Crear instancia de conexión a la base de datos
            var usuarios = bd.ObtenerUsuarios();

            // Configurar la gráfica o cualquier acción adicional con los datos
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Usuario: {usuario.cuenta}, Contraseña: {usuario.contraseña}");
            }

            bd.Disconnect2();
        }
    }
}
