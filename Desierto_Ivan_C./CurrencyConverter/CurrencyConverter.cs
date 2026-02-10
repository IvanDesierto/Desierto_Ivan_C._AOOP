class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter Amount in USD: ");
        double USD = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exchange rate from USD to EUR: ");
        double Rate = Convert.ToDouble(Console.ReadLine());

        Console.Write($"Amount in EUR: {USD * Rate:F2}");
       
    }
}
