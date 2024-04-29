using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreContrller.Controllers
{
    public class QueryController : Controller
    {
        //Query string   model binding
        [Route("/Student")]
        public IActionResult Student(int sid,string sname)
        {
            return Content($"Student id is: {sid} & Student name is: {sname}","text/plain");
        }
    }
}
