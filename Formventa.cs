using iText.Kernel.Pdf;
using iText.Layout.Element;
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
using iText.Layout;          // Para la clase Document
using iText.Layout.Element;
using System.IO;

namespace proyecto
{
    public partial class Formventa : Form
    {
        private string cuenta;
        List<products> datos;
        List<products> productosSeleccionados = new List<products>();

        private ArbolProductos arbolPorPrecio = new ArbolProductos(); // Árbol para orden por precio
        private ArbolProductos arbolPorId = new ArbolProductos();    // Árbol para búsqueda por ID

        public Formventa()
        {
            InitializeComponent();
        }

        public Formventa(string cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;

        }

        private void Formventa_Load(object sender, EventArgs e)
        {

            // Mostrar el nombre del usuario al cargar el formulario
            Console.WriteLine($"Usuario autenticado: {cuenta}");
            ProdBD bd = new ProdBD(); // Crear instancia de conexión a la base de datos
            _ = bd.ObtenerDatosGrafica();


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
                arbolPorPrecio.Insertar(producto, (p1, p2) => p1.Precio < p2.Precio); // Criterio: Precio Ascendente
            }

            // Insertar productos en el árbol por ID
            foreach (var producto in datos)
            {
                arbolPorId.Insertar(producto, (p1, p2) => p1.Id < p2.Id); // Criterio: ID Ascendente
            }

            MessageBox.Show("Árboles creados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mostrar productos ordenados por precio en el RichTextBox
            richTextBox1.Clear();
            arbolPorPrecio.MostrarEnOrden(richTextBox1);

            obj.Disconnect();
        }

        private void btnQuitarDelCarrito_Click(object sender, EventArgs e)
        {

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
                            documento.Add(new Paragraph($"- {producto.Descripcion}, Cantidad: {producto.Cantidad}, Precio: {producto.Precio}"));
                        }
                        else
                        {
                            MessageBox.Show("Un producto tiene valores nulos. No se incluirá en el PDF.");
                        }
                    }

                    // Calcular el total
                    decimal total = (decimal)productosSeleccionados.Sum(p => p.Precio * p.Cantidad);
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
            ProdBD db = new ProdBD();
            string nombreUsuario = db.ObtenerNombreUsuario(cuenta); // Aquí "cuenta" es el número de cuenta actual

            StringBuilder notaCompra = new StringBuilder();
            notaCompra.AppendLine($"Usuario: {nombreUsuario}");
            notaCompra.AppendLine($"Fecha: {DateTime.Now}");
            notaCompra.AppendLine("Detalle de la compra:");

            decimal totalCompra = 0;
            foreach (var producto in productosSeleccionados)
            {
                decimal subtotal = (decimal)(producto.Precio * producto.Cantidad);
                totalCompra += subtotal;
                notaCompra.AppendLine($"{producto.Descripcion} - {producto.Precio} x {producto.Cantidad} = {subtotal}");
            }

            notaCompra.AppendLine($"Total: {totalCompra}");
            richTextBox2.Text = notaCompra.ToString();
            GenerarPDF(notaCompra.ToString());
        }
    }
}
