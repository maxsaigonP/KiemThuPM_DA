using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTest.Areas.Admin.Models
{
    public class InvoiceDetails
    {
        [Key]
        public int Id { get; set; }
        public Invoices Invoice { get; set; }
        public Products Product { get; set; }
        public int Quantity { get; set; }
        public int InitPrice { get; set; }


    }
}
