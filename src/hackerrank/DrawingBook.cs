using System;

class Program
{
    static void ShowLog(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"[АОП ЛОГ]: {message}");
        Console.ResetColor();
    }

    static int PageCount(int n, int p)
    {
        int fromFront = p / 2;
        int fromBack = n / 2 - fromFront;
        return Math.Min(fromFront, fromBack);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть загальну кількість сторінок (n):");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть цільову сторінку (p):");
        int p = Convert.ToInt32(Console.ReadLine());

        ShowLog($"Запит на розрахунок. Книга: {n} стор. Шукаємо: {p} стор.");

        int result = PageCount(n, p);

        ShowLog($"Розрахунок завершено. Результат: {result}");

        Console.WriteLine($"\nКінцева відповідь: {result}");
        Console.ReadLine();
    }
}