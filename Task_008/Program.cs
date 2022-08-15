// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
string writeLetterN = Console.ReadLine();
int N = int.Parse(writeLetterN);

int NumbersComposition(int x)
{
    int comp = 1;
    for (int num = 1; num <= x; num++)
    {
        comp = comp * num;
    }
    return comp;
}

Console.WriteLine($"Произведение чисел от 1 до {N} равно {NumbersComposition(N)}");