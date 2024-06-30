namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;
            Console.WriteLine("Welcome to Calculator Program!");
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a for addition, s for subtraction, m for multiplication and anything else for division! ");
            string operation = Console.ReadLine()!;

            if (operation == "a")
            {
                result = num1 + num2;
            }
            else if (operation == "b")
            {
                result = num1 - num2;
            }
            else if (operation == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }
            Console.WriteLine($"The Result is {result}");
            Console.WriteLine("Thank You");

            Console.ReadLine();
            
        }
    }
}