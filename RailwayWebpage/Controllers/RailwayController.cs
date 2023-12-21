using Microsoft.AspNetCore.Mvc;
using RailwayWebpage.Models.Railway;
using RailwayWebpage.Models.RailwayDbContext;

namespace RailwayWebpage.Controllers
{
    public class RailwayController : Controller
    {
        private readonly RailwayDbContext context;

        public RailwayController(RailwayDbContext context)
        {
            this.context = context;
        }

        //TrainSearch controller
        public JsonResult From()
        {
            var cnt = context.froms.ToList();
            return new JsonResult(cnt);

        }
        public JsonResult To(int? id)
        {
            var t1 = context.tos.Where(e => e.From.Id == id).ToList();
            return new JsonResult(t1);
        }
        
        public JsonResult TrainName(int? id)
        {
            var t2 = context.trainnames.Where(e => e.To.Id == id).ToList();
            return new JsonResult(t2);
        }

        public JsonResult Seat()
        {
            var cnt1 = context.seats.ToList();
            return new JsonResult(cnt1);

        }
        public JsonResult Price(int? id)
        {
            var st1 = context.prices.Where(e => e.Seat.Id == id).ToList();
            return new JsonResult(st1);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HomePage()
        {
            return View();
        }
        
        public IActionResult LoginPage(LoginPage ltd)
        {
            if (ModelState.IsValid)
            {
                context.loginPages?.Add(ltd);
                context.SaveChanges();
                TempData["insert_success"] = "Inserted..";
                //return RedirectToAction("LoginPage", "Railway");
            }
            return View(ltd);


        }

        public IActionResult RegisterPage(RegisterPage std)
        {
            if (ModelState.IsValid)
            {
                context.registerPages?.Add(std);
                context.SaveChanges();
                TempData["insert_success"] = "Inserted..";
                //return RedirectToAction("RegisterPage", "Railway");
            }
            return View(std);
           
        }
            
        public IActionResult SearchTrain()
        {
            
            return View();
        }
        public IActionResult TrainInfo()
        {
            return View();
        }
        public IActionResult Booking()
        {
            return View();
        }
        
        
    }
}
