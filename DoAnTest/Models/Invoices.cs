using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop21.Models
{
    public class Invoices
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} không hợp lệ")]

        public string Code { get; set; }
        [Required(ErrorMessage = "{0} tài khoản không hợp lệ")]

        public int AccountId { get; set; }
        [Required(ErrorMessage = "{0} ngày không hợp lệ")]
        [ForeignKey("AccountId")]

        public DateTime IssuedDate { get; set; }
        [Required(ErrorMessage = "{0} địa chỉ giao hàng không hợp lệ")]
        [StringLength(100, ErrorMessage ="Tối đa 100 ký tự")]
        
        public string ShippingAddress { get; set; }
        [Required(ErrorMessage = "{0} số điện thoại không hợp lệ")]
        public string ShippingPhone { get; set; }
        [Required(ErrorMessage = "{0} Tổng số tiền không đúng")]

        public int Total { get; set; }
        [Required(ErrorMessage = "{0} Trạng thái ")]

        public bool Status { get; set; }
        public Accounts Accounts { get; set; }
    }
}
