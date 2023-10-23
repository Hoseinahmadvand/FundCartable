using FundCartable.Models.Funds;
using FundCartable.ViewModels;

namespace FundCartable.Repositories
{
    public interface IFundServices
    {
        Task CreatFund(FundVM fund);
    }
}
