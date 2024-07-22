namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.CelsiusToFahrenheit(32);
            var fahrenheit = TempConverter.FahrenheitToCelsius(90);
            
            Console.WriteLine(celsius);
            Console.WriteLine(fahrenheit);
        }
    }
}
