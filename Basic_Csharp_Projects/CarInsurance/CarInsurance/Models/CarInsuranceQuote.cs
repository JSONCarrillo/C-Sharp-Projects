
namespace CarInsurance.Models
{
    using System;
    using System.Collections.Generic;

    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateofBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int DUI { get; set; }
        public int SpeedTicket { get; set; }
        public string Coverage { get; set; }
        public double Quote { get; set; }
    }
}