using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOPArv
{
    internal class Eagle : Animal
    {
        private bool _isFlying;

        public bool IsFlying { get => _isFlying; set => _isFlying = value; }
        public Eagle()
        {
            _isFlying = true;
            AmountOfLegs = 2;
            Habitat = "Forests";
            Dead = false;
            Name = "Eagle";
            Weight = 14;
            Speed = 300;
        }
        internal void MakeSound()
        {
            Console.WriteLine("Skreee");
        }

        public void IsItFlying()
        {
            if(IsFlying)
            {
                Console.WriteLine("The " + Name + " is currently soaring the skies");
            }
            else
            {
                Console.WriteLine("The " + Name + " is relaxing on the ground.");
            }
        }
    }
}
