using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int position = 0;

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "hello";
        int position = 0;
        string expected = "hello";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcdef";
        int position = 2;
        string expected = "efabcd";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That (result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "12345";
        int position = -2;
        string expected = "45123";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result , Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "xyz";
        int position = 5;
        string expected = "yzx";

        // Act
        string result = StringRotator.RotateRight(input, position);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
