// Написать программу вычисления произведения чисел от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
int itog = 1;
while (count <= N) 
{
    itog *= count;
    count ++;
}
Console.WriteLine(itog);