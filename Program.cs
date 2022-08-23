using System;

namespace variables_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string catName = "Oreo";
            int catAge = 10;
            char petNumber = '3';
            bool isMyCatFat = true;
            double weightOfCat = 15.25;
            decimal lengthOfCat = 1.5M;
            Console.WriteLine($"My cats name is {catName}, she is {catAge}. She isnt my only pet, I have {petNumber} in total. Is my cat fat? {isMyCatFat}, she weighs {weightOfCat} and is only {lengthOfCat}, but that's okay, we still love her.");

        }
    }
}
