class InterestCalculator
{
    static void Main()
    {
        Console.Write("Enter principal amount: ");
        double PrincipalAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        double Rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time in years: ");
        double Time = Convert.ToDouble(Console.ReadLine());

        double SimpleInterest = (PrincipalAmount * Rate * Time) / 100;

        Console.WriteLine($"Simple Interest: {SimpleInterest:F2}");
    }
}
