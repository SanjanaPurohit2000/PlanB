using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanB.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public String Category { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public String State { get; set; }
        public int Mobile { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public UserProfile UserProfile { get; set; }
        public WishList WishList { get; set; }
    }
}
