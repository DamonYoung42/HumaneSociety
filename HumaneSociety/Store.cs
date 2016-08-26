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
        public void AddAdopter()
        {
            Adopter adopter = new Adopter();

            Console.WriteLine("Enter first name:");
            adopter.FirstName = GetAdopterFirstName();
            adopter.LastName = GetAdopterLastName();
            adopter.Address = GetAdopterAddress();
            adopter.City = GetAdopterCity();
            adopter.State = GetAdopterState();
        }
    }
}
