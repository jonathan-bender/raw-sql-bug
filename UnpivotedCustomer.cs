using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EFCoreBugV3
{
    public class UnpivotedCustomer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
