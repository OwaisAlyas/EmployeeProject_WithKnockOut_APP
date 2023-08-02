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
    public class DepartmentController : Controller
    {
        [Dependency]
        public IDepartmentService departmentService { get; set; }
        
        [HttpGet]
        public JsonResult GetDepartment()
        {
            var list = departmentService.GetDepartment();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetDepartmentById(int departmentId)
        {
            var list = departmentService.GetDepartmentByID(departmentId);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
       
    }
}