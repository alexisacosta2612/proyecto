using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyecto
{
    public partial class Formadd : Form
          
    {
        List<products> data;
        public void limpiar()
        {
            MessageBox.Show("entre a limpiar");


        }
        public Formadd()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            int id;
            string namepicture;
            string product_description;
            int price;
            int stock;

            id = Convert.ToInt32(this.textBoxidadd.Text);
            namepicture = this.textBoxnamepictureadd.Text;
            product_description = this.textBoxpdadd.Text;
            price = Convert.ToInt32(this.textBoxpriceadd.Text);
            stock = Convert.ToInt32(this.textBoxstockadd.Text);

            ProdBD obj = new ProdBD();
            obj.insertar(id, namepicture, product_description, price, stock);
            limpiar();
            obj.Disconnect();
            this.Close();
        }
    }
}
