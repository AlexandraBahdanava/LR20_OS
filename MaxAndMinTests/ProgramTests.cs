using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxAndMin;

namespace MaxAndMin.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMax()
        {
            // Arrange
            double a = 10.0;
            double b = 5.0;
            double c = 7.0;
            double expectedMax = 10.0;

            // Act
            double actualMax = Program.Max(a, b, c);

            // Assert
            Assert.AreEqual(expectedMax, actualMax);
        }

        [TestMethod]
        public void TestMin()
        {
            // Arrange
            double a = 10.0;
            double b = 5.0;
            double c = 7.0;
            double expectedMin = 5.0;

            // Act
            double actualMin = Program.Min(a, b, c);

            // Assert
            Assert.AreEqual(expectedMin, actualMin);
        }
    }
}
