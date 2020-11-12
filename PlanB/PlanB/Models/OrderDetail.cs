using Microsoft.AspNetCore.Identity;
using PlanB.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanB.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }

        public Product Products { get; set; }
        public ApplicationUser applicationUser { get; set; }
    }
}
