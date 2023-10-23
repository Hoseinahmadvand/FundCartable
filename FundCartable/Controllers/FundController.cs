
using FundCartable.Data;
using FundCartable.Models.Funds;
using FundCartable.Repositories;
using FundCartable.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FundCartable.Controllers
{
    public class FundController : Controller
    {
        private readonly IFundServices _fundServices;
        private readonly FundAppContext _appContext;

        public FundController(IFundServices fundServices, FundAppContext appContext)
        {
            _fundServices = fundServices;
            _appContext = appContext;

        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> CreateFund()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFund(FundVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _fundServices.CreatFund(model);
            return View(model);
            
            return RedirectToAction("AddAdmin");

        }
        public IActionResult AddAdmin()
        {
            return View();
        }

    }
}
