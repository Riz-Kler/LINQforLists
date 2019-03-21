using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinqLibrary
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();

            output.Add(new Person
            {
       FirstName = "Riz", LastName = "Kler", Birthday = Convert.ToDateTime("25/02/1970"),
                YearsExperience = 10
            });
            output.Add(new Person
            {
                FirstName = "Cindy",
                LastName = "Crawford",
                Birthday = Convert.ToDateTime("20/02/1967"),
                YearsExperience = 36
            });
            output.Add(new Person
            {
                FirstName = "John",
                LastName = "Smith",
                Birthday = Convert.ToDateTime("01/01/2001"),
                YearsExperience = 1
            });
            output.Add(new Person
            {
                FirstName = "Ann",
                LastName = "Smith",
                Birthday = Convert.ToDateTime("12/01/2001"),
                YearsExperience = 10
            });
            output.Add(new Person
            {
                FirstName = "Paul",
                LastName = "Smith",
                Birthday = Convert.ToDateTime("11/11/1987"),
                YearsExperience = 15
            });
            return output;
        }
    }
}
