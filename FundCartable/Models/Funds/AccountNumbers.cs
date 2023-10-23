using System.ComponentModel.DataAnnotations;

namespace FundCartable.Models.Funds
{
    public class AccountNumbers
    {
        [Key]
        public int AccountNumber_Id { get; set; }
        public string AccountNumber { get; set; }


        public int Fund_Id { get; set; }
        public Fund fund { get; set; }
    }
}
