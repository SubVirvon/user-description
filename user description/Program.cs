using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_description
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int userAge, userGrowth;

            Console.Write("Введите ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш рост: ");
            userGrowth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя " + userName + ", вам " + userAge + ", у вас огромный рост, который состовляет " + userGrowth + " см, и прекрасное телосложение.");
            Console.ReadKey();
        }
    }
}
