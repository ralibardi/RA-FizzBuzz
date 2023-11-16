namespace RA_FizzBuzz.Tests;

[TestFixture]
public class FizzBuzzTests
{
    [Test]
    public void FizzRule_ShouldReturnFizz()
    {
        var rule = new FizzRule();
        Assert.AreEqual("Fizz", rule.ApplyRule(3));
    }

    [Test]
    public void FizzRule_ShouldReturnBuzz()
    {
        var rule = new BuzzRule();
        Assert.AreEqual("Buzz", rule.ApplyRule(5));
    }

    [Test]
    public void FizzRule_ShouldReturnFizzBuzz()
    {
        var rule = new FizzBuzzRule();
        Assert.AreEqual("FizzBuzz", rule.ApplyRule(15));
    }
}