//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{


//    abstract class Unit
//    {
//        protected string Name;
//        protected int Hp;
//        protected int MaxHp;
//        protected int MoveSpeed;

//        public Unit(string name, int hp, int moveSpeed)
//        {
//            Name = name;
//            Hp = hp;
//            MaxHp = hp;
//            MoveSpeed = moveSpeed;
//        }


//        public abstract void PrintInfo();

//        protected void PrintHeader(string job)
//        {
//            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
//            Console.WriteLine($"[{job}]");
//            Console.Write($"{Name}");
//            Console.WriteLine($"HP: {Hp}/{MaxHp}");
//        }

//        protected void PrintFooter()
//        {
//            Console.WriteLine($"이동속도: {MoveSpeed}");
//            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
//            Console.WriteLine();
//        }
//    }


//    class Warrior : Unit
//    {
//        int Attack;
//        int Defense;

//        public Warrior(string name) : base(name, 200, 5)
//        {
//            Attack = 80;
//            Defense = 50;
//        }

//        public override void PrintInfo()
//        {
//            PrintHeader("전사");
//            Console.WriteLine($"공격력: {Attack}");
//            Console.WriteLine($"방어력: {Defense}");
//            PrintFooter();
//        }
//    }


//    class Mage : Unit
//    {
//        int MagicPower;
//        int Mana;

//        public Mage(string name) : base(name, 120, 4)
//        {
//            MagicPower = 150;
//            Mana = 100;
//        }

//        public override void PrintInfo()
//        {
//            PrintHeader("마법사");
//            Console.WriteLine($"마력: {MagicPower}");
//            Console.WriteLine($"마나: {Mana}");
//            PrintFooter();
//        }
//    }

//    class Archer : Unit
//    {
//        int Attack;
//        int Arrow;

//        public Archer(string name) : base(name, 150, 6)
//        {
//            Attack = 100;
//            Arrow = 50;
//        }

//        public override void PrintInfo()
//        {
//            PrintHeader("궁수");
//            Console.WriteLine($"공격력: {Attack}");
//            Console.WriteLine($"화살: {Arrow}");
//            PrintFooter();
//        }
//    }

//    internal class Class2
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("=== 유닛 생성 ===\n");

//            Unit warrior = new Warrior("홍길동");
//            Unit mage = new Mage("김마법");
//            Unit archer = new Archer("이궁수");

//            warrior.PrintInfo();
//            mage.PrintInfo();
//            archer.PrintInfo();
//        }
//    }
//}
