namespace Zadacha_4
{
class Program
    {
        //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        // 2, 3, 7 -> 7
        // 44 5 78 -> 78
        // 22 3 9 -> 22
       
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Программа определяет большее число из 3-x введённых.");
            Console.WriteLine("Введите целое число a =");
            
            int number_a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите целое число b =");
            
            int number_b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число c =");
            
            int number_c = Convert.ToInt32(Console.ReadLine());

            int max = number_a;

            if (number_a > max ) max = number_a;
            if (number_b > max ) max = number_b;
            if (number_c > max ) max = number_c;
            
                Console.WriteLine(
                    "_________________\n" +
                    "Вывод результата:\n" +
                    $"   a = {number_a}\n" +
                    $"   b = {number_b}\n" +
                    $"   c = {number_c}\n" +
                    $" max = {max}\n" +
                    "_________________\n");
         
        }
    }
}