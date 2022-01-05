using System.ComponentModel.DataAnnotations;

namespace Eshop21.Models
{
    public class ProductTypes
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} Tên không hợp lệ")]

        public string Name { get; set; }
        [Required(ErrorMessage = "{0} Trạng thái không hợp lệ")]

        public bool Status { get; set; }
    }
}
