/*using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int oFaren = 0;
            int cCelsius = ((oFaren-32) /9) * 5;
            int cFaren = ((cCelsius*9)/5)+32;
            Console.WriteLine("Original Farenheit: "+ oFaren);
            Console.WriteLine("Calculated Celsius: "+ cCelsius);
            Console.WriteLine("Calculated Farenheit: "+ cFaren);
            
            oFaren = 32;
            cCelsius = ((oFaren-32) /9) * 5;
            cFaren = ((cCelsius*9)/5)+32;
            Console.WriteLine("Original Farenheit: "+ oFaren);
            Console.WriteLine("Calculated Celsius: "+ cCelsius);
            Console.WriteLine("Calculated Farenheit: "+ cFaren);
            
            oFaren = 212;
            cCelsius = ((oFaren-32) /9) * 5;
            cFaren = ((cCelsius*9)/5)+32;
            Console.WriteLine("Original Farenheit: "+ oFaren);
            Console.WriteLine("Calculated Celsius: "+ cCelsius);
            Console.WriteLine("Calculated Farenheit: "+ cFaren);

            float originalFaren = 0;
            float calculatedCelsius = ((originalFaren-32) /9) * 5;
            float calculatedFaren = ((calculatedCelsius*9)/5)+32;
            Console.WriteLine("Original Farenheit: "+ originalFaren);
            Console.WriteLine("Calculated Celsius: "+ calculatedCelsius);
            Console.WriteLine("Calculated Farenheit: "+ calculatedFaren);
        }
    }
}*/
using System;

/// <summary>
/// Exercise 7 Solution
/// </summary>
public class Program
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	static void Main(string[] args)
	{
        // declare int variables
        int originalFahrenheit;
        int celsius;
        int calculatedFahrenheit;

        // calculate and display for 0 degrees
        originalFahrenheit = 0;
        Console.WriteLine("Original Fahrenheit: " + originalFahrenheit);
        celsius = (originalFahrenheit - 32) / 9 * 5;
        Console.WriteLine("Calculated Celsius: " + celsius);
        calculatedFahrenheit = (celsius * 9) / 5 + 32;
        Console.WriteLine("Calculated Fahrenheit: " + calculatedFahrenheit);

        // calculate and display for 32 degrees
        originalFahrenheit = 32;
        Console.WriteLine("Original Fahrenheit: " + originalFahrenheit);
        celsius = (originalFahrenheit - 32) / 9 * 5;
        Console.WriteLine("Calculated Celsius: " + celsius);
        calculatedFahrenheit = (celsius * 9) / 5 + 32;
        Console.WriteLine("Calculated Fahrenheit: " + calculatedFahrenheit);

        // calculate and display for 212 degrees
        originalFahrenheit = 212;
        Console.WriteLine("Original Fahrenheit: " + originalFahrenheit);
        celsius = (originalFahrenheit - 32) / 9 * 5;
        Console.WriteLine("Calculated Celsius: " + celsius);
        calculatedFahrenheit = (celsius * 9) / 5 + 32;
        Console.WriteLine("Calculated Fahrenheit: " + calculatedFahrenheit);

        // declare float variables
        float floatOriginalFahrenheit;
        float floatCelsius;
        float floatCalculatedFahrenheit;

        // calculate and display for 0 degrees using float
        floatOriginalFahrenheit = 0;
        Console.WriteLine("Float Original Fahrenheit: " + floatOriginalFahrenheit);
        floatCelsius = (floatOriginalFahrenheit - 32) / 9 * 5;
        Console.WriteLine("Float Calculated Celsius: " + floatCelsius);
        floatCalculatedFahrenheit = (floatCelsius * 9) / 5 + 32;
        Console.WriteLine("Float Calculated Fahrenheit: " + floatCalculatedFahrenheit);

        // declare double variables
        double doubleOriginalFahrenheit;
        double doubleCelsius;
        double doubleCalculatedFahrenheit;

        // calculate and display for 0 degrees using double
        doubleOriginalFahrenheit = 0;
        Console.WriteLine("Double Original Fahrenheit: " + doubleOriginalFahrenheit);
        doubleCelsius = (doubleOriginalFahrenheit - 32) / 9 * 5;
        Console.WriteLine("Double Calculated Celsius: " + doubleCelsius);
        doubleCalculatedFahrenheit = (doubleCelsius * 9) / 5 + 32;
        Console.WriteLine("Double Calculated Fahrenheit: " + doubleCalculatedFahrenheit);

    }
}
