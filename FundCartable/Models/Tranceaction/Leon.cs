using FundCartable.Models.Funds;
using FundCartable.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace FundCartable.Models.Tranceaction
{
    public class Leon
    {
        [Key]
        public int Leon_Id { get; set; }

        [Required]
        [Display(Name = "مقدار وام")]
        public decimal Leon_Amount { get; set; }

        [Required]
        [Display(Name = "تعداد اقساط")]
        public int Leon_Term { get; set; }

        [Required]
        [Display(Name = "تاریخ شروع")]
        public DateTime Leon_DateStarted { get; set; }

        [Required]
        [Display(Name = "تاریخ پایان")]
        public DateTime Leon_DateEnded { get; set; }




        public int UserId { get; set; }
        public User User { get; set; }
   

        public ICollection<Installment> Installments { get; set; }

    }
}
