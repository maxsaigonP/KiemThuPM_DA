using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTest.Areas.Admin.Models
{
    public class Carts
    {
        [Key]
        public int id { get; set; }
        public Accounts Account { get; set; }
        public Products Product { get; set; }
        public int Quantity { get; set; }
    }
}
