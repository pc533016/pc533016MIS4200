using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using pc533016MIS4200.Models;

    public class Doctor
    {
        [Key]
        public int doctorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime doctorSince { get; set; }

    // add any other fields as appropriate

    //Doctor is on the "one" side of a one-to-many relationship with OrderDetail
    //we indicate that with an ICollection
    public ICollection<DoctorPatient> DoctorPatient { get; set; }
    }
