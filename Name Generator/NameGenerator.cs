using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator
{
    public class NamesGenerator
    {
        public static string[] firstNames = { "Ashley","Mary","April" };
        public static string[] lastNames = { "Tisdale","Lennon","Star" };

        public static string GenerateName()
        {
            var rand = new Random();
            string randomFirstNames = firstNames[rand.Next(firstNames.Length)];
            string randomLastName = lastNames[rand.Next(lastNames.Length)];

            return $"{randomFirstNames} {randomLastName}";

         
        }

    }
}
