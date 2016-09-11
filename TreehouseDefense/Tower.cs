using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private static readonly System.Random _random = new System.Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);

                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader!");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Shot at and misssed an invader.");
                    }
                    break;
                    
                }
            }
        }
    }
}
