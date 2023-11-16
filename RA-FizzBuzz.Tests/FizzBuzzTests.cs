namespace RA_FizzBuzz.Tests;

[TestFixture]
public class FizzBuzzTests
{
    [TestCase(3, "Fizz")]
    [TestCase(5, "Buzz")]
    [TestCase(15, "FizzBuzz")]
    public void FizzBuzz_GetOutput_ShouldReturnStringForMultiplesOf3And5(int multiplier, string result)
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();

        // Assert
        for (int i = 0; i < 10; i++) { 
            Assert.AreEqual(result, fizzBuzz.GetOutput(multiplier * i));
        }
    }

    [Test]
    public void FizzBuzz_GetOutput_ShouldReturnNumberForNonMultiplesOf3And5()
    {
        // Arrange
        var fizzBuzz = new FizzBuzz();

        // Assert
        Assert.AreEqual("7", fizzBuzz.GetOutput(7));
    }
}
