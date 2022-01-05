using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTest.Areas.Admin.Models
{
    public class Invoices
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public Accounts Account { get; set; }
        public DateTime IssuedDate { get; set; }
        [Required]
        public string ShipingAddress { get; set; }
        [Required]
        public string ShipingPhone { get; set; }
        [Required]
        public int Total { get; set; }
        public int Status { get; set; }

    }
}
