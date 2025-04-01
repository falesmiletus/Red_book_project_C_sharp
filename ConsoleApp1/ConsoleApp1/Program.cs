using System.Reflection.Emit;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            againName:
            Console.WriteLine("Write your name.");
            Console.Write("Name - ");
            string name = Console.ReadLine()!;
            if(String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error. Please try again");
                goto againName;
            }
            againAge:
            Console.WriteLine("Write your age.");
            Console.Write("Age - ");
            if (!int.TryParse(Console.ReadLine(),out age))
            {
                Console.WriteLine("Error. Please try again");
                goto againAge;
            }

            Console.WriteLine($"Your name is {name}. Your age is {age}");

        }
    }
}
