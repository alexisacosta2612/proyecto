using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class datoos
    {

        private int ventastotales;
        private int datosext;

        public datoos()
        {

        }
        public datoos(int ventastotales, int datosext)
        {
            Ventastotales = ventastotales;
            Datosext = datosext;
           
        }

        public int Ventastotales { get => ventastotales; set => ventastotales = value; }
        public int Datosext { get => datosext; set => datosext = value; }
    }
}
