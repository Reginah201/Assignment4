using System;

namespace Assignment4
{
    public class Program
    {
        // Main method - Entry point of the program
        public static void Main(string[] args)
        {
                //Prompt the user to enter country details
                Console.WriteLine("Enter the country name:");
                string countryName = Console.ReadLine();

                Console.WriteLine("Enter the country code:");
                string countryCode = Console.ReadLine();

                Console.WriteLine("Enter the country leader:");
                string countryLeader = Console.ReadLine();

                Console.WriteLine("Enter the capital city:");
                string capitalCity = Console.ReadLine();

                Console.WriteLine("Enter the official language:");
                string officialLanguage = Console.ReadLine();

                // Creating an instance of the Country class with user input
                Country myCountry = new Country(countryName, countryCode, countryLeader, capitalCity, officialLanguage);

                // Calling methods to make the class function like a real-world object
                myCountry.IntroduceCountry(); // Introduce the country with its details
                Console.WriteLine(); // Adding a line break for better readability
            }
            
        }
    }


               

