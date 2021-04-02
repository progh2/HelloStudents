using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents
{
    abstract class StudentBase : IEquatable<StudentBase>, IComparable<StudentBase>
    {
        // 속성들 (멤버변수와 다름!)
        public string LastName { get; set; } //getter, setter 메서드 생성
        public string FirstName { get; set; }
        public int StudentNumber { get; set; }

        public int BaseYear { get; set; }

        // 오버라이드한 메서드
        public override string ToString()
        {
            return StudentNumber + " " + LastName +" " + FirstName;
        }

        // 구현해야 할 추상 메서드
        public abstract string Hello();

        // 같은지 비교하기 전에 비교 가능한 클래스인지 확인 후 같은지 비교하는 메서드
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            StudentBase objAsStudentBase = obj as StudentBase;
            if (objAsStudentBase == null) return false;
            else return Equals(objAsStudentBase);
        }

        // 비교를 위한 "같다" 재정의 메서드
        public bool Equals(StudentBase other)
        {
            if (other == null) return false;
            return (this.StudentNumber == other.StudentNumber);
        }

        // 정렬을 위한 비교 메서드
        public int CompareTo(StudentBase compareStudentBase)
        {
            // A null value means that this object is greater.
            if (compareStudentBase == null)
                return 1;

            else
                return this.StudentNumber.CompareTo(compareStudentBase.StudentNumber);
        }

        // 해시코드 재정의 - 학번 기준으로. 즉 같은 학번 학생은 있을 수 없다.
        public override int GetHashCode()
        {
            return BaseYear * 10000 + StudentNumber;
        }


    }
}
