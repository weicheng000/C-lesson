using System;
using System.Collections.Generic;

namespace csDemo
{
    class Animal
    {
        protected string name;

        public Animal()
        {
            name = "動物";
        }

        public Animal(string s)
        {
            name = s;
        }

        public void Speak()
        {
            Console.WriteLine("哈囉~ 我是{0}....", name);
        }
    }

    class Elephant : Animal
    {
        public Elephant()
        {
            name = "大象";
        }
    }

    class Mouse : Animal
    {
        public Mouse()
        {
            name = "老鼠";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Animal(),
                new Elephant(),
                new Mouse()
            };
            foreach (var animal in animals)
            {
                animal.Speak();
            }
        }
    }
}
