using System;
using Xunit;
using fifo_animal_shelter;
using fifo_animal_shelter.Classes;
using static fifo_animal_shelter.Program;

namespace XUnitTestFifo_Animal_Shelter
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueOnlyCatsAndDogs()
        {
            Cat testCat1 = new Cat("Cat 1");
            Cat testCat2 = new Cat("Cat 2");
            Cat testCat3 = new Cat("Cat 3");
            Cat testCat4 = new Cat("Cat 4");
            Dog testDog1 = new Dog("Dog 1");
            Dog testDog2 = new Dog("Dog 2");
            Dog testDog3 = new Dog("Dog 3");

            AnimalShelter testShelter = new AnimalShelter(testCat1);

            Assert.True(testShelter.Enqueue(testCat2));
            Assert.True(testShelter.Enqueue(testCat3));
            Assert.True(testShelter.Enqueue(testDog1));

            Fish testFish1 = new Fish();
            Fish testFish2 = new Fish();
            Bird testBird1 = new Bird();

            Assert.False(testShelter.Enqueue(testFish1));
            Assert.False(testShelter.Enqueue(testBird1));
            Assert.False(testShelter.Enqueue(testFish2));
        }

        [Fact]
        public void CanDequeueProperly()
        {
            Cat testCat1 = new Cat("Cat 1");
            Cat testCat2 = new Cat("Cat 2");
            Cat testCat3 = new Cat("Cat 3");
            Cat testCat4 = new Cat("Cat 4");
            Dog testDog1 = new Dog("Dog 1");
            Dog testDog2 = new Dog("Dog 2");
            Dog testDog3 = new Dog("Dog 3");

            AnimalShelter testShelter = new AnimalShelter(testCat1);

            testShelter.Enqueue(testCat2);
            testShelter.Enqueue(testCat3);
            testShelter.Enqueue(testDog1);
            testShelter.Enqueue(testCat4);
            testShelter.Enqueue(testDog2);

            Assert.Equal(testShelter.Front.GetType().Name.ToLower(), testShelter.Dequeue("unicorn").GetType().Name.ToLower());
            Assert.Equal("dog", testShelter.Dequeue("DOG").GetType().Name.ToLower());
            Assert.Equal("cat", testShelter.Dequeue("cAt").GetType().Name.ToLower());
            Assert.Equal("dog", testShelter.Dequeue("DoG").GetType().Name.ToLower());
            Assert.Equal("cat", testShelter.Dequeue("cAT").GetType().Name.ToLower());
            Assert.Equal("cat", testShelter.Dequeue("cAt").GetType().Name.ToLower());
        }
    }
}
