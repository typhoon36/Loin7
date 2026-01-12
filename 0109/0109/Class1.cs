using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0109
{
    internal class Class1
    {
        //    static void Main(string[] args)
        //    {
        //        //// === 일일 퀘스트 진행도 ===
        //        ////고블린: 5 / 5 ✅ 완료
        //        ////오크: 3 / 5 ⏳ 진행중
        //        ////슬라임: 8 / 5 ✅ 완료
        //        ////드래곤: 2 / 5 ⏳ 진행중
        //        ////좀비: 7 / 5 ✅ 완료



        //        //Console.InputEncoding = Encoding.UTF8;
        //        //Console.OutputEncoding = Encoding.UTF8;
        //        ////몬스터 처치 기록
        //        //Console.WriteLine("=== 일일 퀘스트 진행도 ===");
        //        //int[] dailyKills = { 5, 3, 8, 2, 7 };
        //        //string[] monsterTypes = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
        //        //int requiredKills = 5;

        //        //for (int i = 0; i < dailyKills.Length; i++)
        //        //{
        //        //    string status = dailyKills[i] >= requiredKills ? "✅ 완료" : "⏳ 진행중";
        //        //    Console.WriteLine($"{monsterTypes[i]}: {dailyKills[i]}/{requiredKills} {status}");
        //        //}


        //        //int[] scores = { 85, 92, 78, 95, 88 };

        //        ////배열 길이
        //        //Console.WriteLine("총 점수 개수: " + scores.Length);

        //        ////배열 순회
        //        //Console.WriteLine("개별 점수");
        //        //for (int i = 0; i < scores.Length; i++)
        //        //{
        //        //    Console.WriteLine($"플레이어 {i + 1} : {scores[i]}점");
        //        //}


        //        ////합계 계산
        //        //int sum = 0;

        //        //for (int i = 0; i < scores.Length; i++)
        //        //{
        //        //    sum += scores[i];
        //        //}

        //        //Console.WriteLine($"총점 : {sum}점");
        //        //Console.WriteLine($"평균 : {(float)sum / (float)scores.Length}점");


        //        ////최고점수 찾기
        //        //int maxScore = scores[0];

        //        //for (int i = 1; i < scores.Length; i++)
        //        //{
        //        //    if (scores[i] > maxScore)
        //        //    {
        //        //        maxScore = scores[i];
        //        //    }
        //        //}

        //        ////최저점수 찾기
        //        //int minScore = scores[0];
        //        //for (int i = 1; i < scores.Length; i++)
        //        //{
        //        //    if (scores[i] < minScore)
        //        //    {
        //        //        minScore = scores[i];
        //        //    }
        //        //}

        //        ////검색
        //        //int searchScore = 92;
        //        //int index = Array.IndexOf(scores, searchScore);
        //        //Console.WriteLine($"{searchScore}점의 위치: 인덱스 {index}");
        //        //Console.WriteLine("찾은값 : " + scores[index]);

        //        //            === 좌석 배치도 ===

        //        //[A1][A2][A3]
        //        //[B1][B2][B3]
        //        //[C1][C2][C3]
        //        //를 다차원 배열로 구현하고 출력하세요.

        //        //Console.WriteLine("=== 좌석 배치도 ===");
        //        //string[,] strings = new string[3, 3]
        //        //{
        //        //    { "A1", "A2", "A3" },
        //        //    { "B1", "B2", "B3" },
        //        //    { "C1", "C2", "C3" }
        //        //};

        //        //for (int i = 0; i < strings.GetLength(0); i++)
        //        //{
        //        //    for (int j = 0; j < strings.GetLength(1); j++)
        //        //    {
        //        //        Console.Write("[" + strings[i, j] + "]");
        //        //    }
        //        //    Console.WriteLine();
        //        //}

        //        //////            첫 번째 좌석: A1
        //        //////중앙 좌석: B2
        //        //////마지막 좌석: C3

        //        //Console.WriteLine("첫 번째 좌석: " + strings[0, 0]);
        //        //Console.WriteLine("중앙 좌석: " + strings[1, 1]);
        //        //Console.WriteLine("마지막 좌석: " + strings[2, 2]);

        //        //Console.InputEncoding = Encoding.UTF8;
        //        //Console.OutputEncoding = Encoding.UTF8;
        //        ////2D 게임맵
        //        //int[,] map = new int[5, 5]
        //        //{
        //        //    { 0,0,1,0,0},
        //        //    { 0,2,1,0,3},
        //        //    { 0,0,1,0,0},
        //        //    { 1,1,1,0,0},
        //        //    { 0,0,0,0,9},
        //        //};

        //        //Console.WriteLine("==던전맵==");
        //        //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");
        //        //Console.OutputEncoding = Encoding.UTF8;

        //        ////맵 출력
        //        //for (int y = 0; y < map.GetLength(0); y++)
        //        //{
        //        //    for (int x = 0; x < map.GetLength(1); x++)
        //        //    {
        //        //        switch (map[y, x])
        //        //        {
        //        //            case 0:
        //        //                Console.Write("⬜ ");
        //        //                break;
        //        //            case 1:
        //        //                Console.Write("⬛ ");
        //        //                break;
        //        //            case 2:
        //        //                Console.Write("👹 ");
        //        //                break;
        //        //            case 3:
        //        //                Console.Write("💎 ");
        //        //                break;
        //        //            case 9:
        //        //                Console.Write("🚪 ");
        //        //                break;
        //        //        }

        //        //    }
        //        //    Console.WriteLine();
        //        //}


        //        //            === 성적표 ===

        //        //이름  국어 영어  수학 과학  평균
        //        //━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        //        //김철수 85  90  88  92  88.8
        //        //이영희 78  85  90  87  85.0
        //        //박민수 92  88  95  90  91.3

        //        //=== 과목별 평균 ===
        //        //국어: 85.0점
        //        //영어: 87.7점
        //        //수학: 91.0점
        //        //과학: 89.7점




        //        Console.InputEncoding = Encoding.UTF8;
        //        Console.OutputEncoding = Encoding.UTF8;

        //        // === 성적표 ===
        //        string[] studentNames = { "김철수", "이영희", "박민수" };
        //        string[] subjects = { "국어", "영어", "수학", "과학" };

        //        // 2차원 배열: 행 = 학생, 열 = 과목
        //        int[,] scores = new int[3, 4]
        //        {
        //            { 85, 90, 88, 92 },
        //            { 78, 85, 90, 87 },
        //            { 92, 88, 95, 90 }
        //        };

        //        //출력(표 헤더)
        //        Console.WriteLine("            === 성적표 ===\n");
        //        Console.Write("이름  ");
        //        for (int s = 0; s < subjects.Length; s++)
        //        {
        //            Console.Write($" {subjects[s],3}");
        //        }
        //        Console.WriteLine("  평균");
        //        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");


        //        //학생이름과 점수 출력
        //        for (int i = 0; i < studentNames.Length; i++)
        //        {
        //            double sum = 0;
        //            Console.Write($"{studentNames[i],-6}");
        //            for (int j = 0; j < subjects.Length; j++)
        //            {
        //                Console.Write($" {scores[i, j],3}");
        //                sum += scores[i, j];
        //            }

        //            double avg = sum / subjects.Length;
        //            Console.WriteLine($"  {avg:0.0}");
        //        }

        //        //과목별 평균 계산 및 출력
        //        Console.WriteLine("\n=== 과목별 평균 ===");
        //        for (int j = 0; j < subjects.Length; j++)
        //        {
        //            double subjSum = 0;
        //            for (int i = 0; i < studentNames.Length; i++)
        //            {
        //                subjSum += scores[i, j];
        //            }

        //            double subjAvg = subjSum / studentNames.Length;
        //            Console.WriteLine($"{subjects[j]}: {subjAvg:0.0}점");
        //        }

        //    }



    }
}


