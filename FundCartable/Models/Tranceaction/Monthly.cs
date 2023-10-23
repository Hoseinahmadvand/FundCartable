using FundCartable.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace FundCartable.Models.Tranceaction
{
    public class Monthly
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="مقدار")]
        public decimal Amount { get; set; }
        [Required]
        [Display(Name = "تاریخ پرداخت")]
        public DateTime DueDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
