using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0109
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
            ////방법 1
            //int[] scores = new int[5];

            ////방법 2 초기에 값을 지정
            //int[] scores2 = new int[] { 90, 80, 70, 60, 50 };

            ////방법3 간단한 초기화
            //int[] values = { 1, 2, 3, 4, 5 };

            ////방법4
            //scores[0] = 1;
            //scores[1] = 2;
            //scores[3] = 4;
            //scores[4] = 5;
            ////scores[5] = 6;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            ////인벤토리 시스템 (최대 5개)
            //string[] inventory = new string[5];

            ////아이템 추가
            ////입력에 따른 추가

            //while (true)
            //{
            //    Console.Write("아이템을 입력하세요 (종료하려면 X 입력) : ");
            //    string item = Console.ReadLine();

            //    if (item.ToLower() == "X")
            //    {
            //        break;
            //    }

            //    //빈칸 찾기
            //    bool isAdded = false;
            //    for (int i = 0; i < inventory.Length; i++)
            //    {
            //        if (string.IsNullOrEmpty(inventory[i]))
            //        {
            //            inventory[i] = item;
            //            isAdded = true;
            //            Console.WriteLine($"{item} 아이템이 인벤토리에 추가되었습니다.");
            //            break;
            //        }
            //    }
            //    if (!isAdded)
            //    {
            //        Console.WriteLine("인벤토리가 가득 찼습니다. 더 이상 아이템을 추가할 수 없습니다.");
            //        break;
            //    }
            //}


            ////인벤토리 출력
            //Console.WriteLine("=== 인벤토리 ====");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}



        //}
    }
}
