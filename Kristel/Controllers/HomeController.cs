using Kristel.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Kristel.WEB.Controllers
{
    public class HomeController : Controller
    {
        IProductServices _prodServices;
        public HomeController(IProductServices prodServices)
        {
            _prodServices = prodServices;
        }

        public ViewResult Index()  => View();       
        
        public ViewResult Products()
        {

            var viewModel = _prodServices.GetProducts();
            return View(viewModel);
        }
    }
}
