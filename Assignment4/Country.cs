using System;

namespace Assignment4
{
    class Country
    {
        // Private member variables
        private string countryName;
        private string countryCode;
        private string countryLeader;
        private string capitalCity;
        private string officialLanguage;

        // Constructor to initialize the country
        public Country(string name, string code, string leader, string capital, string language)
        {
            countryName = name;
            countryCode = code;
            countryLeader = leader;
            capitalCity = capital;
            officialLanguage = language;
        }

        // Private method to display the leader of the country
        private void DisplayLeader()
        {
            Console.WriteLine($"The leader of the country {countryName} is {countryLeader}.");
        }

        // Public method to introduce the country
        public void IntroduceCountry()
        {
            Console.WriteLine($"Welcome to {countryName}! ({countryCode})");
            Console.WriteLine($"The capital city of {countryName} is {capitalCity}.");
            Console.WriteLine($"The official language in {countryName} is {officialLanguage}.");
            DisplayLeader(); // Calling private method within the class
        }
    }
}
