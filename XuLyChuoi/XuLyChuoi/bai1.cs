using System;

class bai1
{
    public static void Run()
    {
        Console.Write("Nhap ho ten: ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Loi: Chuoi null hoac rong!");
            return;
        }
        input = input.Trim();
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            string w = words[i].ToLower();
            words[i] = char.ToUpper(w[0]) + w.Substring(1);
        }
        string result = string.Join(" ", words);
        Console.WriteLine("Ho ten sau chuan hoa: " + result);
    }
}
