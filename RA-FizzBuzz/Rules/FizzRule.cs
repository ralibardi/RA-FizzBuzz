namespace RA_FizzBuzz.Rules;

public class FizzRule : IFizzBuzzRule
{
    public string ApplyRule(int number)
    {
        return (number % 3 == 0) ? "Fizz" : string.Empty;
    }
}
