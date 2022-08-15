// Определить количество цифр в числе

Console.Clear();
Console.Write("Введите число: ");
string writeNumber = Console.ReadLine();
int number = int.Parse(writeNumber);
int result = number;

int count1 = 0;
while (result > 0)
{
    result = result / 10;
    count1++;
}
Console.WriteLine($"В числе {number} {count1} цифр");
Console.WriteLine();