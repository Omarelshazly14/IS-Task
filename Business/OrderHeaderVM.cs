using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class OrderHeaderVM
    {
        public string CustomerName { get; set; }
        public int OrderNo { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal TotalCost { get; set; }
    }
}
