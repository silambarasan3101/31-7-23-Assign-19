using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_7_23_Assign_19
{   
    delegate int ArithmeticOperation(int a, int b);

    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Divide(int a, int b)
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }
        static void Main(string[] args)
        {          
            ArithmeticOperation addOperation = Add;
            ArithmeticOperation subtractOperation = Subtract;
            ArithmeticOperation multiplyOperation = Multiply;
            ArithmeticOperation divideOperation = Divide;          
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());
         
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result of addition: {addOperation(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Result of subtraction: {subtractOperation(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Result of multiplication: {multiplyOperation(num1, num2)}");
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine($"Result of division: {divideOperation(num1, num2)}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.ReadKey();
        }
    }
}
