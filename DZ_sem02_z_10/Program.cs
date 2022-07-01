namespace Sem_02_DZ_z_10
{
class Program
    {
        //  Напишите программу, которая принимает на вход трёхзначное число
        //  и на выходе показывает вторую цифру этого числа.
        //  456 -> 5
        //  782 -> 8
        //  918 -> 1
        static void Main(string[] args)
        {
            // Console.Clear();

           Console.WriteLine("Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. ");

           Console.WriteLine("Введите трёхзначное число: ");

           string? s = Console.ReadLine();
         
           Console.WriteLine($"Выводим результат: {s[1]}");

        }

    }

}