using System;

namespace XuLyChuoiTiepTheo
{
    class Bai9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Truong Cong Minh Hai 2415053122315");
            string[] arr = { "Truong", null, " ", "Cong", " ", null, "Minh", " Hai" };
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != null && arr[i].Trim() != "")
                    dem++;
            Console.WriteLine("So chuoi khac null va khac rong: " + dem);
            Console.ReadKey();
        }
    }
}
