using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0106
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            //    int b = 3;
            //    b++; // 후위 증가
            //    Console.WriteLine(b); // 출력: 4
            //    --b; // 전위 감소
            //    Console.WriteLine(b); // 출력: 3

            //    Console.WriteLine("==몬스터 처치==");
            //    int killCount = 0;
            //    Console.WriteLine("고블린 처치(킬카운트 : " + ++killCount + ")"); //전위 증가
            //    Console.WriteLine("오크 처치(킬카운트 : " + ++killCount + ")"); //전위 증가
            //    Console.WriteLine("드래곤 처치(킬카운트 : " + ++killCount + ")"); //전위 증가
            //    Console.WriteLine("총 킬카운트 : " + killCount);


            //    //==사격==
            //    Console.WriteLine("==사격==");

            //    int ammo = 30;
            //    Console.WriteLine("남은탄약 " + ammo);
            //    Console.WriteLine($"발사! {--ammo}");
            //    Console.WriteLine("남은탄약 " + ammo);
            //    Console.WriteLine($"발사! {--ammo}");
            //    Console.WriteLine("남은탄약 " + ammo);
            //    Console.WriteLine($"발사! {--ammo}");
            //    Console.WriteLine("남은탄약 " + ammo);


            //    //카운트 다운
            //    Console.WriteLine("==카운트 다운==");
            //    int countDown = 3;
            //    while (countDown > 0)
            //    {
            //        Console.WriteLine(countDown);
            //        countDown--;

            //    }
            //    if (countDown == 0)
            //    {
            //        Console.WriteLine("발사!");
            //    }

            //int x = 5, y = 10;
            //Console.WriteLine(x < y); // 출력: True 
            //Console.WriteLine(x == y); // 출력: False

            //bool a = true, b = false;
            //Console.WriteLine(a && b); // AND: False 
            //Console.WriteLine(a || b); // OR: True 
            //Console.WriteLine(!a);     // NOT: False

            //int x = 5; // 0101
            //int y = 3; // 0011
            //Console.WriteLine(x & y); // AND: 1 (0001)
            //Console.WriteLine(x | y); // OR : 7 (0111)
            //Console.WriteLine(x ^ y); // XOR: 6 (0110)
            //Console.WriteLine(~x);    // NOT: -6


            int value = 4; // 0100
            Console.WriteLine(value << 1); // 왼쪽 이동: 8 (1000) 
            Console.WriteLine(value >> 1); // 오른쪽 이동: 2 (0010)

        }
    }
}
