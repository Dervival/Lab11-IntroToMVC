using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimePersonOfTheYear.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public static List<TimePerson> GetPersons(List<TimePerson> allTimePeople, int startYear, int endYear)
        {
            var filterQuery = from people in allTimePeople
                              where people.Year >= startYear && people.Year <= endYear
                              select people;
            List<TimePerson> filteredPeople = new List<TimePerson>();
            foreach (TimePerson person in filterQuery)
            {
                filteredPeople.Add(person);
            }
            return filteredPeople;
        }
    }

    
}
