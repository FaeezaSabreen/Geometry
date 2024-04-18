namespace GeometryUnitTest;

using GeometryLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void TestSquareArea()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculateArea();

        // Assert
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestSquarePerimeter()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void TestSquareAreaWithDifferentValue()
    {
        // Arrange
        var square = new Square(7);

        // Act
        var result = square.CalculateArea();

        // Assert
        Assert.AreEqual(49, result);
    }

    [TestMethod]
    public void TestSquarePerimeterWithDifferentValue()
    {
        // Arrange
        var square = new Square(7);

        // Act
        var result = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(28, result);
    }
}

[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void TestRectangleArea()
    {
        // Arrange
        var rectangle = new Rectangle(4, 6);

        // Act
        var result = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void TestRectanglePerimeter()
    {
        // Arrange
        var rectangle = new Rectangle(4, 6);

        // Act
        var result = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void TestRectangleAreaWithDifferentValues()
    {
        // Arrange
        var rectangle = new Rectangle(3, 8);

        // Act
        var result = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void TestRectanglePerimeterWithDifferentValues()
    {
        // Arrange
        var rectangle = new Rectangle(3, 8);

        // Act
        var result = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(22, result);
    }
}

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestTriangleArea()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void TestTrianglePerimeter()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void TestTriangleAreaWithDifferentValues()
    {
        // Arrange
        var triangle = new Triangle(6, 8, 10);

        // Act
        var result = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void TestTrianglePerimeterWithDifferentValues()
    {
        // Arrange
        var triangle = new Triangle(6, 8, 10);

        // Act
        var result = triangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(24, result);
    }
}