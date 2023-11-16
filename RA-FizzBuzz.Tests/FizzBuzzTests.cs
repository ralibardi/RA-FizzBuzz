namespace RA_FizzBuzz.Tests;

[TestFixture]
public class FizzBuzzTests
{
    [TestCase(3, "Fizz")]
    [TestCase(5, "Buzz")]
    [TestCase(15, "FizzBuzz")]
    public void FizzBuzz_GetOutput_ShouldReturnStringForMultiplesOf3And5(int number, string result)
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();

        // Assert
        Assert.That(fizzBuzz.GetOutput(number), Is.EqualTo(result));
    }

    [Test]
    public void FizzBuzz_GetOutput_ShouldReturnNumberForNonMultiplesOf3And5()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();

        // Assert
        Assert.That(fizzBuzz.GetOutput(7), Is.EqualTo("7"));
    }
}
