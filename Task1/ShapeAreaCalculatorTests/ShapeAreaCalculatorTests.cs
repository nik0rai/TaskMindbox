namespace ShapeAreaCalculatorTests
{
    public class ShapeAreaCalculatorTests
    {
        [Fact]
        public void TestCircleArea()
        {
            var calculator = new ShapeAreaCalculator.ShapeAreaCalculator();
            var expected = Math.PI * 5.0 * 5.0;
            var actual = calculator.Calculate("circle", 5.0);

            Assert.Equal(expected, actual, 0.0001);
        }

        /// <summary>
        /// Should throw ArgumentException("Radius can't be negative")
        /// </summary>
        [Fact]
        public void TestCircleAreaWithNegativeRadius()
        {
            var calculator = new ShapeAreaCalculator.ShapeAreaCalculator();
            var expected = "Radius can't be negative";
            var actual = Assert.Throws<ArgumentException>(() => calculator.Calculate("circle", -2.0));

            Assert.Equal(expected, actual.Message);
        }

        [Fact]
        public void TestTriangleArea()
        {
            var calculator = new ShapeAreaCalculator.ShapeAreaCalculator();
            var expected = Math.Sqrt(6.0 * (6.0 - 3.0) * (6.0 - 4.0) * (6.0 - 5.0));
            var actual = calculator.Calculate("triangle", 3.0, 4.0, 5.0);

            Assert.Equal(expected, actual, 0.0001);
        }

        /// <summary>
        /// Should throw ArgumentException("Side or sides can't be negative")
        /// </summary>
        [Fact]
        public void TestTriangleAreaWithNegativeSide()
        {
            var calculator = new ShapeAreaCalculator.ShapeAreaCalculator();
            var expected = "Side or sides can't be negative";
            var actual = Assert.Throws<ArgumentException>(() => calculator.Calculate("triangle", -3.0, 4.0, 5.0));

            Assert.Equal(expected, actual.Message);
        }

        [Fact]
        public void TestIsRightTriangle()
        {
            var calculator = new ShapeAreaCalculator.ShapeAreaCalculator();
            var expected = "right";
            var actual = calculator.GetTypeOfShape("triangle", 3.0, 4.0, 5.0);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Should throw ArgumentException("Unknown shape type: blah")
        /// </summary>
        [Fact]
        public void TestNonExistingShape()
        {
            var calculator = new ShapeAreaCalculator.ShapeAreaCalculator();
            var expected = "Unknown shape type: blah";
            var actual = Assert.Throws<ArgumentException>(() => calculator.Calculate("blah", 3.0, 4.0, 5.0));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// Should throw ArgumentException("Such triangle doesn't exist!")
        /// </summary>
        [Fact]
        public void TestWrongTriangle()
        {
            var calculator = new ShapeAreaCalculator.ShapeAreaCalculator();
            var expected = "Such triangle doesn't exist!";
            var actual = Assert.Throws<ArgumentException>(() => calculator.Calculate("triangle", 11.0, 4.0, 5.0));

            Assert.Equal(expected, actual.Message);
        }
    }
}