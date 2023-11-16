namespace RA_FizzBuzz.Rules;

public class BuzzRule : IFizzBuzzRule
{
    public bool Applies(int number) => number % 5 == 0;
    public string Result => "Buzz";
}
