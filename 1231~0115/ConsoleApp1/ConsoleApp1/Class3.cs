//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    인터페이스
//    interface IAttackable
//    {
//        void Attack(string target);
//        int GetAttackPower();
//    }


//    interface IDefendable
//    {
//        void Defend();
//        int GetDefendPower();
//    }




//    class Knight : IAttackable, IDefendable //알트 + 엔터
//    {

//        public string name;
//        public int attackPower;
//        public int defendPower;

//        public Knight()
//        {
//            name = "검사";
//            attackPower = 10;
//        }

//        public void Attack(string target)
//        {
//            Console.WriteLine($"검으로 {target}를 공격 했습니다.");

//        }

//        public void Defend()
//        {
//            Console.WriteLine("기사 방어모드");
//        }

//        public int GetAttackPower()
//        {
//            return attackPower;
//        }

//        public int GetDefendPower()
//        {
//            return defendPower;
//        }
//    }


//    class Mage : IAttackable
//    {
//        public string name;
//        public int attackPower;

//        public Mage()
//        {
//            name = "마법사";
//            attackPower = 15;
//        }

//        public void Attack(string target)
//        {
//            Console.WriteLine($"마법으로 {target}를 공격했습니다.");
//        }

//        public int GetAttackPower()
//        {
//            return attackPower;
//        }
//    }

//    internal class Class3
//    {
//        static void Main(string[] args)
//        {

//            Knight knight = new Knight();
//            Mage mage = new Mage();

//            knight.Attack("오크");
//            knight.Defend();
//            Console.WriteLine($"기사 공격력: {knight.GetAttackPower()}");

//            mage.Attack("오우거");
//            Console.WriteLine($"마법사 공격력: {mage.GetAttackPower()}");
//        }
//    }

//}