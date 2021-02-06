using System;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(string firstName, string lastName, string emailAddress, DateTime dateofBirth, int carYear, string carMake, string carModel, int dUI, int speedTicket, string coverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateofBirth.ToString()) || string.IsNullOrEmpty(carYear.ToString()) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(dUI.ToString()) || string.IsNullOrEmpty(speedTicket.ToString()) || string.IsNullOrEmpty(coverage))
            {
                return View("~Views/Shared/Error.cshtml");
            }
            else
            {

                using (InsuranceEntities2 db = new InsuranceEntities2())
                {
                    var user = new Insuree();
                    user.FirstName = firstName;
                    user.LastName = lastName;
                    user.EmailAddress = emailAddress;
                    user.DateOfBirth = dateofBirth;
                    user.CarYear = carYear;
                    user.CarMake = carMake;
                    user.CarModel = carModel;
                    user.DUI = dUI;
                    user.SpeedingTickets = speedTicket;
                    user.CoverageType = coverage;
                    user.Quote = (decimal)GenerateQuotes(dateofBirth, carYear, carMake, carModel, dUI, speedTicket, coverage);

                    db.Insurees.Add(user);
                    db.SaveChanges();
                    ViewBag.Message = "Your quote is " + "$" + user.Quote + ".";
                    return View("Success");
                }



            }
        }
        public double GenerateQuotes(DateTime dateofBirth, int carYear, string carMake, string carModel, int dUI, int speedTicket, string coverage)
        {
            double quote = 50;

            DateTime birth = DateTime.Parse(dateofBirth.ToString());
            DateTime today = DateTime.Today;
            TimeSpan years = today - birth;
            double ageInDays = years.TotalDays;
            double daysInYear = 365.2425;
            int age = Convert.ToInt32(ageInDays / daysInYear);

            if (age < 18)
            {
                quote += 100;
            }
            else if (age < 25 || age > 100)
            {
                quote += 25;
            }

            if (carYear < 2000 || carYear > 2015)
            {
                quote += 25;
            }

            if (carMake == "Porsche" || carMake == "porsche" && carModel == "911 Carrera")
            {
                if (carMake == "Porsche" || carMake == "porsche")
                {
                    quote += 25;
                }
                quote += 50;
            }

            if (speedTicket > 0)
            {
                quote += 10 * speedTicket;
            }

            if (dUI > 0)
            {
                quote = Convert.ToDouble(quote * 1.25);
            }

            if (coverage == "full coverage")
            {
                quote = Convert.ToDouble(quote * 1.5);
            }

            return (quote);
        }

    }


}