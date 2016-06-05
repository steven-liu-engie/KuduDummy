using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogStorage.Interfaces;

namespace KuduDummy.Controllers
{
    public class HomeController : Controller
    {
        private IBlobStorageHandler BlobHandler { get; }

        public HomeController(IBlobStorageHandler blobHandler)
        {
            BlobHandler = blobHandler;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            BlobHandler.LogDummyException();
            BlobHandler.LogDummyInfo();

            return View();
        }
    }
}
