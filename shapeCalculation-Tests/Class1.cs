using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shapeCalculations;
using NUnit.Framework;

namespace shapeCalculation_Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetPerimeter_inputLength5_inputWidth7_ExpectedPerimeterEquals24()
        {
            //Arrange
            int l = 5;
            int w = 7;
            Rectangle testRect = new Rectangle(l, w);
            int expectedResult = 2 * (l + w);

            //Act
            int actPerimeter = testRect.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actPerimeter);
        }
        [Test]
        public void GetArea_inputLength2_inputWidth6_ExpectedPerimeterEquals12()
        {
            //Arrange
            int l = 2;
            int w = 6;
            Rectangle testRect = new Rectangle(l, w);
            int expectedResult = l * w;

            //Act
            int actArea = testRect.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actArea);
        }
        [Test]
        public void GetLength_input4_ExpectedLengthEquals4()
        {
            //Arrange
            int l = 4;
            int w = 6;
            Rectangle testRect = new Rectangle(l, w);

            //Act
            int length = testRect.GetLength();

            //Assert
            Assert.AreEqual(l, length);
        }
        [Test]
        public void GetWidth_input12_ExpectedWidthEqual12()
        {
            //Arrange
            int l = 4;
            int w = 12;
            Rectangle testRect = new Rectangle(l, w);

            //Act
            int width = testRect.GetWidth();

            //Assert
            Assert.AreEqual(w, width);
        }
        [Test]
        public void SetLength_input20_ExpectedLengthEquals70()
        {
            //Arrange
            int l = 70;
            int w = 2;
            Rectangle testRect = new Rectangle(l, w);

            //Act
            int actLength = testRect.SetLength(l);

            //Assert
            Assert.AreEqual(l, actLength);
        }
        [Test]
        public void SetWidth_input20_ExpectedWidthEquals20()
        {
            //Arrange
            int l = 4;
            int w = 20;
            Rectangle testRect = new Rectangle(l, w);

            //Act
            int actWidth = testRect.SetWidth(w);

            //Assert
            Assert.AreEqual(w, actWidth);
        }
    }
}
