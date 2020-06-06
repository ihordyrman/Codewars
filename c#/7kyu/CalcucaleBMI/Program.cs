using System;

namespace CalcucaleBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bmi(90, 1.94));
        }

        private static string Bmi(double weight, double height)
        {
            var bmi = weight / (height * height);
            if (bmi <= 18.5)
            {
                return "Underweight";
            }

            if (bmi <= 25.0)
            {
                return "Normal";
            }

            if (bmi <= 30)
            {
                return "Overweight";
            }

            return "Obese";
        }
    }
}
