using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Web.Hosting;


namespace IIProjectClient.Controllers
{
    public class IIController : Controller
    {
        // GET: II
        XElement testXML;
        string appDataFolder = HostingEnvironment.MapPath("/App_Data/");

        public IIController()
        {
            testXML = XElement.Load(appDataFolder + "Test.xml");
        }
        public ActionResult Index()
        {
            return View(testXML);
        }

        public ActionResult Test()
        {
            return View(testXML);
        }

    }
}