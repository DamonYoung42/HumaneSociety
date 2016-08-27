using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Store
    {
        UserInterface userInput = new UserInterface();
        List<Adopter> adopters = new List<Adopter>();

        public void AddAdopter()

        {
            Adopter adopter = new Adopter();

            adopter.FirstName = userInput.GetAdopterFirstName();
            adopter.LastName = userInput.GetAdopterLastName();
            adopter.Address = userInput.GetAdopterAddress();
            adopter.City = userInput.GetAdopterCity();
            adopter.State = userInput.GetAdopterState();
            adopter.ZipCode = userInput.GetAdopterZipCode();
            adopter.PhoneNumber = userInput.GetAdopterPhoneNumber();

            adopters.Add(adopter);
        }

        public void AddAnimal()
        {
            Animal newAnimal;
            newAnimal = userInput.GetAnimalType();
            newAnimal.Name = userInput.GetAnimalName();
            newAnimal.CageNumber = userInput.GetAnimalCageNumber();
            newAnimal.HasShots = userInput.GetAnimalHasShots();
            newAnimal.PriceToAdopt = userInput.GetAnimalPriceToAdopt();
            newAnimal.AmountOfFood = userInput.GetAnimalFoodAmount();
        }
    }
}
