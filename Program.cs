using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;


namespace MyProjects
{    
    
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.Write("Please, Enter a number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please, Enter a number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}! = {1}", number1, Mathematic.Factorial(number1));
            Console.WriteLine("OKEK({0},{1}) = {2}", number1, number2, Mathematic.OKEK(number1, number2));
            Console.WriteLine("OBEB({0},{1}) = {2}", number1, number2, Mathematic.OBEB(number1, number2));
            /*int[] primeNumbers = Mathematic.PrimeNumbers(number1);
            for(int i = 0; i < primeNumbers.Length; i ++)
            {
                Console.Write("{0} ",primeNumbers[i]);
            */

            GetData.CitizenData();
        }
    }
}
