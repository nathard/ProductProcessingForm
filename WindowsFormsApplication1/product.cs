using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Product
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public decimal MarkUp { get; set; }
        public decimal Cost { get; set; }
        public int Qty { get; set; }
        public decimal SalePrice
        {
            get
            {
                return Cost * (1 + MarkUp / 100);
                //decimal Price = 0;
                //Price = Cost * (1 + MarkUp / 100)
                //return Price;
            }
        }
        public override string ToString()
        {
            return string.Format("{0,-5} {1,-15} - {2,4} @ {3,8:c} * {4,8:p2} {5,8:c}", ID, Description, Qty, Cost, MarkUp / 100, SalePrice);
        }
    }
}
