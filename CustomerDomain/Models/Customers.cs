using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerDomain.Models
{
    public partial class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
