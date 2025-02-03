using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace JianGongLab3Test
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void MutationIsoscelesTriangle_Input60And60And70_OutputValidIsoscelesTriangle()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 70;

            // Action
            string result = Triangle.ValidIsoscelesTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            ClassicAssert.AreEqual(Triangle.SUCCESS, result);
        }
    }
}
