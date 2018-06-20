using System;
using System.Collections.Generic;
using System.Text;
using fifo_animal_shelter.Classes;
namespace fifo_animal_shelter.Classes
{
    public class AnimalShelter
    {
        public string Name { get; set; }
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public AnimalShelter(Animal datAnimal)
        {
            Name = "Dat Animal Shelter";
            Front = datAnimal;
            Rear = datAnimal;
        }

        //public AnimalShelter(string name)
        //{
        //    Name = name;
        //}

        public bool Enqueue(Animal datAnimal)
        {
            if (!(datAnimal is Dog) && !(datAnimal is Cat))
            {
                Console.WriteLine($"That's a {datAnimal.GetType().Name.ToLower()}!");
                Console.WriteLine("Sorry, we only take cats and dogs! :(");
                return false;
            }
            Rear.Next = datAnimal;
            Rear = datAnimal;
            return true;
        }

        /// <summary>
        /// dequeues the first of the animal entered as "pref", else dequeues any dog or cat at the front
        /// </summary>
        /// <param name="pref">the type of animal to dequeue</param>
        /// <returns>the dequeued animal</returns>
        public Animal Dequeue(string pref)
        {
            string fPref = pref.ToLower();
            string wantedType = Front.GetType().Name.ToLower();

            if ((fPref != "cat" && pref != "dog") || wantedType == fPref)
            {
                Console.WriteLine($"Dequeueing a {Front.GetType().Name.ToLower()}");
                return MiniDQ();
            }

            Animal oldFront = Front;
            while (wantedType != fPref)
            {
                Enqueue(MiniDQ());
                wantedType = Front.GetType().Name.ToLower();
            }

            Console.WriteLine($"Dequeueing a {Front.GetType().Name.ToLower()}");
            Animal tmp1 = MiniDQ();
            
            while (Front != oldFront)
            {
                Enqueue(MiniDQ());
            }

            return tmp1;

            // The regular dequeue method that we're defining for modularity
            Animal MiniDQ()
            {
                Animal tmp = Front;
                Front = Front.Next;
                tmp.Next = null;
                return tmp;
            }
        }
        public void Print()
        {
            // start from the front to print everything going back

            Animal Current = Front;

            Console.Write("Front ---> ");
            while (Current != null)
            {
                if (Current is Dog)
                    Console.Write($"Dog ---> ");

                if (Current is Cat)
                    Console.Write("Cat ---> ");

                Current = Current.Next;
            }
            Console.Write($"Rear");
            Console.WriteLine();
        }
    }
}
