using System.ComponentModel.DataAnnotations;

namespace FundCartable.Models.Tranceaction
{
    public class Installment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "مقدار")]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "تاریخ پرداخت")]
        public DateTime DueDate { get; set; }

        public bool Paid { get; set; }



        public int LoanId { get; set; }
        public Leon leon { get; set; }
    }
}
