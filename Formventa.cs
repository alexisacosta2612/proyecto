
using iText.IO.Image;
using iText.IO.Font;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout; // Para la clase Document

using iText.Layout.Element;
using System.IO;
using MySql.Data.MySqlClient;
using proyecto__;

namespace proyecto
{
    public partial class Formventa : Form
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\main-proyect";
        private string cuenta;
        List<products> datos;
        List<products> productosSeleccionados = new List<products>();

        private ArbolProductos arbolPorPrecio = new ArbolProductos(); // Árbol para orden por precio
        private ArbolProductos arbolPorId = new ArbolProductos();    // Árbol para búsqueda por ID
        public string cuentarec { get; set; }

        public Formventa()
        {
            InitializeComponent();
        }

        public Formventa(string cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;

        }
        public void MostrarCuenta()
        {
            MessageBox.Show("Cuenta recibida en Formventa: " + cuentarec);
        }

        private void Formventa_Load(object sender, EventArgs e)
        {

            // Mostrar el nombre del usuario al cargar el formulario
            Console.WriteLine($"Usuario autenticado: {cuenta}");
            ProdBD bd = new ProdBD(); // Crear instancia de conexión a la base de datos
                                      // _ = bd.ObtenerDatosGrafica();


            bd.Disconnect();
        }

        private void dataGridViewCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            ProdBD obj = new ProdBD();

            // Obtener productos de la base de datos
            datos = obj.ObtenerProductos();

            // Insertar productos en el árbol por precio
            foreach (var producto in datos)
            {
                arbolPorPrecio.Insertar(producto, (p1, p2) => p1.Price < p2.Price); // Criterio: Precio Ascendente
            }

            // Insertar productos en el árbol por ID
            foreach (var producto in datos)
            {
                arbolPorId.Insertar(producto, (p1, p2) => p1.Id < p2.Id); // Criterio: ID Ascendente
            }

            MessageBox.Show("Árboles creados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mostrar productos ordenados por precio en el RichTextBox
            this.richTextBox1.Clear();
            arbolPorPrecio.MostrarEnOrden(richTextBox1);

            obj.Disconnect();
        }

        private void btnQuitarDelCarrito_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(txtProd.Text); // ID ingresado por el usuario
            int cantidad = Convert.ToInt32(txtCantidad.Text); // Cantidad ingresada por el usuario

            Console.WriteLine($"Buscando producto con ID: {idProducto}");

            // Buscar el producto por ID en el árbol
            var producto = arbolPorId.BuscarPorId(idProducto);

            if (producto != null)
            {
                producto.Cantidad = cantidad; // Actualizar la cantidad
                productosSeleccionados.Add(producto); // Agregarlo a la lista de productos seleccionados
                MessageBox.Show($"Producto {producto.Productdescription} agregado correctamente.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }
        private void ActualizarTotal()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {

        }

        // Método para generar el PDF
        private void GenerarPDF(string contenido)
        {

            string rutaPDF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "compra.pdf");

            try
            {
                // Verificar si hay productos seleccionados
                if (productosSeleccionados.Count == 0)
                {
                    MessageBox.Show("No hay productos para generar el PDF.");
                    return;
                }

                // Crear el escritor de PDF
                using (PdfWriter writer = new PdfWriter(rutaPDF))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document documento = new Document(pdf))
                {
                    // Agregar contenido
                    documento.Add(new Paragraph("Nota de compra:"));
                    documento.Add(new Paragraph($"Fecha: {DateTime.Now}"));
                    documento.Add(new Paragraph("Productos adquiridos:"));

                    foreach (var producto in productosSeleccionados)
                    {
                        if (producto != null)
                        {
                            documento.Add(new Paragraph($"- {producto.Productdescription}, Cantidad: {producto.Stock}, Precio: {producto.Price}"));
                        }
                        else
                        {
                            MessageBox.Show("Un producto tiene valores nulos. No se incluirá en el PDF.");
                        }
                    }

                    // Calcular el total
                    decimal total = (decimal)productosSeleccionados.Sum(p => p.Price * p.Stock);
                    documento.Add(new Paragraph($"Total: {total}"));

                    documento.Close();
                    MessageBox.Show($"PDF generado correctamente en {rutaPDF}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar PDF: {ex.Message}");

            }

        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {

            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("No has agregado productos.");
                return;
            }

            // Crear una instancia de la clase BaseDatos para obtener el nombre del usuario
            AdmonBD db = new AdmonBD();
            ProdBD prodBD = new ProdBD();
            string nombreUsuario = db.ObtenerNombreUsuario(cuenta); // Aquí "cuenta" es el numero de cuenta actual


            StringBuilder notaCompra = new StringBuilder();
            notaCompra.AppendLine($"Usuario: {nombreUsuario}");
            notaCompra.AppendLine($"Fecha: {DateTime.Now}");
            notaCompra.AppendLine("Detalle de la compra:");

            decimal totalCompra = 0;
            foreach (var producto in productosSeleccionados)
            {
                decimal subtotal = (decimal)(producto.Price * producto.Cantidad);
                decimal total = subtotal * 0.6m;
                totalCompra += total;




                prodBD.Actualizarstock(producto.Id, producto.Cantidad);
                notaCompra.AppendLine($"{producto.Productdescription} - {producto.Price} x {producto.Cantidad} = {total}");
            }




            notaCompra.AppendLine($"Total: {totalCompra}");
            richTextBox2.Text = notaCompra.ToString();
            GenerarPDF(notaCompra.ToString());
        }

        private void txtProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelhora.Text = DateTime.Now.ToShortTimeString();
            labelfecha.Text = DateTime.Now.ToShortDateString();
        }

        
            private void button4_Click(object sender, EventArgs e)
        {
                Formadmin formadmin = new Formadmin();
            formadmin.ShowDialog();
            this.Close();
        }

        

        private void buttonfm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }
    }
}
