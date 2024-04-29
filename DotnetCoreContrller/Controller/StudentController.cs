using Microsoft.AspNetCore.Mvc;
using DotnetCoreContrller.Model;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace DotnetCoreContrller.Controllers
{
    public class StudentController : Controller
    {
        //and Route parameter binding
        [Route("/Studentnew/{sid}/{sname}")]
        public IActionResult Studentnew(Student stud)
        {
            if (stud.sid.HasValue == false)
            {
                return Content("specify", "text/plain");

            }
            return Content($"Student id is: {stud.sid} & Student name is: {stud.sname}", "text/plain");
        }
    }
}
