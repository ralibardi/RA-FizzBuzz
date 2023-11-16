namespace RA_FizzBuzz.Tests.Rules;

[TestFixture]
public class FizzRuleTests
{
    [Test]
    public void FizzRule_ShouldReturnFizz()
    {
        // Arrange
        var rule = new FizzRule();

        // Act
        rule.Applies(3);

        // Assert
        Assert.That(rule.Result, Is.EqualTo("Fizz"));
    }

    [Test]
    public void FizzRule_ShouldReturnBuzz()
    {
        // Arrange
        var rule = new BuzzRule();

        // Act
        rule.Applies(5);

        // Assert
        Assert.That(rule.Result, Is.EqualTo("Buzz"));
    }
}