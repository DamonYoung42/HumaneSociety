using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HumaneSociety;
 

namespace HumaneSocietyTest
{
    [TestClass]
    public class HumaneSocietyTest
    {
        [TestMethod]
        public void CreateAnimal()
        {
            //Arrange
            Dog dog = new Dog();

            //Act
            dog.CreateAnimal("Max");

            //Assert
            

        }
    }
}
