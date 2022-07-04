using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IpexAccess.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string BusinessName { get; set; }

        // Customer Orders
        public List<Order> Orders { get; set; }
    }
}
