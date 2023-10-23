using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOPArv
{
    internal class Lion : Animal
    {
        private string _color;

        public Lion() 
        {
            _color = "brown";
            AmountOfLegs = 4;
            Habitat = "Grasslands";
            Dead = false;
            Name = "Lion";
            Weight = 80;
            Speed = 70;
        }

        public string Color { get => _color; set => _color = value; }
        public void MakeSound()
        {
            Console.WriteLine("Rawr");
        }

        public void AmountOfWeightOnEachLeg()
        {
            Console.WriteLine("The weight on each leg is " + (Weight / AmountOfLegs).ToString() + "Kg");
        }
    }
}
