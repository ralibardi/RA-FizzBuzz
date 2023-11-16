namespace RA_FizzBuzz.Rules;

public class FizzBuzzRule : IFizzBuzzRule
{
    public string ApplyRule(int number)
    {
        return (number % 3 == 0 && number % 5 == 0) ? "FizzBuzz" : string.Empty;
    }
}
