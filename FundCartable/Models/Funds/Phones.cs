using System.ComponentModel.DataAnnotations;

namespace FundCartable.Models.Funds
{
    public class Phones
    {
        [Key]
        public int Phone_Id { get; set; }
        public string PhoneNumber { get; set; }


        public int Fund_Id { get; set; }
        public Fund fund { get; set; }
    }
}
