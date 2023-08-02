using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Unity;

namespace TestProject_Awais.Controllers
{
    public class EmployeeController : Controller
    {
        [Dependency]
        public IEmployeeService employeeService { get; set; }

        public ActionResult Index()
        {
            return View("Index");
        }
        public JsonResult GetEmployees()
        {
            var list = employeeService.GetEmployees();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult CreateEmployee()
        {
            return View("CreateEmployee");
        }
        [HttpPost]
        public JsonResult SaveEmployee(EmployeeModel employee)
        {
            employeeService.CreateEmployee(employee);
            return Json("Success");
        }
        public ActionResult EditEmployee(int? id = null)
        {
            if (id != null)
            {
                var emp = employeeService.GetEmployeeById(id.Value);
                if (emp == null)
                {
                    return null;
                }
                ViewBag.InitialData = emp;
                return View("EditEmployee");
            }
            else
                return View("Index");
        }

        [HttpPost]
        public JsonResult UpdateEmployee(EmployeeModel employee)
        {
            employeeService.UpdateEmployee(employee);
            return Json("Success");
        }
        public ActionResult DeleteEmployee(int? id = null)
        {
            employeeService.DeleteEmployee(id.Value);
            return View("Index");
        }
    }
}