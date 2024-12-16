using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class products
    {
        int id;
        string namepicture;
        string productdescription;
        int price;
        int stock;
        public products() { }
        public products(int id, string namepicture, string productdescription, int price, int stock)
        {

            this.Id = id;
            this.Namepicture = namepicture;
            this.Productdescription = productdescription;
            this.Price = price;
            this.Stock = stock;



        }
      

        public int Id { get => id; set => id = value; }
        public string Namepicture { get => namepicture; set => namepicture = value; }
        public string Productdescription { get => productdescription; set => productdescription = value; }
        public int Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
