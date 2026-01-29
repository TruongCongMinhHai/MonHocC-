using System;

namespace XuLyChuoiTiepTheo
{
    class Bai8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Truong Cong Minh Hai 2415053122315");
            Console.Write("Nhap 1 cau: ");
            string cau = Console.ReadLine();
            if (cau == null)
            {
                Console.WriteLine("Chuoi null, khong xu ly");
                return;
            }
            string[] arr = cau.Split(' ');
            string tuDaiNhat = "";
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Length > tuDaiNhat.Length)
                    tuDaiNhat = arr[i];
            Console.WriteLine("Tu dai nhat la: " + tuDaiNhat);
            Console.ReadKey();
        }
    }
}
