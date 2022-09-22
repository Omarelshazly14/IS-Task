using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderHeader
    {
        public int Id { get; set; }
        [Display(Name="Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Order Number")]
        public int OrderNo { get; set; }

        //Business layer add conversion between dates
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [Display(Name = "Total Cost")]
        public decimal TotalCost { get; set; }


        //Navigation Properties
        public virtual List<OrderDetails> OrderDetails { get; set; }

    }
}
