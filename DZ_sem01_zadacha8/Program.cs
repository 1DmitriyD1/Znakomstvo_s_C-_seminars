namespace Zadacha_8
{
class Program
    {
        // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. (не включая N)

        // 5 -> 2, 4
        // 8 -> 2, 4, 6
       
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Программа показывает все чётные числа от 1 до N. (не включая N)");
            Console.Write("Введите целое число N = ");
            
            int number_n = Convert.ToInt32(Console.ReadLine());
            
            int index = 2;
            
            Console.WriteLine("Чётные числа:");

            while (index < number_n) 
                {
                
                Console.Write($"{index}, ");
                
                index = index + 2;

                }
                
        }
    }
}
