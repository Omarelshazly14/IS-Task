using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderHeader : BaseEntity
    {
        public string CustomerName { get; set; }
        public int OrderNo { get; set; }

        //Business layer add conversion between dates
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal TotalCost { get; set; }


        //Navigation Properties
        public virtual List<OrderDetails> OrderDetails { get; set; }

    }
}
