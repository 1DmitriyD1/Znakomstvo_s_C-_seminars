namespace Zadacha_9
{
class Program
    {
// Дополнительная задачка! На семинаре посмотрим решение и найдём самое интересное решение
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// Пример:
// 456 -> 6
// 782 -> 2
// 918 -> 8
       
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Программа показывает последнюю цифру введённого числа");
            Console.Write("Введите трёхзначное число N = ");
            int number_n = Convert.ToInt32(Console.ReadLine());
            int last_d = (number_n % 10);
            Console.WriteLine($"Последняя цифра числа {number_n} это {last_d}");
        }
    }
}