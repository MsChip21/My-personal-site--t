using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
namespace MyPersonalSite.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage ="این فیلد اجباریست")]
        [MinLength(3,ErrorMessage = "حداقل طول ، 3 کاراکتر است")]
        [MaxLength(50,ErrorMessage = "حداکثر طول ، 50 کاراکتر است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباریست")]
        [EmailAddress(ErrorMessage ="ساختار ایمیل معتبر نیست")]
        public string Email { get; set; }
        public string service { get; set; }
        public string Message { get; set; }

    }
}
