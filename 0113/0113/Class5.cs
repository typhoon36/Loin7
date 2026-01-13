using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0113
{
    ////    프로퍼티 연습 문제(쉬운 난이도)
    ////📝 문제 1: 학생 성적 관리 시스템
    ////문제 설명
    ////Student 클래스를 만들어 학생의 성적을 관리하세요.

    ////요구사항
    ////name (이름) - 읽기 전용 프로퍼티
    ////score (점수) - 0~100 사이의 값만 허용하는 프로퍼티
    ////Grade (등급) - 점수에 따라 자동 계산되는 읽기 전용 프로퍼티
    ////90점 이상: "A"
    ////80점 이상: "B"
    ////70점 이상: "C"
    ////60점 이상: "D"
    ////60점 미만: "F"


    //class Student
    //{
    //    // 필드 선언
    //    private int _score;

    //    // Name 프로퍼티 (읽기 전용)
    //    public string Name { get; }

    //    // Score 프로퍼티 (0~100 검증)
    //    public int Score
    //    {
    //        get { return _score; }
    //        set
    //        {
    //            if (value > 100)
    //                _score = 100;
    //            else if (value < 0)
    //                _score = 0;
    //            else
    //                _score = value;
    //        }
    //    }

    //    // Grade 프로퍼티 (자동 계산, 읽기 전용)
    //    public string Grade
    //    {
    //        get
    //        {
    //            if (_score >= 90) return "A";
    //            if (_score >= 80) return "B";
    //            if (_score >= 70) return "C";
    //            if (_score >= 60) return "D";
    //            return "F";
    //        }
    //    }

    //    // 생성자
    //    public Student(string studentName)
    //    {
    //        Name = studentName;
    //        _score = 0;
    //    }

    //    // 정보 출력
    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"━━━━━━━━━━━━━━━━");
    //        Console.WriteLine($"이름: {Name}");
    //        Console.WriteLine($"점수: {Score}점");
    //        Console.WriteLine($"등급: {Grade}");
    //        Console.WriteLine($"━━━━━━━━━━━━━━━━");
    //    }
    //}



    //internal class Class5
    //{
    //    static void Main(string[] args)
    //    {
    //        Student student = new Student("홍길동");

    //        student.Score = 95;
    //        student.ShowInfo();

    //        Console.WriteLine();

    //        student.Score = 75;
    //        student.ShowInfo();

    //        Console.WriteLine();

    //        // 잘못된 값 입력 시도
    //        // student.Score = 150;  // 100으로 제한되어야 함
    //        student.Score = -10;  // 0으로 제한되어야 함
    //        student.ShowInfo();
    //    }
    //}
}
