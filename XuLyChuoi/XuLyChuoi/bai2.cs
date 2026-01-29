using System;

class bai2
{
    public static void Run()
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("So tu: 0");
            return;
        }
        input = input.Trim();

        if (input == "")
        {
            Console.WriteLine("So tu: 0");
            return;
        }
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("So tu: " + words.Length);
    }
}
