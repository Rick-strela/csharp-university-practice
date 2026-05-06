using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{

    // Та самая функция, которую просит написать HackerRank
    static int migratoryBirds(List<int> arr)
    {
        // Создаем массив-счетчик на 6 элементов (для типов 1, 2, 3, 4, 5)
        int[] counts = new int[6];

        // 1. Считаем птиц
        foreach (int type in arr)
        {
            counts[type]++;
        }

        int maxFrequency = 0;
        int resultId = 0;

        // 2. Ищем самый частый ID (идем от 1 до 5)
        for (int i = 1; i <= 5; i++)
        {
            if (counts[i] > maxFrequency)
            {
                maxFrequency = counts[i];
                resultId = i;
            }
        }

        return resultId;
    }

    // То, как HackerRank принимает данные локально
    static void Main(string[] args)
    {
        // Сначала считываем количество птиц (в задаче это первая строка)
        int n = Convert.ToInt32(Console.ReadLine());

        // Потом считываем все ID птиц, разделенные пробелом
        string input = Console.ReadLine();

        // Превращаем строку в список чисел (это стандартная строка в C#)
        List<int> arr = input.TrimEnd().Split(' ').Select(int.Parse).ToList();

        // Вызываем нашу функцию
        int result = migratoryBirds(arr);

        // Выводим ответ
        Console.WriteLine(result);
    }
}