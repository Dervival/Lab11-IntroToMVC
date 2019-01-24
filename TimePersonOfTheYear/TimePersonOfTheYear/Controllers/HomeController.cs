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
        public IActionResult Index()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");
            string[] allPeople = System.IO.File.ReadAllLines(path);
            List<TimePerson> allTimePeople = ConvertCSVToTimePersonList(allPeople);
            //allPeople = System.IO.File.ReadAllLines("../../../../../personOfTheYear.csv");
            return View(allTimePeople);
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
                timePerson.BirthYear = Convert.ToInt32(splitCsv[4]);
                timePerson.DeathYear = Convert.ToInt32(splitCsv[5]);
                timePerson.Title = splitCsv[6];
                timePerson.Category = splitCsv[7];
                timePerson.Context = splitCsv[8];
                allTimePeople.Add(timePerson);
            }
            return allTimePeople;
        }
    }
}
