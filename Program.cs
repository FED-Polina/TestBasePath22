using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        string commonDigits = GetCommonDigits(firstNumber, secondNumber);
    }

    static string GetCommonDigits(int num1, int num2)
    {
        string strNum1 = num1.ToString();
        string strNum2 = num2.ToString();
        string commonDigits = "";

        foreach (char digit in strNum1)
        {
            if (strNum2.Contains(digit))
            {
                if (!commonDigits.Contains(digit))
                {
                    commonDigits += digit;
                }
            }

        }
        if (commonDigits.Length == 0)
        {
            Console.WriteLine("No common digits found"); 
        }
        else
        {
            Console.WriteLine("Digits common in both numbers: " + commonDigits);
        }

        return commonDigits;
    }
}
