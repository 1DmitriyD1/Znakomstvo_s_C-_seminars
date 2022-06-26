namespace Zadacha_2
{
class Program
    {
        //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
        // a = 5; b = 7 -> max = 7
        // a = 2 b = 10 -> max = 10
        // a = -9 b = -3 -> max = -3

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Программа определяет большее число из введённых.");
            Console.WriteLine("Введите целое число a =");
            
            int number_a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите целое число b =");
            
            int number_b = Convert.ToInt32(Console.ReadLine());

            int max = number_a;

            if (number_a > number_b) max = number_a;
            
                else
                {
                  max = number_b;  
                }

                Console.WriteLine(
                    "_________________\n" +
                    "Вывод результата:\n" +
                    $"   a = {number_a}\n" +
                    $"   b = {number_b}\n" +
                    $" max = {max}\n" +
                    "_________________\n");
         
        }
    }
}
