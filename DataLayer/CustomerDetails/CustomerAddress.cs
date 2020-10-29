using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.CustomerDetails
{
   public class CustomerAddress
    {
        [Key]
        public int id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
         public virtual Customer CustomerId { get; set; }
    }
}
