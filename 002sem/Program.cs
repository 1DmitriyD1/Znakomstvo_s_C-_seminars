namespace HelloWorld
{
class Program
{
static void Main(string[] args)
    {

        Console.Clear();
        Console.WriteLine("Введите первое число, второе число: ");
        
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        int number2 = Convert.ToInt32(Console.ReadLine());

        int square = number2 * number2;

        if (square == number1)
            {
                Console.WriteLine($"Первое число {number1} является квадратом второго {number2}");
            }
            else
            {
                Console.WriteLine($"Первое число {number1} не является квадратом второго {number2}");
            }
    }

}
}