using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop21.Models
{
    public class InvoiceDetails
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} không hợp lệ")]
        public int InvoiceId { get; set; }
        [Required(ErrorMessage = "{0} không hợp lệ")]
        [ForeignKey("InvoiceId")]

        public int ProductId { get; set; }
        [Required(ErrorMessage = "{0} số lượng hợp lệ")]
        [ForeignKey("ProductId")]

        public int Quantity { get; set; }
        [Required(ErrorMessage = "{0} đơn giá không hợp lệ")]

        public int UnitPrice { get; set; }
        public Invoices Invoices { get; set; }
        public Products Products { get; set; }
    }
}
