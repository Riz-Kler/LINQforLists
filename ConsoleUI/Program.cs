
using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            //        people = people.OrderByDescending(x => x.LastName).ThenBy(x => x.YearsExperience).ToList();
            people = people.Where(x => x.YearsExperience > 9 && x.Birthday.Month == 2).OrderByDescending(x => x.YearsExperience).ToList();
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString()}): Experience {person.YearsExperience}");

            }
            int yearsTotal = 0;
            //int yearsTotAL = people.Sum(X => X.YearsExperience);
            yearsTotal = people.Where(x => x.Birthday.Month == 2).Sum(X => X.YearsExperience);

            Console.WriteLine($"The total years experience is { yearsTotal }");
        }
    }
}
