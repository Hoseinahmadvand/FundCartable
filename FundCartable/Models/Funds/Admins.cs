using FundCartable.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace FundCartable.Models.Funds
{
    public class Admins
    {
        [Key]
        public int Admin_ID { get; set; }
        [Required]
        [Display(Name ="شناسه ادمین")]
        public string Admin_UserName { get; set; }

        [Required]
        [Display(Name = "کلمه عبور")]
        public string Admin_Password { get; set; }



        public int Fund_Id { get; set; }
        public Fund fund { get; set; }
        
    }
}
