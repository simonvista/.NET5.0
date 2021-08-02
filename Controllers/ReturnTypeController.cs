
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ReturnTypeController : Controller
    {       
        /* status code results */
        public IActionResult OkResult()
        {
            // status 200
            return Ok("status 200");
        }
        public IActionResult CreatedResult()
        {
            // status 201
            return Created("http://test.com/myitem",new { name="newitem" });
        }
        public IActionResult NoContentResult()
        {
            // "status 204" -> no content to send for this request, but the headers may be useful.
            return NoContent();
        }
        public IActionResult BadRequestResult()
        {
            // "status 400"
            return BadRequest();
        }
        public IActionResult UnauthorizedResult()
        {
            // "status 401"
            return Unauthorized();
        }
        public IActionResult NotFoundResult()
        {
            // "status 404"
            return NotFound();
        }
        public IActionResult UnsupportedMediaTypeResultResult()
        {
            // "status 415"
            return new UnsupportedMediaTypeResult();
        }

        /* status code w/ obj result */
        public IActionResult OkObjectResult()
        {
            // status 200
            var res = new OkObjectResult(
                new { message = "200 OK", currentDate = DateTime.Now }
            );
            return res;
        }
        public IActionResult CreatedAtActionResult()
        {
            // status 201
            var res = new CreatedAtActionResult(
                "action name",
                "controller name",
                "",
                new {message="201created",currentDate=DateTime.Now}
            );
            return res;
        }
        public IActionResult BadRequestObjectResult()
        {
            // status 400
            var res = new BadRequestObjectResult(
                new {message="400 bad request",currentDate=DateTime.Now}
            );
            return res;
        }
        public IActionResult NotFoundObjectResult()
        {
            // status 404
            var res = new NotFoundObjectResult(
                new {message="404",curDate=DateTime.Now}
            );
            return res;
        }

        /* redirect result */
        public IActionResult RedirectResult()
        {
            // redirect to new URL w/ permanent 301 property is set to false
            return Redirect("https://www.google.com");
        }
        public IActionResult LocalRedirectResult()
        {
            return LocalRedirect("/redirect-dir/target");
        }
        public IActionResult RedirectToActionResult()
        {
            return RedirectToAction("myAction", "myController");
        }

        /* file result */
        public IActionResult FileResult()
        {
            return File("~/downloads/test.pdf", "application/pdf");
        }
        public IActionResult FileContentResult()
        {
            var pdfBytes = System.IO.File.ReadAllBytes(
                "wwwroot/downloads/test.pdf"
            );
            return new FileContentResult(pdfBytes, "application/pdf");
        }
        public IActionResult VirtualFileResult()
        {
            return new VirtualFileResult(
                "/downloads/test.pdf", "application/pdf"
            );
        }

        /* content result */
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PartialViewResult()
        {
            return PartialView();
        }
        public IActionResult JsonResult()
        {
            return Json(
                new { message = "Json result: ", date = DateTime.Now }
            );
        }
        public IActionResult ContentResult()
        {
            // return string rather than view
            return Content("ContentResult msg");
        }
    }
}
