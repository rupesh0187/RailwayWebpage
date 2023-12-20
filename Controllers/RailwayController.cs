using Microsoft.AspNetCore.Mvc;
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
            var st = context.tos.Where(e => e.From.FId == id).ToList();
            return new JsonResult(st);
        }
        public JsonResult TrainName(int? id)
        {
            var ct = context.trainnames.Where(e => e.To.TId == id).ToList();
            return new JsonResult(ct);
        }
        public JsonResult TClass(int? id)
        {
            var ct = context.tclasses.Where(e => e.TrainName.TNId == id).ToList();
            return new JsonResult(ct);
        }
        public JsonResult TPrice(int? id)
        {
            var ct = context.tprices.Where(e => e.TClass.CId == id).ToList();
            return new JsonResult(ct);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult LoginPage()
        {
            return View();
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
