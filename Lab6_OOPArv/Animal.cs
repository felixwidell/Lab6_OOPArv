using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOPArv
{
    internal class Animal
    {
        private int _amountOfLegs;
        private string _habitat;
        private bool _dead;
        private string _name;
        private double _weight;
        private int _speed;
         
        public int AmountOfLegs {  get =>  _amountOfLegs; set => _amountOfLegs = value; }

        public string Habitat { get => _habitat; set => _habitat = value; }

        public bool Dead { get => _dead; set => _dead = value; }

        public string Name { get => _name; set => _name = value; }

        public double Weight { get => _weight; set => _weight = value; }

        public int Speed { get => _speed; set => _speed = value; }

        public void IsItDead()
        {
            if (Dead)
            {
                Console.WriteLine("The " + Name + " is dead");
            }
            else
            {
                Console.WriteLine("The " + Name + " is still alive");
            }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("The " + Name + " has " + AmountOfLegs + " legs, it lives in " + Habitat + " and weighs " + Weight + "Kg");
        }

        public void IsFasterThanAverageHuman()
        {
            Console.WriteLine("The " + Name + " has a top speed of " + Speed + "km/h and the average human has a running speed of 20km/h");
        }


    }
}
