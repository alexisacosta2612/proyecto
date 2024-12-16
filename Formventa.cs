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
    public partial class Formventa : Form
    {
        ProdBD prodDB = new ProdBD();
        private int indice;
        List<products> carrito = new List<products>();
        public Formventa()
        {
            InitializeComponent();
            indice = 0;
        }
        public void llenar_tabla()
        {

        }
        private void Formventa_Load(object sender, EventArgs e)
        {
            try
            {
                // Consulta los datos
                List<products> datos = prodDB.consult();


                // Vincula la lista al DataGridView
                dataGridView1.DataSource = datos;

                // Opcional: Ajustar columnas para que se adapten al contenido
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                indice++;
                if (indice > 7)
                    indice = 0;
                lblfoto.ImageIndex = indice;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en el DataGridView: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder compraDetails = new StringBuilder();
                decimal total = 0;

                // Añadir los productos del carrito al archivo
                foreach (var producto in carrito)
                {
                    compraDetails.AppendLine($"Producto: {producto.Namepicture} - Precio: ${producto.Price}");
                    total += producto.Price;
                }

                // Agregar el total al archivo
                compraDetails.AppendLine($"Total de la compra: ${total}");

                // Guardar el detalle de la compra en un archivo de texto
                string rutaArchivo = "compra.txt"; // Nombre del archivo donde se guardará la compra
                System.IO.File.WriteAllText(rutaArchivo, compraDetails.ToString());

                MessageBox.Show("Compra guardada en el archivo 'compra.txt'.", "Compra guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarDelCarrito_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarrito.SelectedRows.Count > 0)
            {
                // Obtiene el producto seleccionado del carrito
                int idProducto = Convert.ToInt32(dataGridViewCarrito.SelectedRows[0].Cells["Id"].Value);
                products productoAEliminar = carrito.FirstOrDefault(p => p.Id == idProducto);

                if (productoAEliminar != null)
                {
                    // Elimina el producto del carrito
                    carrito.Remove(productoAEliminar);

                    // Actualiza el DataGridView del carrito
                    dataGridViewCarrito.DataSource = null;
                    dataGridViewCarrito.DataSource = carrito;

                    // Actualiza el total
                    ActualizarTotal();
                }
            }

        }
        private void ActualizarTotal()
        {
            decimal total = carrito.Sum(p => p.Price);  // Calcula la suma de los precios de los productos en el carrito
            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }
    }
}
