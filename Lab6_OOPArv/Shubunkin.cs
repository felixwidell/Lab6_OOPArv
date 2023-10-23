using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOPArv
{
    internal class Shubunkin : Goldfish
    {
        private string _placeOfOrigin;

        public string PlaceOfOrigin { get => _placeOfOrigin; set => _placeOfOrigin = value; }

        public Shubunkin()
        {
            PlaceOfOrigin = "Japan";
            MemoryLength = 6;
            AmountOfLegs = 0;
            Habitat = "Water";
            Dead = false;
            Name = "Goldfish Shubunkin";
            Weight = 4;
            Speed = 4;
        }

        internal void MakeSound()
        {
            Console.WriteLine("Blub blub");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("The " + Name + " has " + AmountOfLegs + " legs, it lives in " + Habitat + " and weighs " + Weight + "Kg, it's place of origin is " + PlaceOfOrigin );
        }
    }
}
