using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Product
    {

        public int IdProduct { get; set; }

        //[ForeignKey("categoty")]
        public int IdCategoty { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }

        //public virtual Category categoty { get; set; }
    }

}
