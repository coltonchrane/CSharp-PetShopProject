using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNamespace
{
    public  abstract class Animal
    {
        private int legs;
        private string skinType;
        private string name;
        private double price;
        public Animal()
        {

        }
        public Animal(string n, string s, int l)
        {
            legs = l;
            name = n;
            skinType = s;
        }

        public int Legs
        {
            set
            {
                legs = value;
            }
            get
            {
                return legs;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string SkinType
        {
            set
            {
                skinType = value;
            }
            get
            {
                return skinType;
            }
        }
        public double Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
    }
}
