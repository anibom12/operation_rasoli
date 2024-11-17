using System;
using Operation;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter operation type (prime, palindorome1, palindorome2, decisiontree):");
            string calculationType = Console.ReadLine().ToLower();
            Console.Clear();

            try
            {
                switch (calculationType)
                {
                    case "prime":
                    case "palindorome1":
                    case "palindorome2":
                        Console.WriteLine("Enter a number:");
                        uint number = Convert.ToUInt32(Console.ReadLine());
                        Console.Clear();

                        Calculator calc = CalcFactory.Factory(number, calculationType);

                        if (calc != null)
                        {
                            bool result = calc.IsTrue(number);
                            Console.WriteLine($"Calculation result: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid calculation type.");
                        }
                        break;

                    case "decisiontree":
                        DT dt = CalcFactoryy.Factory("", calculationType);
                        if (dt != null)
                        {
                            dt.Decision();
                        }
                        else
                        {
                            Console.WriteLine("Invalid calculation type.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid operation type.");
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
