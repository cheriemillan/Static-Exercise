

namespace StaticExercise;

public static class TempConverter
{

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        var formula = (fahrenheit - 32) * 5 / 9;
        return formula;
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        var formula = celsius * 9 / 5 + 32;
        return formula;
    }
}
// Fork and Clone the repository to your local computer:
//Static Exercise Repo
/*Now create a static class called TempConverter.
The class should have at least 2 methods, one called FahrenheitToCelsius that
will require a double as a parameter and return a double, the other CelsiusToFahrenheit
which will also require a double as a parameter and return a double.
*/
//Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!