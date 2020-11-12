<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Identity;
using PlanB.Areas.Identity.Data;
using System;
=======
﻿using System;
>>>>>>> 351c46abc4f269c891d4af46a8e693a80b2dee5d
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanB.Models
{
    public class WishList
    {
<<<<<<< HEAD
        public int ID { get; set; }

        public Product Products { get; set; }
        public ApplicationUser applicationUser { get; set; }
=======
        public int WishId { get; set; }
        
        public int UserId { get; set; }
        public UserProfile UserProfile { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }

>>>>>>> 351c46abc4f269c891d4af46a8e693a80b2dee5d
    }
}
