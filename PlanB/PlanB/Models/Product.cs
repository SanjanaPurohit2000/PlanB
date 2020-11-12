using Microsoft.AspNetCore.Identity;
using PlanB.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlanB.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public String Category { get; set; }
        [Required(ErrorMessage = "Please enter Product name"), MaxLength(30)]
        [Display(Name = "Product Name")]

        public String ProductName { get; set; }
        [Required]
        [Display(Name = "Enter Price")]
        public double Price { get; set; }
        public String State { get; set; }
        [Required]
        [Display(Name = "Contact number")]
        public int Mobile { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public byte[] ProductImage1 { get; set; }
        [Required]
        public byte[] ProductImage2 { get; set; }
        [Required]
        public byte[] ProductImage3 { get; set; }
        public byte[] ProductImage4 { get; set; }
        public byte[] ProductImage5 { get; set; }
        public byte[] ProductImage6 { get; set; }

        public ApplicationUser applicationUser { get; set; }
    }
}
