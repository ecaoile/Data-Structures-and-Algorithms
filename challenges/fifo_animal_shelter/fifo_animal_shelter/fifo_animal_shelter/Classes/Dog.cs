using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    public class Dog : Animal
    {
        public string Name { get; set; }
        public Dog()
        {
            Name = "default Dog";
        }
        public Dog(string name)
        {
            Name = name;
        }
    }
}
