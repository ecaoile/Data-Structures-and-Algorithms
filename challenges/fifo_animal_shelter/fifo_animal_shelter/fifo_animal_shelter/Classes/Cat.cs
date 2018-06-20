﻿using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    public class Cat : Animal
    {
        public string Name { get; set; }
        public Cat()
        {
            Name = "default cat";
        }

        public Cat(string name)
        {
            Name = name;
        }
    }
}
