using System;

namespace XuLyChuoiTiepTheo
{
    class Bai4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Truong Cong Minh Hai 2415053122315");
            Console.Write("Nhap so phan tu: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = null;
            if (n > 0)
                arr = new int[n];
            if (arr == null)
            {
                Console.Write("Loi: mang chua duoc khoi tao");
                return;
            }
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap mang thu {0}: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
                temp = temp + arr[i];
            }
            Console.Write("Tong cac phan tu trong mang: {0}", temp);
            Console.ReadKey();
        }
    }
}