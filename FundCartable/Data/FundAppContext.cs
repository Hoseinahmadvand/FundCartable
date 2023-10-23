using FundCartable.Models.Funds;
using FundCartable.Models.Tranceaction;
using FundCartable.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace FundCartable.Data
{
    public class FundAppContext:DbContext
    {
        public FundAppContext(DbContextOptions<FundAppContext> options) : base(options) { }

        #region Fund

        public DbSet<Fund> funds { get; set; }
        public DbSet<AccountNumbers> accountNumbers { get; set; }
        public DbSet<Phones> phones { get; set; }
        public DbSet<Admins> admins { get; set; }

        #endregion

        #region user
        public DbSet<User> users { get; set; }
        #endregion

        #region Tranceaction

        public DbSet<Leon> leons { get; set; }
        public DbSet<Installment> installments { get; set; }
        public DbSet<Monthly> Monthlies { get; set; }
        #endregion
    }
}
