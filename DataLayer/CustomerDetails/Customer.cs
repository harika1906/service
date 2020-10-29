using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.CustomerDetails
{
   public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }
    }
}
