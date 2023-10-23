using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOPArv
{
    internal class Goldfish : Animal
    {
        private int _memoryLength = 12;

        public int MemoryLength { get => _memoryLength; set => _memoryLength = value; }

        public Goldfish()
        {
            _memoryLength = 8;
            AmountOfLegs = 0;
            Habitat = "Water";
            Dead = false;
            Name = "Goldfish";
            Weight = 4;
            Speed = 4;
        }

        internal void MakeSound()
        {
            Console.WriteLine("Blub");
        }

        public void LengthOfMemory()
        {
            Console.WriteLine("This " + Name + " is able to hold a memory for " + MemoryLength + " seconds");
        }
    }
}
