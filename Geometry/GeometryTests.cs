using Geometry;
using Xunit;

public class GeometryTests
{
    [Fact]
    public void Circle_CalculateArea_ValidRadius_ReturnsCorrectArea()
    {
        //Arrange
        double radius = 5;
        Circle circle = new Circle(radius);

        //Act
        double circleArea = circle.CalculateArea();

        //Assert
        double expectedArea = Math.PI * Math.Pow(radius, 2);
        Assert.Equal(expectedArea, circleArea);
    }

    [Fact]
    public void Triangle_CalculateArea_ValidSides_ReturnsCorrectArea()
    {
        // Arrange
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        Triangle triangle = new Triangle(side1, side2, side3);

        // Act
        double actualArea = triangle.CalculateArea();

        // Assert
        double expectedArea = 6;
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void Triangle_IsRightTriangle_RightTriangle_ReturnsTrue()
    {
        // Arrange
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        Triangle triangle = new Triangle(side1, side2, side3);

        // Act
        bool isRightTriangle = triangle.IsRightTriangle();

        // Assert
        Assert.True(isRightTriangle);
    }

}

