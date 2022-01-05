using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop21.Models
{
    public class Carts
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} Nhập mã tài khoản không hợp lệ")]
        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        [Required(ErrorMessage = "{0} Nhập mã sản phẩm không hợp lệ")]

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]


        [Required(ErrorMessage = "{0} Nhập số lượng không hợp lệ")]
        public int Quantity { get; set; }
        public Accounts Accounts { get; set; }
        public Products Products { get; set; }
    }
}
