// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int i= 2;
while (i <=num) 
{
    Console.WriteLine($"Куб {i} равен {Math.Pow(i,3)}");

    i +=2;
}    

