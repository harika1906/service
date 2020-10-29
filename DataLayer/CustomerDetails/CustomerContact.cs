using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.CustomerDetails
{
   public class CustomerContact
    {
        public int Id { get; set; }
        public string Personal { get; set; }
        public string Home { get; set; }
        public string Work { get; set; }
        public virtual Customer CustomerId { get; set; }
    }
}
