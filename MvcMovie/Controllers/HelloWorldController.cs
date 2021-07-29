using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        //public string Index()
        public IActionResult Index()
        {
            //return "This is my default action...";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        //public string Welcome(string name, int iD = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {iD}");
        //}

        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["Numtimes"] = numTimes;

            return View();
        }
    }
}