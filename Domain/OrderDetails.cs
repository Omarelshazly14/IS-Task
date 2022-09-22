using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderDetails
    {
        public int Id { get; set; }

        [Display(Name="Item Number")]
        public string ItemNo { get; set; }
        [Display(Name ="Item Description")]
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }

        [Display(Name ="Item Price")]
        public decimal ItemPrice { get; set; }

        //Foreign Keys
        [ForeignKey("Order")]
        public int OrderID { get; set; }

        //Navigation Properties
        public OrderHeader Order { get; set; }

    }
}
