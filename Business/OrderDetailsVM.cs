
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class OrderDetailsVM
    {
        public string ItemNo { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }

        public int OrderID { get; set; }

    }
}
