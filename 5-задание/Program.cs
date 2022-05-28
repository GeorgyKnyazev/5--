using System;

namespace _5_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Имя";
            string surName = "Фамилия";
            Console.WriteLine(firstName + " " + surName);
            (firstName, surName) = (surName, firstName);
            Console.WriteLine(firstName + " " + surName);
        }
    }
}
