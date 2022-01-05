using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Eshop21.Models
{
    public class Accounts
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "{0} từ 6-20 kí tự")]
        public string Username { get; set; }
        [DisplayName("Mật khẩu")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "{0} từ 6-20 kí tự")]
        public string Password { get; set; }
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "{0} không hợp lệ")]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        [Phone(ErrorMessage = "{0} không hợp lệ")]
        public string Phone { get; set; }
        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "{0} nhập địa chỉ không hợp lệ")]
        public string Address { get; set; }
        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "{0} tên không hợp lệ")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "{0} không hợp lệ")]

        public string FullName { get; set; }
        [DisplayName("Tài khoản")]
        [Required(ErrorMessage = "{0}  không hợp lệ")]


        public bool IsAdmin { get; set; }
        [DisplayName("Hình đại diện")]
        [Required(ErrorMessage = "{0} Hình không hợp lệ")]


        public string Avatar { get; set; }
        [DisplayName("Trạng thái")]
        [Required(ErrorMessage = "{0}  không hợp lệ")]
        
        public bool Status { get; set; }



    }
}
