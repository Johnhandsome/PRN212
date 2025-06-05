using OOP3_Extension_Method;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n1 = 5;
Console.WriteLine("Tổng từ 1 tới 5 là " + n1.TongTu1ToiN());

int n2 = 10;
Console.WriteLine("Tổng từ 1 đến 10 là " + n2.TongTu1ToiN());
Console.WriteLine("Tổng từ 1 đến 100 là " + 100.TongTu1ToiN());

int a = 5, b = 10;
Console.WriteLine(10.Cong2So(20));

int[]arr = new int[a];
arr.TaoMang();
Console.WriteLine("Mang truoc khi sap xep: ");
arr.XuatMang();

arr.SapXepTangDan();
Console.WriteLine("Mang sau khi sap xep tang dan");
arr.XuatMang();