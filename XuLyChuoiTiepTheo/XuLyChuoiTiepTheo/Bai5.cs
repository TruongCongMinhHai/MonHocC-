using System;

namespace XuLyChuoiTiepTheo
{
    class Bai5
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
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap mang thu {0}: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            int max = -9999;
            for(int i = 0;i < n; i++)
            {
                if (max == -9999)
                    max = arr[i];
                if(max < arr[i])
                    max = arr[i];
            }
            Console.Write("Gia tri lon nhat cua mang: {0}", max);
            Console.ReadKey();
        }
    }
}