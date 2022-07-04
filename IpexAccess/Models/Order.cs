using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IpexAccess.Models
{
    public class Order
    {
        [Key]
        public int salesID { get; set; }

        // Foreign
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        // Order Items

    }
}
