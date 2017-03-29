using System;

namespace InformaFizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICalculation calculation = new Calculation();

            for (var i = 1; i <= 20; i++)
            {
                Console.WriteLine(calculation.DisplayNumber(i));
            }
        }
    }
}