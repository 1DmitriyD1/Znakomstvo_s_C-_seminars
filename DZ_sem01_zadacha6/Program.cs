namespace Zadacha_6
{
class Program
    {
            // Напишите Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            // 4 -> да
            // -3 -> нет
            // 7 -> нет
       
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Программа определяет чётное число или нет.");
            Console.WriteLine("Введите целое число a =");
            
            int number_a = Convert.ToInt32(Console.ReadLine());
            if (number_a % 2 == 0)  
            
                {
                    Console.WriteLine("Число чётное");                    }
            else
                {
                    Console.WriteLine("Число не чётное");
                }
            
        }
    }
}