using System;
class Program
{
    static int[] FilterArray(int[] original, int[] valuesToRemove)
    {
        int count = 0;

        foreach (int num in original)
        {
            bool remove = false;
            foreach (int bad in valuesToRemove)
            {
                if (num == bad)
                {
                    remove = true;
                    break;
                }
            }
            if (!remove)
                count++;
        }

        int[] result = new int[count];
        int index = 0;

        foreach (int num in original)
        {
            bool remove = false;
            foreach (int bad in valuesToRemove)
            {
                if (num == bad)
                {
                    remove = true;
                    break;
                }
            }
            if (!remove)
            {
                result[index] = num;
                index++;
            }
        }

        return result;
    }

    static void Main()
    {
        int[] original = { 1, 2, 6, -1, 88, 7, 6 };
        int[] toRemove = { 6, 88, 7 };

        int[] filtered = FilterArray(original, toRemove);

        Console.WriteLine("Оригинальный массив:");
        foreach (int x in original) Console.Write(x + " ");
        Console.WriteLine();

        Console.WriteLine("Массив для фильтрации:");
        foreach (int x in toRemove) Console.Write(x + " ");
        Console.WriteLine();

        Console.WriteLine("Результат:");
        foreach (int x in filtered) Console.Write(x + " ");
        Console.WriteLine();
    }
}