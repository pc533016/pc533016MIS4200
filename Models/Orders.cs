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

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description field is required")]
        public int description { get; set; }

        [Display(Name = "Order Date")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime orderDate { get; set; }

        // add any other fields as appropriate

        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection

        public ICollection<OrderDetail> OrderDetail { get; set; }

        //Order is on the Many side of the one-to-many relationship between Customer 
        //and Order and we represent that relationship like this 

        [Display(Name = "Customer name")]
        public int customerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}