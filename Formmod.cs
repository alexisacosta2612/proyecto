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
    public partial class Formmod : Form
    {
        List<products> data;
        public void limpiar()
        {
            MessageBox.Show("entre a limpiar");


        }
        public Formmod()
        {
            InitializeComponent();
        }

        private void buttonmod_Click(object sender, EventArgs e)
        {
            int id;
            string namepicture;
            string productdescription;
            int price;
            int stock;

            id = Convert.ToInt32(this.textBoxidmod.Text);
            namepicture = this.textBoxnamepicturemod.Text;
            productdescription = this.textBoxpdmod.Text;
            price = Convert.ToInt32(this.textBoxpricemod.Text);
            stock = Convert.ToInt32(this.textBoxstockmod.Text);


            ProdBD obj = new ProdBD();

            obj.actualizar(id, namepicture, productdescription, price, stock);
            obj.Disconnect();
            this.Close();

        }

        private void buttonseedatamod_Click(object sender, EventArgs e)
        {
            ProdBD obj = new ProdBD();
            products aux = obj.const_regprod(Convert.ToInt32(this.textBoxmodid.Text));
            MessageBox.Show("aux=" + aux.Id + " " + aux.Namepicture + " " + aux.Productdescription + " " + aux.Price + " " + aux.Stock);


            this.textBoxidmod.Text = Convert.ToString(aux.Id);
            this.textBoxnamepicturemod.Text = aux.Namepicture;
            this.textBoxpdmod.Text = aux.Productdescription;
            this.textBoxpricemod.Text = Convert.ToString(aux.Price);
            this.textBoxstockmod.Text = Convert.ToString(aux.Stock);


            obj.Disconnect();

        }

        private void Formmod_Load(object sender, EventArgs e)
        {

        }
    }
}
