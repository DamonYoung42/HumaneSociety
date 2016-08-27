using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HumaneSociety
{
    class UserInterface
    {

        public string GetAdopterFirstName()
        {
            string userInput;
            do
            {
                Console.WriteLine("Please enter the adopter's first name:");
                userInput = Console.ReadLine();
            }
            while (String.IsNullOrEmpty(userInput));

            return userInput;

        }

        public string GetAdopterLastName()
        {
            string userInput;
            do
            {
                Console.WriteLine("Please enter the adopter's last name:");
                userInput = Console.ReadLine();
            }
            while (String.IsNullOrEmpty(userInput));

            return userInput;

        }

        public string GetAdopterAddress()
        {
            string userInput;
            do
            {
                Console.WriteLine("Please enter the adopter's address:");
                userInput = Console.ReadLine();
            }
            while (String.IsNullOrEmpty(userInput));

            return userInput;

        }

        public string GetAdopterCity()
        {
            string userInput;
            do
            {
                Console.WriteLine("Please enter the adopter's city:");
                userInput = Console.ReadLine();
            }
            while (String.IsNullOrEmpty(userInput));

            return userInput;

        }

        public string GetAdopterState()
        {
            string userInput;
            do
            {
                Console.WriteLine("Please enter the adopter's state:");
                userInput = Console.ReadLine();
            }
            while (String.IsNullOrEmpty(userInput) || (!Enum.IsDefined(typeof(State), userInput)));

            return userInput;

        }

        public string GetAdopterZipCode()
        {
            string userInput;
            do
            {
                Console.WriteLine("Please enter the adopter's zipcode:");
                userInput = Console.ReadLine();
            }
            while (!IsZipCode(userInput));

            return userInput;

        }

        public string GetAdopterPhoneNumber()
        {
            string userInput;
            do
            {
                Console.WriteLine("Please enter the adopter's phone number:");
                userInput = Console.ReadLine();
            }
            while (String.IsNullOrEmpty(userInput) || (!IsPhoneNumber(userInput)));

            return userInput;

        }

        public bool IsZipCode(string zipCode)
        {
            string pattern = "(^[0-9]{5}$)|(^[0-9]{5}-[0-9]{4}$)";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(zipCode);
        }

        public bool IsPhoneNumber(string phoneNumber)
        {
            string pattern = "(^[0-9]{10}$)|(^[0-9]{3}-[0-9]{3}-[0-9]{4}$)";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(phoneNumber);
        }

        public enum State
        {
            AL,            AK,            AS,            AZ,            AR,            CA,            CO,            CT,            DE,
            DC,            FM,            FL,            GA,            GU,            HI,            ID,            IL,            IN,
            IA,            KS,            KY,            LA,            ME,            MH,            MD,            MA,            MI,
            MN,            MS,            MO,            MT,            NE,            NV,            NH,            NJ,            NM,
            NY,            NC,            ND,            MP,            OH,            OK,            OR,            PW,            PA,
            PR,            RI,            SC,            SD,            TN,            TX,            UT,            VT,            VI,
            VA,            WA,            WV,            WI,            WY
        }

        public enum AnimalType
        {
            dog, cat, bird, reptile
        }

        public Animal GetAnimalType()
        {
            string userInput;
            do
            {
                Console.WriteLine("What type of animal do you want to add - Dog or Cat?");
                userInput = Console.ReadLine();
            }
            while ((!String.IsNullOrEmpty(userInput)) && (!Enum.IsDefined(typeof(AnimalType), userInput.ToLower())));

            if (userInput == "dog")
            {
                return new Dog();
            }
            else
            {

                return new Cat();
            }

        }
        public string GetAnimalName()
        {
            string userInput;
            do
            {
                Console.WriteLine("Please enter the animal's name:");
                userInput = Console.ReadLine();
            }
            while (String.IsNullOrEmpty(userInput));

            return userInput;
        }

        public bool GetAnimalHasShots()
        {
            string userInput;
            do
            {
                Console.WriteLine("Has this animal received its shots (Y/N)? If unknown, press Enter:");
                userInput = Console.ReadLine();
            }
            while ((userInput.ToLower() != "y") && (userInput.ToLower() != "n") && (userInput != ""));

            if (userInput.ToLower() == "y")
                return true;
            else
                return false;
        }

        public int GetAnimalCageNumber()
        {
            int userInput;
            do
            {
                Console.WriteLine("In what cage number will this animal be placed? If unknown, press Enter:");
            }
            while (!int.TryParse(Console.ReadLine(), out userInput) && (userInput < 0));

            return userInput;
        }

        public int GetAnimalFoodAmount()
        {
            int userInput;

            do
            {
                Console.WriteLine("How much food (in cups) does this animal require daily? If unknown, press Enter:");
            }
            while (!int.TryParse(Console.ReadLine(), out userInput) && (userInput < 0));

            return userInput;
        }
    
        public double GetAnimalPriceToAdopt()
        {
            double userInput;

            do
            {
                Console.WriteLine("What is the adoption fee for this animal? If unknown, press Enter:");
            }
            while (!double.TryParse(Console.ReadLine(), out userInput) && (userInput < 0));

            return userInput;
        }

    }
}
