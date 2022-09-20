using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderDetails : BaseEntity
    {
        public string ItemNo { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }

        //Foreign Keys
        [ForeignKey("Order")]
        public int OrderID { get; set; }

        //Navigation Properties
        public OrderHeader Order { get; set; }

    }
}
