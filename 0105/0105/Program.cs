using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0105
{
    internal class Program
    {
        //static void Main(string[] args)
        //{

        //    //// 상수: 값을 변경할 수 없는 변수
        //    //const double Pi = 3.14159; // 상수 Pi 선언 및 초기화
        //    //const int MaxScore = 100;  // 정수형 상수 선언
        //    //                           // 출력
        //    //Console.WriteLine("Pi: " + Pi); // 출력: Pi: 3.14159
        //    //Console.WriteLine("Max Score: " + MaxScore); // 출력: Max Score: 100
        //    //// Pi = 3.14; // 오류 발생! 상수는 값을 변경할 수 없습니다.

        //    ////예제
        //    //const int _maxplayer = 100;
        //    //const int _startGold = 1000;
        //    //const string _version = "1.0.0";

        //    //Console.WriteLine("===게임 설정==");
        //    //Console.WriteLine("최대플레이어 : " + _maxplayer + "명");
        //    //Console.WriteLine("시작 골드 : " + _startGold + "Gold");
        //    //Console.WriteLine("버전" + _version);

        //    //// 숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
        //    //int integerNum = 10;      // 정수 데이터
        //    //float floatNum = 3.14f;   // 단정밀도 실수
        //    //double doubleNum = 3.14159; // 배정밀도 실수
        //    //Console.WriteLine(integerNum); // 출력: 10
        //    //Console.WriteLine(floatNum);   // 출력: 3.14
        //    //Console.WriteLine(doubleNum);  // 출력: 3.14159

        //    //// 정수 데이터 형식: 소수점이 없는 숫자를 표현
        //    //int intValue = -100;    // 4바이트 크기의 정수
        //    //long longValue = 1234567890L; // 8바이트 크기의 정수
        //    //Console.WriteLine(intValue);  // 출력: -100
        //    //Console.WriteLine(longValue); // 출력: 1234567890


        //    ////            | 타입 | 크기 | 범위 | 용도 |
        //    ////| ------| ------| ------| ------|
        //    ////| byte | 1바이트 | 0 ~255 | 작은 양수(나이, 레벨) |
        //    ////| sbyte | 1바이트 | -128 ~127 | 작은 정수 |
        //    ////| short | 2바이트 | -32,768 ~32,767 | 작은 정수 |
        //    ////| ushort | 2바이트 | 0 ~65,535 | 작은 양수 |
        //    ////| int | 4바이트 | -21억 ~21억 | 가장 많이 사용 |
        //    ////| uint | 4바이트 | 0 ~42억 | 큰 양수 |
        //    ////| long | 8바이트 | 매우 큰 범위 | 아주 큰 수 |
        //    ////| ulong | 8바이트 | 0 ~아주 큰 수 | 아주 큰 양수 |


        //    ////예제
        //    //byte level = 50;          // 0~255
        //    //short attack = 1500;      // -32,768 ~ 32,767
        //    //int gold = 1234567;
        //    //long experience = 9999999L;

        //    //Console.WriteLine("==캐릭터 정보");
        //    //Console.WriteLine("레벨: " + level);
        //    //Console.WriteLine("공격력: " + attack);
        //    //Console.WriteLine("골드: " + gold);
        //    //Console.WriteLine("경험치: " + experience);

        //    ////타입별 최대값 확인
        //    //Console.WriteLine("\n===타입별 최대값 ===");
        //    //Console.WriteLine("byte 최대값: " + byte.MaxValue);
        //    //Console.WriteLine("short 최대값: " + short.MaxValue);
        //    //Console.WriteLine("int 최대값: " + int.MaxValue);
        //    //Console.WriteLine("long 최대값: " + long.MaxValue);

        //    //// 부호 있는 정수: 음수와 양수를 모두 표현 가능
        //    //sbyte signedByte = -50;  // 1바이트 크기
        //    //short signedShort = -32000; // 2바이트 크기
        //    //int signedInt = -2000000000; // 4바이트 크기

        //    //Console.WriteLine(signedByte);   // 출력: -50
        //    //Console.WriteLine(signedShort);  // 출력: -32000
        //    //Console.WriteLine(signedInt);    // 출력: -2000000000

        //    //// 부호 없는 정수: 0 이상의 정수만 표현 가능
        //    //byte unsignedByte = 255;   // 1바이트 크기
        //    //ushort unsignedShort = 65000; // 2바이트 크기
        //    //uint unsignedInt = 4000000000; // 4바이트 크기
        //    //Console.WriteLine(unsignedByte);   // 출력: 255
        //    //Console.WriteLine(unsignedShort);  // 출력: 65000
        //    //Console.WriteLine(unsignedInt);    // 출력: 4000000000

        //    ////---1300
        //    //// 실수 데이터 형식: 소수점을 포함한 숫자를 표현
        //    //float singlePrecision = 3.14f;    // 단정밀도 실수 (4바이트)
        //    //double doublePrecision = 3.1415926535; // 배정밀도 실수 (8바이트)
        //    //decimal highPrecision = 3.1415926535897932384626433833m; // 고정밀도 (16바이트)

        //    //Console.WriteLine(singlePrecision); // 출력: 3.14
        //    //Console.WriteLine(doublePrecision); // 출력: 3.1415926535
        //    //Console.WriteLine(highPrecision);   // 출력: 3.141592653589793238462643 3833


        //    //// char 형식: 단일 문자를 표현
        //    //char letter = 'A';  // 문자 'A' 저장
        //    //char symbol = '#';  // 특수 기호 저장
        //    //char number = '9';  // 숫자 형태의 문자 저장 (문자 '9', 숫자 9 아님)

        //    //Console.WriteLine(letter);  // 출력: A
        //    //Console.WriteLine(symbol);  // 출력: #
        //    //Console.WriteLine(number);  // 출력: 9

         
        //    ////예제
        //    ////==캐릭터 능력치 ==
        //    ////이동속도 5.5f(float)
        //    ////공격속도 double 1.25
        //    ////아이템 가격 decimal 12.99

        //    //float moveSpeed = 5.5f;
        //    //double attackSpeed = 1.25;
        //    //decimal itemPrice = 12.99m;

        //    //Console.WriteLine("===캐릭터 능력치===");
        //    //Console.WriteLine("이동속도: " + moveSpeed);
        //    //Console.WriteLine("공격속도: " + attackSpeed);
        //    //Console.WriteLine("아이템 가격: " + itemPrice);

        //    //// string 형식: 여러 문자를 저장
        //    //string greeting = "Hello, World!";  // 문자열 저장
        //    //string name = "Alice";  // 이름 저장
        //    //Console.WriteLine(greeting); // 출력: Hello, World!
        //    //Console.WriteLine(name);     // 출력: Alice

        //    //예제
        //    //문자(char) 

        //    char grade  = 'A';
        //    char symbol = '★';
        //    //char number = '9';

        //    //문자열(string)
        //    string playerName = "Hero";
        //    string welcomeMessage = "Welcome to the game!";
        //    //string emptyString = "";

        //    Console.WriteLine("=== RPG Game");
        //    Console.WriteLine($"플레이어 : {playerName}");
        //    Console.WriteLine($"등급 : {grade}  {symbol}");
        //    Console.WriteLine(welcomeMessage);





        //}
    }
}
