using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDepartmentList.Models;

namespace EmployeeDepartmentList.Controllers
{
    public class HomeController : Controller
    {
        employeedeptdataEntities entities = new employeedeptdataEntities();
        // GET: Home
        public ActionResult Index()
        {
          
            return View(entities.Employees.ToList());

        }

        public ActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index1(int id)
        {
            TempData["a"] = id;
            return RedirectToAction("Display");
        }
        public ActionResult Display()
        {
            int id = Convert.ToInt32(TempData["a"]);
            List<Employee> sid = entities.Employees.Where(x => x.Departmentid == id).ToList();
            return View(sid);
        }
    }
}