using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreContrller.Model
{
    public class Student
    {
        [FromQuery]       //then it access query string value in the url
        public int? sid { get; set; }
        [FromRoute] //then it access Route string value in the url
        public string? sname { get; set; }


        //url :
    }
}
