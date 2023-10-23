using FundCartable.Data;
using FundCartable.Models.Funds;
using FundCartable.Repositories;
using FundCartable.ViewModels;

namespace FundCartable.Services
{
    public class FundServices : IFundServices
    {
        private readonly FundAppContext _appContext;
        public FundServices(FundAppContext appContext)
        {
            _appContext = appContext;
        }

        public async Task CreatFund(FundVM fund)
        {
            var model = new Fund
            {
                Fund_Name = fund.Fund_Name,
                Fund_Address = fund.Fund_Address,
                Fund_Count = fund.Fund_Count,
                Fund_Description = fund.Fund_Description

            };
            await _appContext.funds.AddAsync(model);
            await _appContext.SaveChangesAsync();
        }
    }
}
