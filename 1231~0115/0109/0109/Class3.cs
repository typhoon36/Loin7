using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0109
{
    internal class Class3
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴


        private struct Missile
        {
            public int x;
            public int y;
            public Missile(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        private static readonly List<Missile> missiles = new List<Missile>();

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정
            Console.SetBufferSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)


            string[] player = new string[]
            {
                    "->",
                    ">>>",
                    "->"
            }; //배열 문자열로 그리기


            int playerX = 0;
            int playerY = 12;


            Console.CursorVisible = false; //콘솔창 커서 안보이게하기


            //지연방법 시간을 계산해서 1초 루프
            int dwTime = Environment.TickCount;   // 1/1000 초가 흐릅니다.


            while (true)
            {
                //1초루프
                if (dwTime + 10 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    //키역영
                    int pressKey; //정수형 변수 선언 키값 받을거임

                    if (Console.KeyAvailable) //키가 눌렸는지 체크
                    {
                        pressKey = _getch(); //요렇게 하면
                        if (pressKey == 224)
                            pressKey = _getch(); //요렇게 하면


                        switch (pressKey)
                        {

                            case 72:  //위쪽방향 아스키코드                    
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:
                                //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:
                                //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80: //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32: //스페이스바
                                     //미사일 발사: 플레이어 중앙(중간 라인)에서 오른쪽으로 출발
                                int startX = playerX + player[1].Length;
                                int startY = playerY + 1;
                                missiles.Add(new Missile(startX, startY));
                                break;
                        }


                    }
                    //미사일 이동 및 제거
                    for (int i = missiles.Count - 1; i >= 0; i--)
                    {
                        var m = missiles[i];
                        m.x += 1; //오른쪽으로 이동
                        if (m.x >= Console.BufferWidth) //화면 끝 도달 시 제거
                        {
                            missiles.RemoveAt(i);
                        }
                        else
                        {
                            missiles[i] = m;
                        }
                    }

    
                    foreach (var m in missiles)
                    {
                        if (m.y >= 0 && m.y < Console.BufferHeight && m.x >= 0 && m.x < Console.BufferWidth)
                        {
                            Console.SetCursorPosition(m.x, m.y);
                            Console.Write("-"); //미사일 문자
                        }
                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }

                }


            }


        }
    }
}
