using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_Extension_Method
{
    public static class MyUtils
    {
        /* Hãy cài đặt 1 hàm là tổng từ 1 -> n vào kiểu int của Microsoft*/
        public static int TongTu1ToiN(this int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++) 
            {
                sum += i;
            }
            return sum;
        }

        // Viết hàm tính tổng 2 số
        public static int Cong2So(this int a, int b)
        { 
            return a + b;
        }

        // Bổ sung 1 hàm sắp xếp tăng dần vào 1 mảng có kiểu int
        public static void SapXepTangDan(this int[]arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length - 1; j++) 
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }    
        }

        // Tạo giá trị ngẫu nhiên cho một mảng int bất kì
        public static void TaoMang(this int[] arr) 
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }
        }

        // Xuất mảng
        public static void XuatMang(this int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        } 
    }
}
