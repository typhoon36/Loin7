using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0115_TRPG
{
    public class Monster
    {
        public Info m_Monster;

        public void SetDamage(int iAttack) { m_Monster.iHp = iAttack; }

        public void SetMonster(Info monster) { m_Monster = monster; }
        public Info GetMonster() { return m_Monster; }

        public void Render()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("몬스터 이름 : " + m_Monster.strName);
            Console.WriteLine("체력 : " + m_Monster.iHp + "\t공격력 : " + m_Monster.iAttack);
        }



    }
}
