// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
int x = a * a;

Console.WriteLine("Квадрат числа A = " + x);
if (x == b)
{
    Console.WriteLine("Числа A является квадратом числа B: " + x + " = " + b);
}
else
{
    Console.WriteLine("Число B не является квадратом числа A");
}