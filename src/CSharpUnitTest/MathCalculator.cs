using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUnitTest
{
    public class MathCalculator
    {
        public int? Add(int a, int? b) {
            if (b == null)
                return null;
            else
                return a + b.Value;
        }
    }
}
