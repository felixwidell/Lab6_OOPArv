using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOPArv
{
    internal class Oranda : Goldfish
    {
        private string _funFact;

        public string FunFact { get => _funFact = "the Oranda goldfish are one of the faster goldfish types"; }
        public Oranda()
        {
            MemoryLength = 9;
            AmountOfLegs = 0;
            Habitat = "Water";
            Dead = false;
            Name = "Goldfish Oranda";
            Weight = 4;
            Speed = 10;
        }

        internal void MakeSound()
        {
            Console.WriteLine("Blub blub blub");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("The " + Name + " has " + AmountOfLegs + " legs, it lives in " + Habitat + " and weighs " + Weight + "Kg," + FunFact);
        }
    }
}
