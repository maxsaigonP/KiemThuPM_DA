using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoAnTest.Areas.Admin.Models;

namespace DoAnTest.Data
{
    public class DoAnTestContext : DbContext
    {
        public DoAnTestContext (DbContextOptions<DoAnTestContext> options)
            : base(options)
        {
        }

        public DbSet<DoAnTest.Areas.Admin.Models.Accounts> Accounts { get; set; }

        public DbSet<DoAnTest.Areas.Admin.Models.Carts> Carts { get; set; }

        public DbSet<DoAnTest.Areas.Admin.Models.InvoiceDetails> InvoiceDetails { get; set; }

        public DbSet<DoAnTest.Areas.Admin.Models.Invoices> Invoices { get; set; }

        public DbSet<DoAnTest.Areas.Admin.Models.Products> Products { get; set; }

        public DbSet<DoAnTest.Areas.Admin.Models.ProductTypes> ProductTypes { get; set; }
    }
}
