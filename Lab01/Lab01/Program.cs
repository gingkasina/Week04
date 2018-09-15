using System;
public class intergerTest
{
    static void Main(string[] args)
    {
        int a, b, x, y,sum1;
        a = 10;
        b = 20;
        x = 5;
        y = 2;
        Console.WriteLine("a = 10, b = 20, x = 5, y = 2");
        sum1 = a + b;
        Console.WriteLine("Sum1 = a + b = {0}", sum1);
        sum1 = x - b;
        Console.WriteLine("Sum2 = x + b = {0}", sum1);
        sum1 = x* b;
        Console.WriteLine("Sum3 = x * b = {0}", sum1);
        sum1 = y / a;
        Console.WriteLine("Sum4 = d / 2 = {0}", sum1);
        sum1 = b % y;
        Console.WriteLine("Sum5 = e % 2 = {0}", sum1);
        sum1 = y + 10 % x;
        Console.WriteLine("Sum6 = e % 2 = {0}", sum1);
        sum1 = a / 3 * 5;
        Console.WriteLine("Sum7 = e % 2 = {0}", sum1);
        sum1 = 9 / 2 * a;
        Console.WriteLine("Sum8 = e % 2 = {0}", sum1);
        sum1 = y % 8;
        Console.WriteLine("Sum9 = e % 2 = {0}", sum1);
        sum1 = 100* x + y % 2 - a;
        Console.WriteLine("Sum10 = e % 2 = {0}", sum1);
    }
}
