using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using pc533016MIS4200.Models;

    public class Products
    {
        [Key]
        public int productsID { get; set; }
        public int supplierID { get; set; }

    [Display(Name = "Description")]
    [Required(ErrorMessage = "Description field is required")]
    public string description { get; set; }

    [Display(Name = "Unit cost")]
    [Required]
    [DataType(DataType.Currency)]
        public decimal unitCost { get; set; }

        // add any other fields as appropriate

        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
