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
            Console.WriteLine("Thank you for watching! Press any key to quit.");
            Console.ReadKey();
        }

        public static void FIFOAnimalShelter()
        {
            Cat testCat1 = new Cat("Meowth (Cat)");
            Cat testCat2 = new Cat("Meemers (Cat)");
            Cat testCat3 = new Cat();
            Cat testCat4 = new Cat();
            Dog testDog1 = new Dog("Snoopy (Dog)");
            Dog testDog2 = new Dog("Spudgy (Dog)");
            Dog testDog3 = new Dog();

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
            testShelter.Dequeue("dog");
            testShelter.Print();

            Console.WriteLine("\nWe have 3 cats in the front! Let's dequeue 2 of them.");
            testShelter.Dequeue("cat");
            testShelter.Dequeue("cat");
            testShelter.Print();

        }

    }
}
