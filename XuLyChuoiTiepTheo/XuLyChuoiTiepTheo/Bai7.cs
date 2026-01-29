using System;

namespace XuLyChuoiTiepTheo
{
    class Bai7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Truong Cong Minh Hai 2415053122315");
            Console.Write("Nhap ho ten: ");
            string? hoTen = Console.ReadLine();  
            if (hoTen == null)
            {
                Console.WriteLine("Loi: Chuoi null, khong the tach");
                return;
            }
            string[]? arr = null; 
            if (hoTen != "")
                arr = hoTen.Split(' ');
            if (arr == null)
            {
                Console.WriteLine("Loi: Mang ket qua null, khong the in");
                return;
            }
            Console.WriteLine("Cac tu trong ho ten:");
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != "")
                    Console.WriteLine(arr[i]);
            Console.ReadKey();
        }
    }
}
