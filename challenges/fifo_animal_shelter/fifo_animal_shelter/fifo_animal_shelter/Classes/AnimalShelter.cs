﻿using System;
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
            string frontType = Front.GetType().Name.ToLower();

            if ((fPref != "cat" && fPref != "dog") || frontType == fPref)
            {
                Console.WriteLine($"Dequeueing a {Front.GetType().Name.ToLower()}");
                return Dequeue();
            }

            Animal oldFront = Front;

            // handles a single animal and no match
            if (fPref != frontType && Front == Rear)
            {
                Console.WriteLine($"There's only one animal in the shelter," +
                    $" and it's not a {fPref}.");
                return null;
            }

            while (frontType != fPref)
            {
                Enqueue(Dequeue());
                if (Front == oldFront)
                {
                    Console.WriteLine("That animal cannot be found here.");
                    return null;
                }
                frontType = Front.GetType().Name.ToLower();
            }

            Console.WriteLine($"Dequeueing a {frontType}");
            Animal tmp1 = Dequeue();

            // loop to ensure the shelter is in proper order before returning
            // the desired cat or dog
            while (Front != oldFront)
                Enqueue(Dequeue());

            return tmp1;
        }

        /// <summary>
        /// regular dequeue if there is no preference (stretch goal)
        /// </summary>
        /// <returns>the dequeued animal</returns>
        public Animal Dequeue()
        {
            Animal tmp = Front;
            Front = Front.Next;
            tmp.Next = null;
            return tmp;
        }

        public void Print()
        {
            // start from the front to print everything going back
            Animal Current = Front;

            Console.Write("Front ---> ");
            while (Current != null)
            {
                if (Current is Dog)
                    Console.Write($"{Current.Name} ---> ");

                if (Current is Cat)
                    Console.Write($"{Current.Name} ---> ");

                Current = Current.Next;
            }
            Console.Write($"Rear");
            Console.WriteLine();
        }
    }
}
