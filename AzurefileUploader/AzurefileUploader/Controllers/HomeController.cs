using AzurefileUploader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AzurefileUploader.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Upload()
        {
            var data = IPAddress.Parse("kanban.agilecockpit.com");
            return View();
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
        [HttpPost]
        public async Task<ActionResult> Upload(HttpPostedFileBase file)
        {
            var imageUrl = await new UploaderService().UploadImageAsync(file);
            TempData["LatestPath"] = imageUrl.ToString();
            return RedirectToAction("LatestfilePath");
        }
        public ActionResult LatestFilePath()
        {
            var latestImage = string.Empty;
            if (TempData["LatestPath"] != null)
            {
                ViewBag.LatestImage = Convert.ToString(TempData["LatestPath"]);
            }

            return View();
        }
    }
}