using ChartJs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartJs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<ChartOutput>();
            model.Add(new ChartOutput { Name = "فروردین", Value = 12, Color = "red" });
            model.Add(new ChartOutput { Name = "اردیبهشت", Value = 30, Color = "green" });
            model.Add(new ChartOutput { Name = "خرداد", Value = 25, Color = "blue" });
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}