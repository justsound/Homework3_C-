// Показать кубы чисел, заканчивающихся на четную цифру
/* первое решение простое
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int i= 2;
while (i <=num) 
{
    Console.WriteLine($"Куб {i} равен {Math.Pow(i,3)}");

    i +=2;
}    
 */

// второе решение 
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int i= 2;
while (i <=num) 
{
    int Cub = (int)Math.Pow(i,3);
    if ((Cub%10)%2 == 0)  Console.WriteLine($"Куб {i} равен {Math.Pow(i,3)}");

    i ++;
}    

