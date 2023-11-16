namespace RA_FizzBuzz;

public class FizzBuzz : IFizzBuzz
{
    private readonly List<IFizzBuzzRule> rules;

    public FizzBuzz()
    {
        rules = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(IFizzBuzzRule).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .Select(Activator.CreateInstance)
            .Cast<IFizzBuzzRule>()
            .ToList();
    }

    public string GetOutput(int number)
    {
        var result = rules
            .OrderByDescending(x => x.Result)
            .Where(rule => rule.Applies(number)).Select(rule => rule.Result);

        return result.Any() ? string.Join(string.Empty, result) : number.ToString();
    }
}
