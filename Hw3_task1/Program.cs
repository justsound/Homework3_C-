// Найти кубы чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i= 1;
while (i <=N) 
{
    
    Console.WriteLine($"Куб {i} равен { i*i*i}");
    i ++;
}    
