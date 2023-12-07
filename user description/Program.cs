using System;

namespace user_description
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int growth;

            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш рост: ");
            growth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя " + name + ", вам " + age + ", у вас огромный рост: " + growth + " см и прекрасное телосложение.");
            Console.ReadKey();
        }
    }
}
