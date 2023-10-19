using System;
using System.Linq;

class Program
{
    // 1.
    public static double Calculator(double operand1, double operand2, char operation)
    {
        switch (operation)
        {
            case '+':
                return operand1 + operand2;
            case '-':
                return operand1 - operand2;
            case '*':
                return operand1 * operand2;
            case '/':
                if (operand2 != 0)
                    return operand1 / operand2;
                else
                    throw new ArgumentException("Ділення на нуль неможливе.");
            default:
                throw new ArgumentException("Невідома операція.");
        }
    }

    // 2
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }
        return true;
    }

    // 3
    public static double CurrencyConverter(double amount, double exchangeRate)
    {
        if (amount < 0 || exchangeRate <= 0)
            throw new ArgumentException("Невірні значення для конвертації.");
        return amount * exchangeRate;
    }

    // 4
    public static (int, int) FindMinAndMax(int[] array)
    {
        if (array.Length == 0)
            throw new ArgumentException("Масив порожній.");

        int min = array.Min();
        int max = array.Max();

        return (min, max);
    }

    // 5
    public static (int, int) CountVowelsAndConsonants(string input)
    {
        int vowels = 0;
        int consonants = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char lowerC = char.ToLower(c);
                if ("aeiou".Contains(lowerC))
                    vowels++;
                else
                    consonants++;
            }
        }

        return (vowels, consonants);
    }

    static void Main()
    {
        // Приклади використання:

        // Калькулятор
        Console.WriteLine("Результат обчислення: " + Calculator(5, 3, '+'));

        // Перевірка на просте число
        Console.WriteLine("Число 17 є простим: " + IsPrime(17));

        // Конвертація валют
        Console.WriteLine("Сума в інший валюті: " + CurrencyConverter(100, 1.2));

        // Пошук мінімуму та максимуму в масиві
        int[] numbers = { 5, 12, 7, 3, 9 };
        var minAndMax = FindMinAndMax(numbers);
        Console.WriteLine($"Мінімум: {minAndMax.Item1}, Максимум: {minAndMax.Item2}");

        // Робота з рядками
        string text = "Hello, World!";
        var vowelsAndConsonants = CountVowelsAndConsonants(text);
        Console.WriteLine($"Голосні: {vowelsAndConsonants.Item1}, Приголосні: {vowelsAndConsonants.Item2}");
    }
}
