using FarmSystem.Test2;
using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {

        public Queue<Animal> Animals { get; set; } = new Queue<Animal>();

        public event EventHandler FarmEmpty;

        protected virtual void OnFarmEmpty(EventArgs e)
        {
            FarmEmpty?.Invoke(this, e);
        }

        //TEST 1
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 

            //Hold all the animals so it is available for future activities
            Animals.Enqueue(animal);

            Console.WriteLine($"{animal.GetType().Name} has entered the Emydex farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            foreach (var animal in Animals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (var animal in Animals)
            {
                if (animal is IMilkableAnimal milkableAnimal)
                {
                    milkableAnimal.ProduceMilk();
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            while (Animals.Count > 0)
            {
                var animal = Animals.Dequeue();
                Console.WriteLine($"{animal.GetType().Name} has left the farm");
            }

            OnFarmEmpty(EventArgs.Empty);
        }
    }
}