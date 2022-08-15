// Найти сумму чисел от 1 до А

Console.Clear();
Console.Write("Введите число: ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);

int SumNumber(int A)
{
    int number = 1;
    int sum = 0;
    for (int i = 0; i < A; i++)
    {
        sum = sum + number;
        number++;
    }
    return sum;
}

int NumbersSum = SumNumber(A);
Console.WriteLine($"Сумма чисел от 1 до {A} составляет {NumbersSum}");