namespace RA_FizzBuzz.Tests;

[TestFixture]
public class FizzRuleTests
{
    [Test]
    public void FizzRule_ShouldReturnFizz()
    {
        // Arrange
        var rule = new FizzRule();

        // Assert
        Assert.AreEqual("Fizz", rule.ApplyRule(3));
    }

    [Test]
    public void FizzRule_ShouldReturnBuzz()
    {
        // Arrange
        var rule = new BuzzRule();

        // Assert
        Assert.AreEqual("Buzz", rule.ApplyRule(5));
    }

    [Test]
    public void FizzRule_ShouldReturnFizzBuzz()
    {
        // Arrange
        var rule = new FizzBuzzRule();

        // Assert
        Assert.AreEqual("FizzBuzz", rule.ApplyRule(15));
    }
}