using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0109
{
    internal class Class2
    {
        //    static void Main(string[] args)
        //    {
        //        //// 가변 배열
        //        //string[][] raid = new string[3][];

        //        //raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };  //4명
        //        //raid[1] = new string[] { "도적", "전사", "힐러" };            //3명
        //        //raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" }; //5명

        //        //Console.WriteLine("=== 레이드 파티 구성 ===");
        //        //for (int i = 0; i < raid.Length; i++)
        //        //{
        //        //    Console.WriteLine($"파티 {i + 1} ({raid[i].Length}명):");
        //        //    for (int j = 0; j < raid[i].Length; j++)
        //        //    {
        //        //        Console.WriteLine($" - {raid[i][j]}");
        //        //    }
        //        //}


        //        //// 선언 방법
        //        //List<int> numbers = new List<int>();           // 빈 리스트
        //        //List<string> names = new List<string>();       // 문자열 리스트
        //        //List<float> prices = new List<float>();        // 실수 리스트

        //        //// 초기값과 함께 선언
        //        //List<int> scores = new List<int> { 85, 90, 78, 95 };
        //        //List<string> items = new List<string> { "검", "방패", "포션" };

        //        //// C# 3.0 이후 간단한 초기화
        //        //var players = new List<string> { "철수", "영희", "민수" };


        //        //List<string> items = new List<string>();

        //        //// Add: 끝에 추가
        //        //items.Add("회복 포션");
        //        //items.Add("마나 포션");


        //        ////List 생성
        //        //List<string> inventory = new List<string>();

        //        //Console.WriteLine("=== 도적 인벤토리 시스템 ==");

        //        ////아이템 추가 (Add)
        //        //inventory.Add("회복 포션");
        //        //inventory.Add("마나 포션");
        //        //inventory.Add("강철 검");
        //        //Console.WriteLine("아이템 3개 추가");

        //        ////현재 인벤토리
        //        //Console.WriteLine($"인벤토리 ({inventory.Count}개):");

        //        //for (int i = 0; i < inventory.Count; i++)
        //        //{
        //        //    Console.WriteLine($"[{i}] {inventory[i]}");
        //        //}
        //        //Console.WriteLine();
        //        //inventory[0] = "초록포션";

        //        //for (int i = 0; i < inventory.Count; i++)
        //        //{
        //        //    Console.WriteLine($"[{i}] {inventory[i]}");
        //        //}
        //        //Console.WriteLine();
        //        ////특정 위치에 추가 (Insert)
        //        //inventory.Insert(1, "전설 검");

        //        //for (int i = 0; i < inventory.Count; i++)
        //        //{
        //        //    Console.WriteLine($"[{i}] {inventory[i]}");
        //        //}

        //        ////아이템 제거 (Remove)
        //        //inventory.Remove("초록포션");
        //        //Console.WriteLine();

        //        //for (int i = 0; i < inventory.Count; i++)
        //        //{
        //        //    Console.WriteLine($"[{i}] {inventory[i]}");
        //        //}

        //        ////인덱스로 제거 (RemoveAt)
        //        //inventory.RemoveAt(0);
        //        //Console.WriteLine();
        //        //for (int i = 0; i < inventory.Count; i++)
        //        //{
        //        //    Console.WriteLine($"[{i}] {inventory[i]}");
        //        //}


        //        //딕셔너리 컬렉션을 이용해서 구현해보세요
        //        //            === 상점 아이템 ===
        //        //회복 포션: 50골드
        //        //마나 포션: 40골드
        //        //강철 검: 500골드
        //        //가죽 갑옷: 300골드
        //        //마법 반지: 1000골드

        //        //✅ '강철 검' 구매 성공!
        //        //남은 골드: 100

        //        Console.InputEncoding = Encoding.UTF8;
        //        Console.OutputEncoding = Encoding.UTF8;
        //        Dictionary<string, int> shopItems = new Dictionary<string, int>()
        //        {
        //            {"회복 포션", 50 },
        //            {"마나 포션", 40 },
        //            {"강철 검", 500 },
        //            {"가죽 갑옷", 300 },
        //            {"마법 반지", 1000 }
        //        };

        //        int playerGold = 600;
        //        Console.WriteLine("=== 상점 아이템 ===");
        //        foreach (var item in shopItems)
        //        {
        //            Console.WriteLine($"{item.Key}: {item.Value}골드");
        //        }
        //        Console.WriteLine();

        //        // 구매 시나리오: '강철 검' 구매를 시도하고 결과 출력
        //        string wantedItem = "강철 검";
        //        int price;
        //        if (shopItems.TryGetValue(wantedItem, out price))
        //        {
        //            if (playerGold >= price)
        //            {
        //                playerGold -= price;
        //                Console.WriteLine($"✅ '{wantedItem}' 구매 성공!");
        //                Console.WriteLine($"남은 골드: {playerGold}");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"❌ '{wantedItem}' 구매 실패 - 골드 부족 (필요: {price}, 보유: {playerGold})");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine($"❌ '{wantedItem}'은(는) 상점에 없습니다.");
        //        }

        //        // 콘솔이 바로 닫히지 않도록 대기
        //        Console.WriteLine();
        //        Console.WriteLine("아무 키나 누르면 종료합니다...");
        //        Console.ReadKey();




        //    }
    }
}
