using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pc533016MIS4200.Models
{
    public class Patient
    {
        [Key]
        public int patientID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime patientSince { get; set; }

        // add any other fields as appropriate

        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection

        public ICollection<DoctorPatient> DoctorPatient { get; set; }

        //Order is on the Many side of the one-to-many relationship between Customer 
        //and Order and we represent that relationship like this 

        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}