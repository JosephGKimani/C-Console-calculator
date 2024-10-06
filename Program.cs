using System;

class Calculator
{
    int num1;
    int num2;
    string ops;
    int res;

  
    public Calculator()
    {
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operation (+, -, *, /, %):");
        ops = Console.ReadLine();
    }

    // Method to perform the calculation
    public int PerformCalculation()
    {


        if (ops == "+")
        {
            res = num1 + num2;
        }
        else if (ops == "-")
        {
            res = num1 - num2;
        }
        else if (ops == "*")
        {
            res = num1 * num2;
        }
        else if (ops == "/")
        {
            if (num2 != 0)
            {
                res = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero.");
                return 0;
            }
        }
        else if (ops == "%")
        {
            res = num1 % num2;
        }
        else
        {
            Console.WriteLine("No such operation symbol.");
            return 0;
        }
        return res;
    }


    public static void Main()
    {
        Calculator calc = new Calculator();
        int result = calc.PerformCalculation(); 
        Console.WriteLine("Result: " + result); 
        Console.ReadKey();
    }
}
