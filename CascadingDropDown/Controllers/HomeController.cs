using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CascadingDropDown.Models;

namespace CascadingDropDown.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CountryStateent entity = new CountryStateent();
            ViewBag.Countries = new SelectList(GetCountries(), "country_id", "country_name");
            return View();
        }


        public List<tblCountry1> GetCountries()
        {
            CountryStateent entity = new CountryStateent();
            List<tblCountry1> countries = entity.tblCountry1.ToList();
            return countries;
        }

        public ActionResult GetStates(int Cid)
        {
            CountryStateent entity = new CountryStateent();
            List<tblState1> states = entity.tblState1.Where(x => x.country_id == Cid).ToList();
            ViewBag.States = new SelectList(states, "state_id", "state_name");
            return PartialView("DisplayStates");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}