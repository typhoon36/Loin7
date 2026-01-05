using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_1231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수
            // int
            //int age;
            //age = 25;

            //Console.WriteLine(age);

            //레벨 100을 변수를 이용해 출력
            //int level = 100;

            //Console.WriteLine(level);


            //리터럴
            //int number = 10; //정수 리터럴
            //double pi = 3.14; //실수  리터럴
            //char letter = 'A'; // 문자 리터럴
            //string name = "Alice"; // 문자열 리터럴

            //Console.WriteLine(number); // 출력: 10
            //Console.WriteLine(pi);     // 출력: 3.14
            //Console.WriteLine(letter); // 출력: A
            //Console.WriteLine(name);   // 출력: Alice



            //정수 + 리터럴
            //플레이 스코어 100
            //int PlayScore = 100;

            //실수(3.14) + 리터럴
            //double Pi = 3.14;


            //문자 + 리터럴
            //char Letter = 'A';


            //문자열 + 리터럴(플레이어 이름: 홍길동)
            //string PlayerName = "홍길동";

            //출력
            //Console.WriteLine(PlayScore);
            //Console.WriteLine(Pi);
            //Console.WriteLine(Letter);
            //Console.WriteLine(PlayerName);

            ////형식이 같은 변수 여러개 한번에 선언
            //int x = 10, y = 20, z = 30;

            ////출력
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //int age = 20;
            //Console.WriteLine("나이: {0}", age);

            //string name = "철수";
            //Console.WriteLine("이름: {0}, 나이: {1}", name, age);





            //아래와 같은 방식으로 출력
            //Console.WriteLine("나이: {0}", age);

            //Console.WriteLine("이름: {0}, 나이: {1}", name, age);

            //Console.WriteLine($"X좌표: {posX}, Y좌표: {PosY}, Z좌표: {PosZ}");


            //int posX = 0, PosY = 50, PosZ = 100;
            ////출력
            //Console.WriteLine("X좌표: {0}, Y좌표: {1}, Z좌표: {2}", posX, PosY, PosZ);
            //Console.WriteLine($"X좌표: {posX}, Y좌표: {PosY}, Z좌표: {PosZ}");
            //Console.WriteLine("X좌표: " + posX + ", Y좌표: " + PosY + ", Z좌표: " + PosZ);

            ////RGB 색상 값도 변수로 선언 후 출력
            //int R = 255, G= 128, B = 0;
            //Console.WriteLine("R: {0}, G: {1}, B: {2}", R, G, B);

            //Console.WriteLine($"R: {R}, G: {G}, B: {B}");
            //Console.WriteLine("R: " + R + ", G: " + G + ", B: " + B);



            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                게임   시작                  ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");



            int Level = 6;
            int MaxHp = 1288;
            int ATK = 66;
            int DEF = 81;
            int ElementalMastery = 0;
            int MaxStamina = 100;


            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
           Console.WriteLine($"┃   Level / {Level}                                 ┃");
           Console.WriteLine($"┃   MaxHp / {MaxHp}                              ┃");
           Console.WriteLine($"┃   ATK / {ATK}                                  ┃");
           Console.WriteLine($"┃   DEF / {DEF}                                  ┃");
           Console.WriteLine($"┃   DEF / {DEF}                                  ┃");
           Console.WriteLine($"┃   ElementalMastery / {ElementalMastery}                      ┃");
           Console.WriteLine($"┃   MaxStamina / {MaxStamina}                          ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");





        }
    }


  




}
