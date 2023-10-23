using FundCartable.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace FundCartable.Models.Funds
{
    public class Fund
    {
        [Key]
        public int Fund_Id { get; set; }

        [Required]
        [Display(Name = "نام صندوق")]
        public string Fund_Name { get; set; }

        [Required]
        [Display(Name = "موجودی صندوق")]
        public string Fund_Count { get; set; }

        [Display(Name = "توضیحات")]
        public string Fund_Description { get; set; }

        [Display(Name = "آدرس")]
        public string Fund_Address { get; set; }


        public ICollection<Admins> Admins { get; set; }
        public ICollection<User> Users { get; set; }



    }
}
