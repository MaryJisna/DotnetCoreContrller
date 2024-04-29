using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreContrller.Controllers
{
    public class FileController : Controller
    {
        [Route("File/Downld_file")]
        public VirtualFileResult FileDownld()// view pdf inside wwwroot in our prjt 
        {
            return File("Samples/Mary Jisna_Resume.pdf", "application/pdf");
        }
        [Route("File/Downld_file2")]//file outside the prjt

        public PhysicalFileResult FileDownld2()
        {
            //return new PhysicalFileResult("C:\\Users\\tharu\\Downloads\\Mary Jisna_Resume.pdf", "application/pdf");
            return PhysicalFile("C:\\Users\\tharu\\Downloads\\Mary Jisna_Resume.pdf", "application/pdf");

        }
    }
}
