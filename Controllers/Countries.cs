using Microsoft.AspNetCore.Mvc;

using UdayChinhamoraWebsite.Models;

namespace UdayChinhamoraWebsite.Controllers
{
    public class Countries : Controller
    {
        private readonly ILogger<Countries> _logger;

        public Countries(ILogger<Countries> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    



        public ActionResult County()//We'll set the ViewBag values in this action
        {
            ViewBag.Title = "Put your page title here";
            ViewBag.Description = "Put your page description here";

            ViewBag.UserNow = new User()
            {
                Name = "Your Name",
                ID = 4,
            };

            return View();
        }
    }
}
