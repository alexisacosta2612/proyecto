using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proyecto.products;


namespace proyecto
{
    internal class ArbolProductos
    {
        public NodoProducto raiz;

        public ArbolProductos()
        {
            raiz = null;
        }

        // Método para insertar un producto en el árbol (usando un criterio de comparación)
        public void Insertar(products producto, Func<products, products, bool> criterio)
        {
            raiz = InsertarRecursivo(raiz, producto, criterio);
        }

        private NodoProducto InsertarRecursivo(NodoProducto nodo, products producto, Func<products, products, bool> criterio)
        {
            if (nodo == null)
            {
                nodo = new NodoProducto(producto);
            }
            else if (criterio(producto, nodo.Producto)) // Usamos el criterio proporcionado
            {
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, producto, criterio);
            }
            else
            {
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, producto, criterio);
            }
            return nodo;
        }

        // Mostrar productos en el RichTextBox en orden
        public void MostrarEnOrden(RichTextBox richTextBox)
        {
            if (raiz != null)
            {
                MostrarEnOrdenRecursivo(raiz, richTextBox);
            }
        }

        private void MostrarEnOrdenRecursivo(NodoProducto nodo, RichTextBox richTextBox)
        {
            if (nodo != null)
            {
                MostrarEnOrdenRecursivo(nodo.Izquierdo, richTextBox); // Primero el menor

                //Mostrar en richTextBox
                richTextBox.AppendText($"ID={nodo.Producto.Id} Producto={nodo.Producto.Productdescription} Precio={nodo.Producto.Price} Existencias={nodo.Producto.Stock}\n");

                MostrarEnOrdenRecursivo(nodo.Derecho, richTextBox); // Luego el mayor
            }
        }

        // Método para buscar productos (por ID en este caso)
        public products BuscarPorId(int id)
        {
            return BuscarRecursivo(raiz, id);
        }

        private products BuscarRecursivo(NodoProducto nodo, int id)
        {
            if (nodo == null) return null;

            if (nodo.Producto.Id == id)
            {
                return nodo.Producto;
            }
            else if (id < nodo.Producto.Id)
            {
                return BuscarRecursivo(nodo.Izquierdo, id);
            }
            else
            {
                return BuscarRecursivo(nodo.Derecho, id);
            }
        }

    }
}
