using System.Runtime.InteropServices;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "Cat", "Dog", "Cow", "Bunny" };
            Console.WriteLine("Элементы массива:");
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);  
            }
        }
    }
}
