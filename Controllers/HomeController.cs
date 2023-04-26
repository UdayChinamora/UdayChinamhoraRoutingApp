using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

using UdayChinhamoraWebsite.Models;

namespace UdayChinhamoraWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
   
        public IActionResult Privacy()
        {
            return View();
        }


        [Route("/displayCountries")]
        public IActionResult displayCountries()
        {
            ViewBag.Title = "Put your page title here";
            ViewBag.Description = "Put your page description here";

            ViewBag.UserNow = new User()
            {
                Name = "Your Name",
                ID = 4,
              
            };

            return View("/Views/Home/displayCountries.cshtml");
        }

        public IActionResult About()
        {
            return View();
        }

        [Route("/Contact")]
        public IActionResult Contact()
        {
            return View("/Views/Home/Contact.cshtml");

        }


        [Route("/tickets")]
        public IActionResult tickets()
        {
            return View("/Views/Home/tickets.cshtml");

        }



        public IActionResult Admin()
        {
            return View();
        }


        public IActionResult Student(int accessLevel)
        {
            ViewBag.AccessLevel = accessLevel;
            var student1 = new StudentViewModel
            {
                FirstName = "Carl",
                LastName = "Phillips",
                Grade = "A"
            };
            var student2 = new StudentViewModel
            {
                FirstName = "Liam",
                LastName = "Clark",
                Grade = "B"
            };
            var student3 = new StudentViewModel
            {
                FirstName = "Mark",
                LastName = "Mickelson",
                Grade = "B"
            };
            var student4 = new StudentViewModel
            {
                FirstName = "Harry",
                LastName = "Potter",
                Grade = "A"
            };

            List<StudentViewModel> students = new List<StudentViewModel>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            return View(students);
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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}