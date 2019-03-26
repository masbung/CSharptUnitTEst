using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUnitTest
{
    public class Program
    {
        static void Main(string[] args) {
            //PrintSum();
            //PrintCandies();
            //PrintAge();
            //PermissionToPass(21);

            var stringAGe = String.Empty;

            int age = AskForAge(stringAGe);

            int totalMun = 0;

            for (int i = 1; i < 5; i++) {

                Console.WriteLine("Municipio " + i);
                var input = Console.ReadLine();
                var inputInt = 0;

                Int32.TryParse(input, out inputInt);

                totalMun += inputInt;
            }

            //while (0 < 1) {
            //    var hola = "sdfsdf";
            //}

            //Console.WriteLine("Total: " + totalMun);         


        }

        static void PrintSum() {
            var mathCalculator = new MathCalculator();
            var sum = mathCalculator.Add(3, 5);           
            Console.WriteLine(sum.Value);
        }

        static void PermissionToPass(int permittedAge) {
            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();            

            int ageInt = 0;

            Int32.TryParse(age, out ageInt);

            if (ageInt >= permittedAge) {
                Console.WriteLine("You can enter the library");
            } else {
                Console.WriteLine("You CAN'T enter the library");
            }
        }

        static void PrintCandies() {
            decimal candies = 865;
            decimal bigBagCapacity = 25;
            decimal smallBagCapacity = 10;

            decimal firstDivision = 0.00m;

            firstDivision = candies / bigBagCapacity;

            var totalBigBags = Math.Truncate(firstDivision);
            Console.WriteLine("Total big bags: " + totalBigBags);

            //var remainCandies = candies - (totalBigBags * bigBagCapacity);
            //Console.WriteLine("Remain candies: " + remainCandies);

            var remainCandies = candies % bigBagCapacity;
            Console.WriteLine("Remain candies: " + remainCandies);

            var totalSmallBags = Math.Ceiling(remainCandies / smallBagCapacity);
            Console.WriteLine("Total small bags: " + totalSmallBags);

            remainCandies = remainCandies % smallBagCapacity;
            Console.WriteLine("Remain candies: " + remainCandies);

            Console.WriteLine("Ceiling");
            decimal remainCandiesTwo = candies % bigBagCapacity;
            var totalSmallBagsTwo = Math.Ceiling(remainCandiesTwo / 10);

            Console.WriteLine("Total small bags two: " + totalSmallBagsTwo);
        }

        static void PrintAge() {                        
            var age = String.Empty;                           

            var ageInt = AskForAge(age);

            Console.WriteLine("Your age is: " + ageInt);
        }

        static int AskForAge(string age) {
            Console.WriteLine("Hello... what is your age?");
            int ageInt = 0;
            do {
                age = Console.ReadLine();
                Int32.TryParse(age, out ageInt);

                if (ageInt == 0)
                    Console.WriteLine("Please write a valid number");

            } while (ageInt == 0);            

            return ageInt;
        }
    }
}
