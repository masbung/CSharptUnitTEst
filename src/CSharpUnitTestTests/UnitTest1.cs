using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpUnitTest;

namespace CSharpUnitTestTests
{
    [TestClass]
    public class MathCalculatorTests
    {
        [TestMethod]
        // Method_Schenario_ExpectedBehaviour
        public void Add_TwoInts_ReturnsAdd() {
            // Arrange: Create objets
            var mathCalculator = new MathCalculator();

            // Act: Call a method
            var seven = mathCalculator.Add(2, 5);

            // Aset: Verify result
            Assert.AreEqual(7, seven.Value);
        }

        [TestMethod]
        public void Add_OneIntOneNull_ReturnsZero() {
            var mathCalculator = new MathCalculator();

            var zero = mathCalculator.Add(2, null);

            Assert.AreEqual(0, zero);
        }
    }
}
