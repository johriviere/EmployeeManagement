using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case (int)HttpStatusCode.NotFound :
                    {
                        ViewBag.ErrorMessage = "Sorry, the ressource you requested could not be found";
                        break;
                    }
                default:
                    break;
            }
            return View("NotFound");
        }
    }
}
