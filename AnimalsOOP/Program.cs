using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsOOP
{

    public interface IAnimal 
    {
        void say_hello();
    }
    public class Cat : IAnimal
    {
        public void say_hello()
        {
            Console.WriteLine("Hello, I'm Cat");
        }
    }
    public class Dog : IAnimal
    {
        public void say_hello()
        {
            Console.WriteLine("Hello, I'm Dog");
        }
    }
    
    public class Zoo
    {
        private int animalAmount {get; set;}
        private List<IAnimal> zooAnimals = new List<IAnimal>();
        
        
        
        public void AddAnimal(IAnimal a)
        {
            zooAnimals.Add(a);  
        }
        public void RemoveAnimal(IAnimal a) 
        {
            zooAnimals.Remove(a);
        }

        public void PrintAnimals()
        {
            foreach (IAnimal i in zooAnimals)
            {
                Console.WriteLine(i);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Zoo MyZoo = new Zoo();
            Cat cat = new Cat();
            Dog dog = new Dog();
            MyZoo.AddAnimal(cat);
            MyZoo.AddAnimal(dog);
            MyZoo.PrintAnimals();
            MyZoo.RemoveAnimal(dog);
            
            MyZoo.PrintAnimals();
            Console.ReadKey();
        }
   } 
}
