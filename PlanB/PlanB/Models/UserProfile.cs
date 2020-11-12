using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanB.Models
{
    public class UserProfile
    {
        public int UserId { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }
        public String State { get; set; }
        public String City { get; set; }
        public int PinCode { get; set; }
        public int Mobile { get; set; }
        public String Email { get; set; }

        public Products Prducts { get; set; }
        public WishList WishList { get; set; }
        public OrderDetails OrderDetails { get; set; }
        
    }
}
