using FundCartable.Models.Funds;
using FundCartable.Models.Tranceaction;
using System.ComponentModel.DataAnnotations;

namespace FundCartable.Models.Users
{
    public class User
    {
        [Key]
        public int User_Id{ get; set; }

        [Required]
        [Display(Name ="شماره حساب")]
        public int User_AccountId { get; set; }

        [Required]
        [Display(Name = "نام و نام خانوادگی")]
        public string User_FullName { get; set; }

        [Required]
        [Display(Name = "کدملی")]
        public string User_IRCode { get; set; }

        [Required]
        [Display(Name = "کلمه عبور")]
        public string User_Password { get; set; }

        [Required]
        [Display(Name = "ایمیل")]
        public string User_Email { get; set; }

       
        [Display(Name = "تاریخ تولد")]
        public string User_BirthDay { get; set; }


        
        public int Fund_Id { get; set; }
        public Fund Fund { get; set; }

        public ICollection<Leon> leons { get; set; }
        public ICollection<Monthly> Monthly { get; set; }
    }
}
