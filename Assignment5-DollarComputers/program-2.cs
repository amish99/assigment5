using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_DollarComputers
{

    public partial class products
    { //public properties
        public int Id { get; set; }



        public decimal Cost { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string Screensize { get; set; }
        //constructor
        public products(int id = 1, decimal cost = 1.1m, string manufacturer = "", string model = "", string screensize = "")
        {
            Id = id;
            Cost = cost;
            Manufacturer = manufacturer;
            Model = model;
            Screensize = screensize;

        }
    }

}
