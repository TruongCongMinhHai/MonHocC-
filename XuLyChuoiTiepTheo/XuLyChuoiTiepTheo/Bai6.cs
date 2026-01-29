using System;

namespace XuLyChuoiTiepTheo
{
    class Bai6
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
            int chan = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] % 2 == 0)
                    chan++;
            Console.WriteLine("So phan tu chan trong mang: {0}", chan);
            Console.ReadKey();
        }
    }
}
