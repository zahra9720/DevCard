using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return PartialView("Footer");
        }
        public PartialViewResult Index1()
        {
            return PartialView("Footer");
        }
        public IActionResult Index3()
        {
            //render partial view in _layout 
            return View("Footer");
        }
        public IActionResult Index4()
        {
            //return Content("<h2>Hello ASP.net Core MVC Students</h2>");
            return Content("<h2>Hello ASP.net Core MVC Students</h2><script>confirm('این سوال من است')</script>", "text/html");
        }
        public EmptyResult Index5()
        {
            //return null;
            return new EmptyResult();
        }
        public FileResult Index6()
        {
            //return File("~/text.txt", "text/html");
            //فایل با قابلیت دانلود
            var fileBytes = System.IO.File.ReadAllBytes("D:\\ASP.NetCore5\\Projects\\DevCard\\DevCard_MVC\\wwwroot\\text.txt");
            const string fileName = "textFile.txt";
            return File(fileBytes, MediaTypeNames.Text.Plain, fileName);
        }
        public JsonResult Index7()
        {
            return Json(new 
            { id = 1,
              name = "zahra",
              family = "jebeli",
              job = "student"
            });
        }
        public JavaScriptResult Index8()
        {
            return new JavaScriptResult("alert('salam salam hamegi salam')");
        }

        public RedirectResult Index9()
        {
            return Redirect("http://www.atriya.com");
        }

        public RedirectToActionResult Index10()
        {
            return RedirectToAction("contact", "Home");
        }
        public IActionResult Index11()
        {
            //return new OkResult();
            //return new NotFoundResult();
            //return new BadRequestResult();
            //return new NoContentResult();
            //return new StatusCodeResult(896);
            //return new StatusCodeResult(510);
            return new UnauthorizedResult();
        }
    }
    public class JavaScriptResult : ContentResult
    {
        public JavaScriptResult(string data)
        {
            Content = data;
            ContentType = "application/javascript";
        }
    }
}
