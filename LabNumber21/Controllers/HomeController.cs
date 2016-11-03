using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabNumber21.Models;

namespace LabNumber21.Controllers
{
    public class HomeController : Controller
    {
        // GET: Homer
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]

        public ActionResult Registration()
        {
            
            
                return View();

            }
            

           [HttpPost]
        public ViewResult Registration(RegistrationForm registrationForm)

        {
            //TODO:Email Response to the party organizer
            if (ModelState.IsValid)
            {
                return View("Thanks", registrationForm);
            }
            else
            {
                return View();

            }
            
        }

    }
}