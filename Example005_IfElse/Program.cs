using System;

namespace Example005_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string username = Console.ReadLine();

            if (username.ToLower() == "маша")
            {
                Console.WriteLine("Ура, это же МАША!");
            }
            else
            {
                Console.Write("Привет, ");
                Console.WriteLine(username);
            }
        }
    }
}
