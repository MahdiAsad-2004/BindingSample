using BindingSample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BindingSample.Controllers
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



        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Result(Product? product , Property? prop)
        {
            var productString = product != null ? product.ToString() : "Null";
            var propertyString = prop != null ? prop.ToString() : "NUlll";
            Console.WriteLine($"Product: {productString}");
            Console.WriteLine($"Property: {propertyString}");
            Console.WriteLine("-------------------------------------------------------------------------------");
            return Json(product);
        }



        public IActionResult Editor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditorResult(string content)
        {
            return Json(content);
        }






        public IActionResult CreateDic() 
        {
            return View();
        }

        public IActionResult CreateDicResult(Product pr)
        {
            return Json(pr);
        }





        public IActionResult CreateCategory()
        {
            return View();
        }

        public IActionResult CreateCategoryResult(Category category)
        {
            return Json(category);
        }





        [HttpPost]
        public IActionResult Create(Product product)
        {
            return Json(product);
        }




        
        public IActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Test(List<int> numbers)
        {
            return Content(numbers.Sum().ToString());
            return Json(numbers);
        }


    }
}
