namespace Calc
{
    public class Calculator
    {
        public static void Main()
        {
            var repeat = 'y';
            while (repeat == 'y')
            {
                double firstValue;
                double secondValue;
                double finalValue;
                char operation;

                Console.WriteLine("Welcome to Calc!");
                Console.WriteLine("\nChoose first number");
                firstValue = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Choose second number");
                secondValue = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nChoose your operation '+', '-', '*', '/'");
                operation = Convert.ToChar(Console.ReadLine());

                switch (operation)
                {
                    case ('+'):
                        finalValue = firstValue + secondValue;
                        Console.WriteLine($"Sum {finalValue}");
                        break;
                    case ('-'):
                        finalValue = firstValue - secondValue;
                        Console.WriteLine($"Subtraction {finalValue}");
                        break;
                    case '*':
                        finalValue = firstValue * secondValue;
                        Console.WriteLine($"Multiply {finalValue}");
                        break;
                    case '/':
                        finalValue = firstValue / secondValue;
                        if (secondValue == 0) Console.WriteLine("U can't div on 0");
                        else
                        Console.WriteLine($"Division {finalValue}");
                        break;
                    default:
                        Console.WriteLine("Choose the right nubmers or operation");
                        break;
               
                }
                Console.WriteLine("Do you want to continue? y/n");
                repeat = Convert.ToChar(Console.ReadLine());
            }

        }
    }
}