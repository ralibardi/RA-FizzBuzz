namespace RA_FizzBuzz.Rules;

public class FizzRule : IFizzBuzzRule
{
    public bool Applies(int number) => number % 3 == 0;
    public string Result => "Fizz";
}
