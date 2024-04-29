using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.Net.Cache;

namespace DotnetCoreContrller.Controllers
{
    //[Controller]  artribute can use when remove the HomeController to Home
    //public class HomeController // only specify Home when using [Controller]  artribute
    public class HomeController:Controller
    {
        [Route("Home")]
        [Route("/")] //route url
        public ContentResult Index()// WE can use return type as contentResult
        {
            return Content("<h1>Welcome ASP.net core application<h1>", "text/html");

            //return new ContentResult()
            //{
            //    Content = "<h1>Welcome ASP.net core application<h1>",
            //    ContentType = "text/html"

            //};
            // return "Welcome ASP.net core application";

        }
        [Route("About")]

        public string About()
        {
            return "Welcome About";

        }
        [Route("Contact")]

        public string Contact()
        {
            return "Welcome   Contact";

        }
        [Route("Product/{id:min(1000):max(9999)}")]  //url- /Product/4444
        public string Product()
        {
            return "Product page";
        }
        //[Route("/Employee/John")]
        //public string Employee()
        //{
        //    Employee emp = new Employee() { ID = 101, Name = "John", Salary = 100000, Age = 28 };
        //    return Json(emp);
        //}
    }
}
