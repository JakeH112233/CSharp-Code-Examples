using System;

namespace CSharp_Code_Examples
{
    class PersonOOP
    {
        //Authors: Jake Harper
        //Demonstrates basic OOP with a Person class in C#

        public static void run()
        {
            Person person1 = new Person("Alice", 28);
            Person person2 = new Person("Bob", 32);

            person1.Greet();
            person2.Greet();

            Console.WriteLine($"{person1.Name} will be {person1.Age + 1} next year");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
       
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old");
        }
    }
}
