using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using pc533016MIS4200.Models;

namespace pc533016MIS4200.Models
{
    public class OrderDetail
    {
            public int orderdetailID { get; set; }

        [Required]
        [Display(Name = "Quantity Ordered")]
            public int qtyOrdered { get; set; }

        [Display(Name = "Unit cost")]
        [Required]
        [DataType(DataType.Currency)]
        public decimal price { get; set; }

            // the next two properties link the orderDetail to the Order
            [Display(Name = "Order Number" )]
        public int orderID { get; set; }
            public virtual Orders Orders { get; set; }

        // the next two properties link the orderDetail to the Product
        [Display(Name = "Product ID")]
        public int productID { get; set; }
            public virtual Products Products { get; set; }
    }
}