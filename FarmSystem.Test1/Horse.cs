using System;

namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        private int _noOfLegs;


        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }
        

        public override void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}