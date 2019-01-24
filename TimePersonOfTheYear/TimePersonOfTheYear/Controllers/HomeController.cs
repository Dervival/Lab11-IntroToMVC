using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimePersonOfTheYear.Models;

namespace TimePersonOfTheYear.Controllers
{
    public class HomeController : Controller
    {
        private static readonly string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");
        public IActionResult Index()
        {
            //allPeople = System.IO.File.ReadAllLines("../../../../../personOfTheYear.csv");
            return View();
        }

        [HttpPost]
        //parameters must match the asp-for tag names
        public IActionResult Index(int startYear, int endYear)
        {
            return RedirectToAction("Results", new { startYear, endYear });
        }

        public IActionResult Results(int startYear, int endYear)
        {
            if (startYear <= endYear && startYear > 1926 && endYear < 2017)
            {
                string[] allPeople = System.IO.File.ReadAllLines(path);
                List<TimePerson> allTimePeople = ConvertCSVToTimePersonList(allPeople);
                var filterQuery = from people in allTimePeople
                                     where people.Year >= startYear && people.Year <= endYear
                                     select people;
                List<TimePerson> filteredPeople = new List<TimePerson>();
                foreach(TimePerson person in filterQuery)
                {
                    filteredPeople.Add(person);
                }
                return View(filteredPeople);
            }
            return RedirectToAction("Index");
        }

        public List<TimePerson> ConvertCSVToTimePersonList(string[] csv)
        {
            List<TimePerson> allTimePeople = new List<TimePerson>();
            for(int i = 1; i < csv.Length; i++)
            {
                TimePerson timePerson = new TimePerson();
                string[] splitCsv = csv[i].Split(',');
                timePerson.Year = Convert.ToInt32(splitCsv[0]);
                timePerson.Honor = splitCsv[1];
                timePerson.Name = splitCsv[2];
                timePerson.Country = splitCsv[3];
                if(Int32.TryParse(splitCsv[4], out int birthYear))
                {
                    timePerson.BirthYear = birthYear;
                }
                else
                {
                    timePerson.BirthYear = -1;
                }
                if (Int32.TryParse(splitCsv[5], out int deathYear))
                {
                    timePerson.DeathYear = deathYear;
                }
                else
                {
                    timePerson.DeathYear = -1;
                }
                timePerson.Title = splitCsv[6];
                timePerson.Category = splitCsv[7];
                timePerson.Context = splitCsv[8];
                allTimePeople.Add(timePerson);
            }
            return allTimePeople;
        }
    }
}
