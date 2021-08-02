using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        // https://localhost:44319/appointment
        public IActionResult Index()
        {
            return View();
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(todaysDate);          

        }
        // https://localhost:44319/appointment/details/id
        public IActionResult Details(int id)
        {
            return Ok($"You've entered id: {id}");
        }
    }

}
