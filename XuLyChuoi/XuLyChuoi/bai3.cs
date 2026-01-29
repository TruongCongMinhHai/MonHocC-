using System;

class bai3
{
    public static void Run()
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Khong doi xung");
            return;
        }
        input = input.Replace(" ", "").ToLower();
        int left = 0;
        int right = input.Length - 1;
        bool doiXung = true;
        while (left < right)
        {
            if (input[left] != input[right])
            {
                doiXung = false;
                break;
            }
            left++;
            right--;
        }
        if (doiXung)
            Console.WriteLine("Chuoi doi xung");
        else
            Console.WriteLine("Chuoi khong doi xung");
    }
}