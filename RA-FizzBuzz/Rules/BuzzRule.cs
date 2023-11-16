namespace RA_FizzBuzz.Rules;

public class BuzzRule : IFizzBuzzRule
{
    public string ApplyRule(int number)
    {
        return (number % 5 == 0) ? "Buzz" : string.Empty;
    }
}
