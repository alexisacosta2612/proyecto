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
      //  AdmonBD obj = new AdmonBD();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ////////////////////////////////
        /// </summary>
       

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            AdmonBD obj = new AdmonBD();
           obj.logear(this.textBoxcuenta.Text, this.textBoxcontraseña.Text);

        }

        private void buttonloggout_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
