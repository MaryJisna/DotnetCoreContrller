using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreContrller.Controllers
{
    public class StoreController : Controller
    {
        [Route("Category/{Bookid}/{isLogged}")]
        public IActionResult booksqqqqqqqq()
        {
            if (!Request.Query.ContainsKey("Bookid"))
            {
                return BadRequest("Book id not specified");
            }
            int bookid = Convert.ToInt32(Request.Query["Bookid"]);
            if (bookid < 1 || bookid > 1000)
            {
                return NotFound("not range");
            }
            bool log = Convert.ToBoolean(Request.Query["IsLogged"]);
            if (!log)
            {
                //return Unauthorized("you are not logged in !");
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status401Unauthorized);
            }
            //return File("Samples/Mary Jisna_Resume.pdf", "application/pdf");


            return Content($"user Logged={log} bookid={bookid}","text/plain");
            //return RedirectToAction("Category","Book",new {});
        }
    }
}
