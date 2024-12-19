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
using MySql.Data.MySqlClient;


namespace proyecto
    
{
    public partial class Formadmin : Form
    {
        List<registros> dato;
        List<products> data;
        public Formadmin(string nombre)
        {
            InitializeComponent();
            labeladmin.Text = nombre;

        }

        public void limpiar()
        {
            MessageBox.Show("entre a limpiar");


        }

        private void Formadmin_Load(object sender, EventArgs e)
        {

        }
        private string correoUsuario;
        /* public Formadmin(string correo)
         {
             InitializeComponent();
             correoUsuario = correo;

             // Ahora puedes usar correoUsuario como clave o hacer las validaciones necesarias
             MessageBox.Show($"Bienvenido al panel de administrador. Correo: {correoUsuario}");
         }*/

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            ProdBD obj = new ProdBD();
            data = obj.consult();
            this.richTextBox1.Clear();
            data.ForEach(p =>
            {
                this.richTextBox1.AppendText("id=" + p.Id + " Namepicture=" + p.Namepicture + " =Productdescription" + p.Productdescription + " Price:" + p.Price + " Stock=" + p.Stock + "\n");
            });

            obj.Disconnect();
        }





        private void buttonMod_Click(object sender, EventArgs e)
        {

        }

        private void buttonver_Click(object sender, EventArgs e)
        {

        }

        private void textBoxidadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnamepictureadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpdadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpriceadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxstockadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxiddelete_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttondelete_Click_1(object sender, EventArgs e)
        {
            ProdBD obj = new ProdBD();
            int totalProductos = obj.obtenerTotalProductos();  // Método que debes crear para obtener el número total de productos
            
            // Si el numero de productos es menor o igual a 6, no permitir la eliminacion
            if (totalProductos <= 6)
            {
                MessageBox.Show("No se puede eliminar el producto, ya que hay 6 o menos productos en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Detener la eliminacion
            }

            int id = Convert.ToInt32(textBoxiddelete.Text); // ID tomado del campo de texto




            // Mostrar un cuadro de diálogo de confirmacion
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este registro?",
                "Confirmar eliminación",
               
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Evaluar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Lógica para eliminar el registro

                obj.eliminar(id);
                obj.Disconnect();
                MessageBox.Show("Registro eliminado exitosamente.");
            }
            else
            {
                // El usuario cancelo la acción
                MessageBox.Show("Eliminación cancelada.");
            }
        }





        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxmodid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxidmod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnamepicturemod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpdmod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpricemod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxstockmod_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (labeladmin.Text == "admin")
            //{
            Formadd formadd = new Formadd();
            formadd.ShowDialog();
            //}
            //else
            //{
            //  MessageBox.Show("No tienes permisos para agregar productos.");
            //}
        }

        private void buttonMODIFICAR_Click(object sender, EventArgs e)
        {


            //if (labeladmin.Text == "invitado" )
            //{
            Formmod formmod = new Formmod();
            formmod.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("No tienes permisos para modificar productos.");
            // }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1morestock_Click(object sender, EventArgs e)
        {
            ProdBD obj = new ProdBD();
            data = obj.consult();
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < data.Count - 1 - i; j++)
                {
                    if (data[j].Stock < data[j + 1].Stock)
                    {
                        // Intercambiar los elementos
                        var temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            this.richTextBox2.Clear();
            data.ForEach(p =>
            {
                this.richTextBox2.AppendText("Namepicture=" + p.Namepicture + " Stock=" + p.Stock + "\n");
            });

            obj.Disconnect();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();
            this.Close();
        }


        private void GuardarCompra()
        {
            try
            {


                MessageBox.Show("Compra realizada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la compra: " + ex.Message);
            }
        }

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            GuardarCompra();
        }
        private decimal totalVentas = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            //BUTTON TOTAL DE VENTAS
            ProdBD prodBD = new ProdBD();
            prodBD.consult();
            List<products> productos = prodBD.consult();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelhora.Text = DateTime.Now.ToShortTimeString();
            labelfecha.Text = DateTime.Now.ToShortDateString();
        }

        /*  private void button4_Click(object sender, EventArgs e)
          {
              Formventa fmventa = new Formventa();
              fmventa.ShowDialog();
              this.Hide();
          }*/

        private void textBoxtotalvntas_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
