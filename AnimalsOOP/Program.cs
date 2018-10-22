using System;

namespace AnimalsOOP
{
    public interface Animal
    {
        void say_hello();
    }
    public class Cat : Animal
    {
        public void say_hello()
        {
            Console.WriteLine("Hello, I'm Cat");
        }
    }
    public class Dog : Animal
    {
        public void say_hello()
        {
            Console.WriteLine("Hello, I'm Dog");
        }
    }
    public class Pig : Animal
    {
        public void say_hello()
        {
            Console.WriteLine("Hello, I'm Pig");
        }
    }
    public class Chicken : Animal
	{
	public void say_hello()
	{
		Console.WriteLine("Hello, I'm Chicken");
	}
	}
    
    public class Zoo
    {
        private int animalAmount = 0;
	private Animal[] zooAnimals = new Animal[100];
        public int GetAmount()
        {
            return animalAmount;
        }
        public bool AddAnimal()
	{	
		
        }
    	public bool RemoveAnimal()
	{

	}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zooAnimals = new Animal[100];
            zooAnimals[0] = new Cat();
            zooAnimals[1] = new Dog();
            zooAnimals[0].say_hello();
            zooAnimals[1].say_hello();
            Console.ReadKey();
        }
    }
}
