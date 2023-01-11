namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numerator of the first fraction: ");
            int numerator1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the denominator of the first fraction: ");
            int denominator1 = int.Parse(Console.ReadLine());
            Fraction fraction1 = new Fraction(numerator1, denominator1);

            Console.Write("Enter the numerator of the second fraction: ");
            int numerator2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the denominator of the second fraction: ");
            int denominator2 = int.Parse(Console.ReadLine());
            Fraction fraction2 = new Fraction(numerator2, denominator2);
            Console.WriteLine("\nFirst Fraction: " + fraction1);
            Console.WriteLine("Second Fraction: " + fraction2);

            Fraction result = fraction1.Add(fraction2);
            Console.WriteLine("\nAddition: " + result);

            result = fraction1.Subtract(fraction2);
            Console.WriteLine("Subtraction: " + result);

            result = fraction1.Multiply(fraction2);
            Console.WriteLine("Multiplication: " + result);

            result = fraction1.Divide(fraction2);
            Console.WriteLine("Division: " + result);

            Console.WriteLine("\nFraction as decimal: " + result.ToDecimal());
        }
    }
}