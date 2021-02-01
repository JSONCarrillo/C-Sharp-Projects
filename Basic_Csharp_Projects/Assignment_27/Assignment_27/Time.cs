using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_27
{
        class Time
        {
            public string Name { get; set; }
            public int Year { get; set; }

            public Time(string name, int year)
            {
                Name = name;
                Year = year;
            }
            public Time() : this("Two years ago", 2018)
            {
            }
        }
}
