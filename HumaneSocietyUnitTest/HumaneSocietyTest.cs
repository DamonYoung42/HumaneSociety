using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HumaneSociety;
using System.IO;
 

namespace HumaneSocietyTest
{
    [TestClass]
    public class HumaneSocietyTest
    {
        [TestMethod]
        public void GiveAnimalAShot()
        {
            //Arrange
            Dog dog = new Dog("Max");

            //Act
            dog.GiveShot();

            //Assert
            Assert.IsTrue(dog.HasShots);

        }

        public void PayAdoptionFee()
        {
            //Arrange
            Adopter adopter = new Adopter();
            Dog dog = new Dog("Max");
            dog.PriceToAdopt = 125.00;

            //Act
            adopter.PayAdoptionFee(dog.PriceToAdopt);

            //Assert
            Assert.IsTrue(adopter.AmountPaid == dog.PriceToAdopt);

        }

        public void SaveDataToFile()
        {
            //Arrange
            InputOutput data = new InputOutput();
            data.FileName = "HumaneSocietyData.txt";

            //Act
            data.SaveData();


            //Assert
            Assert.IsTrue(File.Exists(data.FileName));


        }
    }
}
