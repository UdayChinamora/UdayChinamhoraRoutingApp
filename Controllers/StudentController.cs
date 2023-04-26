using Microsoft.AspNetCore.Mvc;



using UdayChinhamoraWebsite.Models;


namespace UdayChinhamoraWebsite.Controllers
{
    public class StudentController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
        // GET: Student/Details/5
        public IActionResult Details(int accessLevel)
        {
            return View();
        }

        // GET: Student/Create
        public IActionResult Create()
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

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
               

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}