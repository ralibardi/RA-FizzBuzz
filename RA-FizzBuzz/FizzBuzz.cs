namespace RA_FizzBuzz;

public class FizzBuzz : IFizzBuzz
{
    private readonly IServiceProvider _serviceProvider;

    public FizzBuzz(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public string GetOutput(int number)
    {
        var output = string.Empty;

        var types = Assembly.GetExecutingAssembly().GetTypes();
        foreach (var type in types)
        {
            if (type.IsClass && type.GetInterface("IFizzBuzzRule") != null)
            {
                var rule = _serviceProvider.GetService(type) as IFizzBuzzRule;
                output += rule?.ApplyRule(number);
            }
        }

        return string.IsNullOrEmpty(output) ? number.ToString() : output;
    }
}
