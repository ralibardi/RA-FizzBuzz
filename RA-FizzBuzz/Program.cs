// See https://aka.ms/new-console-template for more information
using RA_FizzBuzz.Configuration;

var serviceProvider = new ServiceCollection().ConfigureDependencies().BuildServiceProvider();

var fizzBuzz = serviceProvider.GetService<IFizzBuzz>();

if (fizzBuzz != null)
{
    for (var i = 1; i <= 100; i++)
    {
        Console.WriteLine(fizzBuzz.GetOutput(i));
    }
}