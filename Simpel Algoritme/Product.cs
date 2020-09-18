using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpel_Algoritme
{
    class Product
    {
        public string name { get; private set; }
        public double price { get; private set; }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        //methods
        public override string ToString()
        {
            return name + " " + price;
        }
    }
}
