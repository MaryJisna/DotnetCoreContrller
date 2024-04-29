using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DotnetCoreContrller.Controllers
{
    public class BookController : Controller
    {
        [Route("/BooksNew")]
        public IActionResult Book()
        
        {
            // return RedirectToAction("Books", "Store", new { });
            int bookid = Convert.ToInt32(Request.Query["Bookid"]);
            bool log = Convert.ToBoolean(Request.Query["IsLogged"]);

            //return new LocalRedirectResult($"/Category/{bookid}/{log}", true);
            return new RedirectResult("https://www.google.com/");

        }
    }
}
