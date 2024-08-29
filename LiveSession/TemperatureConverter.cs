namespace TemperatureConverter
{
     class Program
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        public static void Main(string[] args)
        {
            double celsius = 25;
            double fahrenheitRes=CelsiusToFahrenheit(celsius);
            Console.WriteLine("CelsiusToFahrenheit: "+ fahrenheitRes);



            double fahrenheit = 77;
            double celsiusRes = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("FahrenheitToCelsius:"+ celsiusRes);
        }
    }
}
