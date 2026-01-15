//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //추상클래스 상속을 받고있는친구는 추상메서드를 상속받아서 꼭 구현해야한다.
//    public abstract class Character
//    {
//        public int hp;

//        public abstract void Job();

//    }

//    public class Mage : Character
//    {
//        public override void Job()
//        {
//            Console.WriteLine("마법사선택");
//        }
//    }

//    public class Archer : Character
//    {
//        public override void Job()
//        {
//            Console.WriteLine("아처선택");
//        }
//    }


//    //public  class Character
//    //{
//    //    public int hp;

//    //    public virtual void Job() 
//    //    {
//    //        Console.WriteLine("직업함수");
//    //    }

//    //}

//    //public class Mage : Character
//    //{
//    //    public void Render()
//    //    {
//    //        Console.WriteLine("출력함수");
//    //    }
//    //}

//    internal class Class1
//    {
//        static void Main(string[] args)
//        {
//            //Mage mage = new Mage();
//            //mage.Job();
//            //Character ch = new Character(); //추상클래스는 객체생성 X
//            Character[] ch = new Character[2]; //배열준비

//            ch[0] = new Mage();
//            ch[1] = new Archer();


//            //수집형알피지 캐릭터 두개 뽑았다.
//            //그룹화 해서 출력하기 좋음
//            for (int i = 0; i < ch.Length; i++)
//            {
//                ch[i].Job();
//            }


//        }
//    }
//}
