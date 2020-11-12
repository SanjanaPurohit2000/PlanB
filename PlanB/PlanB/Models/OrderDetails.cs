using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanB.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        
        public UserProfile UserProfile { get; set; }
    }
}
