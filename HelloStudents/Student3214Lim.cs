using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents
{
    internal class Student3214Lim : StudentBase
    {
        // c# : override 명시, 문자열은 소문자(string), 앞 글자는 대문자 ex) ToString(),Equals()..등등
        public override string Hello()
        {
            // this -> ToString() 변환
            return "안녕하세요구르트! 저는 " + this + "입니다람쥐";
        }
    }
}
