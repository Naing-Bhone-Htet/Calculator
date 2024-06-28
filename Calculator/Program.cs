namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;  
            Console.WriteLine("Welcome to Calculator Program!");
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2);
            Console.ReadLine();
            
        }
    }
}