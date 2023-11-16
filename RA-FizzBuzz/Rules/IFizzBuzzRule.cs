namespace RA_FizzBuzz.Rules;

public interface IFizzBuzzRule
{
    bool Applies(int number);
    string Result { get; }
}
