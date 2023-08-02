using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace TestProject_Awais.Controllers
{
    public class LocationController : Controller
    {
        [Dependency]
        public ILocationService locationService { get; set; }
        [HttpGet]
        public JsonResult Getlocation()
        {
            var list = locationService.GetLocation();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetlocationById(int locationId)
        {
            var list = locationService.GetLocationById(locationId);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
       
    }
}