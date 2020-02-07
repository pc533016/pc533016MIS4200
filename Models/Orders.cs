using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pc533016MIS4200.Models
{
    public class Orders
    {
        [Key]
        public int orderNum { get; set; }
        public int description { get; set; }
        public DateTime orderDate { get; set; }

        // add any other fields as appropriate

        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection

        public ICollection<OrderDetail> OrderDetail { get; set; }

        //Order is on the Many side of the one-to-many relationship between Customer 
        //and Order and we represent that relationship like this 

        public int customerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}