using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numbers = new int[10];
            Console.Write("сам массив - ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-10, 10);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("Первый пранкич");
            Console.WriteLine("вывод ток положительных и их подсчет");
            byte count = 0;
            foreach (int item in numbers)
            {
                if(item >= 0)
                {
                    Console.Write(item + " ");
                    count++;
                }
            }
            Console.WriteLine("второй пранкич");
            Console.WriteLine("вывод массива наоборот");
            int[] num1 = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                num1[num1.Length - 1 - i] = numbers[i];
            }
            foreach (var item in num1)
            {
                Console.Write(item + " ");
            }
        }
    }
}
