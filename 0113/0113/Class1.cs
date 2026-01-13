using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0113
{
    ////캐릭터 클래스 정의
    //class Character
    //{

    //    private string _name;
    //    private int _level;
    //    private int _hp;
    //    private int _maxHP;
    //    private int _mp;
    //    private int _maxMP;


    //    public string Name
    //    {
    //        get => _name;
    //        set => _name = value ?? string.Empty;
    //    }

    //    public int Level
    //    {
    //        get => _level;
    //        set => _level = value < 1 ? 1 : value;
    //    }

    //    public int HP
    //    {
    //        get => _hp;
    //        set
    //        {
    //            _hp = value;
    //            if (_hp < 0) _hp = 0;
    //            if (_maxHP > 0 && _hp > _maxHP) _hp = _maxHP;
    //        }
    //    }

    //    public int MaxHP
    //    {
    //        get => _maxHP;
    //        set
    //        {
    //            _maxHP = value < 1 ? 1 : value;
    //            if (_hp > _maxHP) _hp = _maxHP;
    //        }
    //    }

    //    public int MP
    //    {
    //        get => _mp;
    //        set
    //        {
    //            _mp = value;
    //            if (_mp < 0) _mp = 0;
    //            if (_maxMP > 0 && _mp > _maxMP) _mp = _maxMP;
    //        }
    //    }

    //    public int MaxMP
    //    {
    //        get => _maxMP;
    //        set
    //        {
    //            _maxMP = value < 0 ? 0 : value;
    //            if (_mp > _maxMP) _mp = _maxMP;
    //        }
    //    }

    //    // 메서드 (Method): 클래스의 기능
    //    public void ShowInfo()
    //    {
    //        Console.InputEncoding = Encoding.UTF8;
    //        Console.OutputEncoding = Encoding.UTF8;
    //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
    //        Console.WriteLine($"이름: {Name}");
    //        Console.WriteLine($"레벨: {Level}");
    //        Console.WriteLine($"HP: {HP}/{MaxHP}");
    //        Console.WriteLine($"MP: {MP}/{MaxMP}");
    //        Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
    //    }

    //    public void TakeDamage(int damage)
    //    {
    //        HP -= damage; // 프로퍼티로 변경 시 유효성 검사 자동 적용

    //        Console.WriteLine($"⚔️ {Name}이(가) {damage} 데미지를 받았습니다!");
    //        Console.WriteLine($"   남은 HP: {HP}/{MaxHP}");
    //        Console.InputEncoding = Encoding.UTF8;
    //        Console.OutputEncoding = Encoding.UTF8;
    //    }

    //    public void Heal(int amount)
    //    {
    //        HP += amount; // 프로퍼티로 변경 시 최대 HP 검사 적용

    //        Console.WriteLine($"💚 {Name}의 HP가 {amount} 회복되었습니다!");
    //        Console.WriteLine($"   현재 HP: {HP}/{MaxHP}");
    //        Console.InputEncoding = Encoding.UTF8;
    //        Console.OutputEncoding = Encoding.UTF8;
    //    }
    //}

    //internal class Class1
    //{
    //    static void Main(string[] args)
    //    {
    //        Character player1 = new Character();


    //        player1.Name = "홍길동";
    //        player1.Level = 10;
    //        player1.MaxHP = 150;
    //        player1.HP = 150;
    //        player1.MaxMP = 80;
    //        player1.MP = 80;


    //        player1.ShowInfo();

    //        player1.TakeDamage(50);

    //        player1.Heal(30);

    //        Character player2 = new Character();
    //        player2.Name = "김영희";
    //        player2.Level = 15;
    //        player2.MaxHP = 200;
    //        player2.HP = 200;
    //        player2.MaxMP = 120;
    //        player2.MP = 120;

    //        player2.ShowInfo();
    //    }
    //}
}

