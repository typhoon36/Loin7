using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0107
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine($"숫자: {i}");
            //}

            //=== 몬스터 웨이브 시작 ===
            //👹 고블린 #1 생성!
            //👹 고블린 #2 생성!
            //👹 고블린 #3 생성!
            //👹 고블린 #4 생성!
            //👹 고블린 #5 생성!
            //총 5마리 생성 완료!

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine($"숫자: {i}");
            //}

            //Console.WriteLine("=== 몬스터 웨이브 시작 ===");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"👹 고블린 #{i} 생성!");
            //}
            //Console.WriteLine("총 5마리 생성 완료!");

            //== 게임 시작 카운트  다운 ==
            Console.WriteLine("== 게임 시작 카운트 다운 ==");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("🎮 게임 시작!");

           


        }
    }
}
