using fifo_animal_shelter.Classes;
using System;

namespace fifo_animal_shelter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FIFOAnimalShelter();
            Console.WriteLine("\nThank you for watching! Press any key to quit.");
            Console.ReadKey();
        }

        public static void FIFOAnimalShelter()
        {
            Cat testCat1 = new Cat("Cat 1");
            Cat testCat2 = new Cat("Cat 2");
            Cat testCat3 = new Cat("Cat 3");
            Cat testCat4 = new Cat("Cat 4");
            Dog testDog1 = new Dog("Dog 1");
            Dog testDog2 = new Dog("Dog 2");

            AnimalShelter testShelter = new AnimalShelter(testCat1);

            testShelter.Enqueue(testCat2);
            testShelter.Enqueue(testCat3);
            testShelter.Enqueue(testDog1);
            testShelter.Enqueue(testCat4);
            testShelter.Enqueue(testDog2);
            testShelter.Print();

            Fish testFish1 = new Fish();
            Bird testBird1 = new Bird();

            Console.WriteLine("\nLet's trying adding a fish and bird and seeing if the shelter changed.");
            testShelter.Enqueue(testFish1);
            testShelter.Enqueue(testBird1);
            testShelter.Print();

            Console.WriteLine("\nLet's try to dequeue a random animal.");
            testShelter.Dequeue("unicorn");
            testShelter.Print();

            Console.WriteLine("\nLet's dequeue a dog.");
            testShelter.Dequeue("DOG");
            testShelter.Print();

            Console.WriteLine("\nWe have 3 cats in the front! Let's dequeue 2 of them.");
            testShelter.Dequeue("CaT");
            testShelter.Dequeue("cAt");
            testShelter.Print();

            Console.WriteLine("\nThere's only one dog left, but let's try to get rid of two dogs.");
            testShelter.Dequeue("DOG");
            testShelter.Print();

            testShelter.Dequeue("DOG");
            testShelter.Print();
        }
    }
}
