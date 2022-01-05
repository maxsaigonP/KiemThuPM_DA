using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTest.Areas.Admin.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        public int Stock { get; set; }
        public Products ProductType { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
    }
}
