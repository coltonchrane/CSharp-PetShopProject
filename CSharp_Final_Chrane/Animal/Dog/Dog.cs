using System;
using AnimalNamespace;
using IPetNamespace;
namespace DogNamespace
{
    public class Dog : Animal, IPet
    {
        private string breed;
        private string color;

        public Dog()
        {

        }
        public Dog(string dName, string dSkin, int dLegs, string dBreed, string dColor) : base(dName, dSkin, dLegs)
        {
            breed = dBreed;
            color = dColor;
        }
        public void SetPrice()
        {
            Price = 100;
        }
        public string Breed
        {
            set
            {
                breed = value;
            }
            get
            {
                return breed;
            }
        }
        public string Color
        {
            set
            {
                color = value;
            }
            get
            {
                return color;
            }
        }
    }
}
