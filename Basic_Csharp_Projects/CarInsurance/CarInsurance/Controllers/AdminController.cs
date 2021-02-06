using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using(InsuranceEntities2 db = new InsuranceEntities2())
            {
                var createusers = db.Insurees;
                var createUserVms = new List<CreateUserVm>();
                foreach (var user in createusers)
                {
                    var createUserVm = new CreateUserVm();
                    createUserVm.Id = user.Id;
                    createUserVm.FirstName = user.FirstName;
                    createUserVm.LastName = user.LastName;
                    createUserVm.EmailAddress = user.EmailAddress;
                    createUserVm.Quote = user.Quote;
                    createUserVms.Add(createUserVm);
                }
                return View(createUserVms);
            }
        }
    }
}