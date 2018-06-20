using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    public abstract class Animal
    {
        // Every node is going to be a type of node
        // think of those Russian dolls...
        public Animal Next { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// constructor for node, needs to have an int to be created
        /// </summary>
        /// <param name="value">int value for the node to create</param>
        public Animal()
        {

        }

        public Animal(string name)
        {
            Name = name;
        }
    }
}
