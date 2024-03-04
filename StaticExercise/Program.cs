namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            TempConverter.FahrenheitToCelsius(100.00);
            // if no consoleWriteline in method, we can also implement here
            //ConsoleWriteLine((TempConverter.FahrenheitToCelsius(100.00));

            TempConverter.CelsiusToFahrenheit(37.78);

            //if user input is needed to give output
            Console.WriteLine("Enter in celsius degree : ");
            double userInput = double.Parse(Console.ReadLine());
            TempConverter.CelsiusToFahrenheit(userInput);


        }
    }
}
