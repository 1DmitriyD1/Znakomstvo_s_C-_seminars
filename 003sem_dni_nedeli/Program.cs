namespace HelloWorld
{
class Program
{
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
static void Main(string[] args)
{
Console.WriteLine("INPUT DAY NUMBER: ");
int number = (Convert.ToInt32(Console.ReadLine())) % 7;
string day = "";
if( number == 1) day = "ponedyelnik";
if( number == 2) day = "vtornik";
if( number == 3) day = "sreda";
if( number == 4) day = "chetverg";
if( number == 5) day = "pyatniza";
if( number == 6) day = "subbota";
if( number == 7) day = "voskresenje";
Console.WriteLine($"Номер дня соответствует: {day}");
string[] day2 = {"PN", "VTor", "SRed", "CHT", "PTN", "SB", "VS"};
Console.WriteLine($"Номер дня соответствует: {day2[number-1]}");
}

}
}