using System;
class Program
{
    static bool IsPalindrome(int number)
    {
        if (number < 0)
            return false;
        string str = number.ToString();
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
    static void Main()
    {
        Console.Write("Введите число:");
        int userNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {IsPalindrome(userNumber)}");
    }
}