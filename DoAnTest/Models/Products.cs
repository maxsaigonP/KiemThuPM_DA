using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop21.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} không hợp lệ")]

        public string SKU { get; set; }
        [Required(ErrorMessage = "{0} tên không hợp lệ")]

        public string Name { get; set; }
        [Required(ErrorMessage = "{0} mô tả không hợp lệ")]

        public string Description { get; set; }
        [Required(ErrorMessage = "{0} Giá không hợp lệ")]

        public int Price { get; set; }
        [Required(ErrorMessage = "{0} Số lượng kho  không hợp lệ")]

        public int Stock { get; set; }
        [Required(ErrorMessage = "{0} không hợp lệ")]

        public int ProductTypeId { get; set; }
        [Required(ErrorMessage = "{0} không hợp lệ")]
        [ForeignKey("ProductTypeId")]

        public string Image { get; set; }
        [Required(ErrorMessage = "{0} không hợp lệ")]

        public bool Status { get; set; }
        public ProductTypes ProductTypes { get; set; }

    }
}
