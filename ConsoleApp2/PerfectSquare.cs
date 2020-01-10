using System;
using System.Linq;

public class kata
{
    public static void Main()
    {
        Console.Write("Enter a number to check if it's a perfect square: ");

        int test = Convert.ToInt32(Console.ReadLine());

        if (isPerfectSquare(test))
        {
            Console.WriteLine(test + " is a perfect square.");
        }
        else
        {
            Console.WriteLine(test + " is not a perfect square.");
        }
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        while (keyInfo.Key != ConsoleKey.Enter)
            keyInfo = Console.ReadKey();

    }
    public static Boolean isPerfectSquare(int number)
    {
        int[] last_digit_test = { 0, 1, 4, 5, 6, 9 };
        int[] digitial_sum_test = { 1, 4, 7, 9 };

        Boolean cur_state = true;

        if (!last_digit_test.Contains(lastDigit(number)) || !digitial_sum_test.Contains(digitalSum(number)))
        {
            cur_state = false;
        }

        return cur_state;
    }

    public static int digitalSum(int number)
    {
        int digital_root = 0;
        while (number > 0)
        {
            digital_root = digital_root + (number % 10);
            number = number / 10;
        }

        if (digital_root > 9)
        {
            digital_root = digitalSum(digital_root);
        }
        return digital_root;
    }
    public static int lastDigit(int number)
    {
        return number % 10;
    }
}
