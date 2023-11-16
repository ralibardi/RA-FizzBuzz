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
}