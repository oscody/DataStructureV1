using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructureV1.Problems.InterviewPrep
{
    public class Group
    {


        public Group(){

            List<Dictionary<string, string>> cities = new List<Dictionary<string, string>>
            {
                new Dictionary<string, string> { { "name", "New York" }, { "country", "USA" } },
                new Dictionary<string, string> { { "name", "Los Angeles" }, { "country", "USA" } },
                new Dictionary<string, string> { { "name", "Toronto" }, { "country", "Canada" } },
                new Dictionary<string, string> { { "name", "Vancouver" }, { "country", "Canada" } },
                new Dictionary<string, string> { { "name", "London" }, { "country", "UK" } }
            };

            Dictionary<string, List<string>> groupedCities = GroupCitiesByCountry(cities);

            foreach (var kvp in groupedCities)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }
        }


        public  Dictionary<string, List<string>> GroupCitiesByCountry(List<Dictionary<string, string>> cities)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            foreach (var city in cities)
            {
                string country = city["country"];
                string name = city["name"];
                
                if (!result.ContainsKey(country))
                {
                    result[country] = new List<string>();
                }
                
                result[country].Add(name);
            }

            return result;
        }
        
    }


}