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
    public partial class FormGrafica : Form
    {
        public FormGrafica(string cuentaIngresada)
        {
            InitializeComponent();
        }


        // Método para insertar los productos en una tabla hash y ordenarlos por existencias
        private Dictionary<string, (int existencias, int precio)> ObtenerProductosOrdenados()
        {
            ProdBD bd = new ProdBD(); // Crear instancia de conexión a la base de datos
            List<(string descripcion, int existencias, int precio)> datos = bd.ObtenerDatosGrafica();

            // Crear la tabla hash (diccionario) con la descripción como clave y tupla de (existencias, precio) como valor
            Dictionary<string, (int, int)> hashTable = new Dictionary<string, (int, int)>();

            foreach (var dato in datos)
            {
                hashTable[dato.descripcion] = (dato.existencias, dato.precio); // Insertar en la tabla hash
            }

            // Ordenar los productos por existencias (de menor a mayor) y convertirlo de nuevo a Dictionary
            var productosOrdenados = hashTable
                .OrderBy(p => p.Value.Item1)  // Ordenar por el valor de las existencias (Item1 de la tupla)
                .ToDictionary(p => p.Key, p => p.Value);  // Convertir el resultado ordenado de nuevo a un diccionario

            return productosOrdenados;
        }

        private void FormGrafica_Load(object sender, EventArgs e)
        {
            ProdBD bd = new ProdBD();
            // Obtener los productos ordenados por existencias
            var productosOrdenados = ObtenerProductosOrdenados();

            // Configurar la gráfica
            chartProductos.Series.Clear(); // Limpia las series anteriores
            chartProductos.Titles.Add("Productos vs Existencias"); // Título de la gráfica
            chartProductos.Series.Add("Existencias"); // Agrega una serie para existencias

            // Configurar eje X e Y
            chartProductos.ChartAreas[0].AxisX.Title = "Productos";
            chartProductos.ChartAreas[0].AxisY.Title = "Existencias";

            // Llenar los datos en la gráfica con los productos ordenados
            foreach (var producto in productosOrdenados)
            {
                chartProductos.Series["Existencias"].Points.AddXY(producto.Key, producto.Value.Item1); // Key = descripción, Value.Item1 = existencias
            }

            bd.Disconnect();
        }

        private void CambiarDeFormulario()
        {
            Form2 form2 = new Form2();// Crear una instancia del segundo formulario
            form2.Show(); // Mostrar el segundo formulario
            this.Hide(); // Ocultar el formulario actual (opcional, si deseas ocultarlo en lugar de cerrarlo)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarDeFormulario();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            // Obtener los productos ordenados por existencias
            var productosOrdenados = ObtenerProductosOrdenados();

            // Limpiar el gráfico
            chartProductos.Series.Clear();

            // Agregar una nueva serie con los productos ordenados
            var serie = chartProductos.Series.Add("Productos");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Llenar los puntos de la gráfica con los productos ordenados
            foreach (var producto in productosOrdenados)
            {
                serie.Points.AddXY(producto.Key, producto.Value.Item1);
            }

            // Desconectar la base de datos
            ProdBD obj = new ProdBD();
            obj.Disconnect();
        }
    }
}
