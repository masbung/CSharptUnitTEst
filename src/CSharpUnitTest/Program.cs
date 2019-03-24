using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUnitTest
{
    class Program
    {
        static void Main(string[] args) {
            var mathCalculator = new MathCalculator();
            var sum = mathCalculator.Add(3, 5);
            Console.WriteLine(sum.Value);
        }
    }
}
