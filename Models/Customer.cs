using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pc533016MIS4200.Models
{
    public partial class Customer
    {
        [Display(Name = "Customer name")]
        public int customerID { get; set; }

        [Display (Name = "First name")]
        [Required(ErrorMessage = "Customer first name is required")]
        public string firstName { get; set; }

        [Display (Name = "Last name")]
        [Required(ErrorMessage = "Customer last name is required")]
        public string lastName { get; set; }

        [Display (Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your email address")]
        public string email { get; set; }

        [Display (Name = "Phone number")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", 
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }

        [Display (Name = "When did you become a customer?")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime customerSince { get; set; }

        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Order
        // (the object name and the local name do not have to be the same)
        public ICollection<Orders> Orders { get; set; }

        [Display(Name = "Full name")]
        public string fullName {
            get
            {
                return lastName + ", " + firstName;
            }
        }

    }
}