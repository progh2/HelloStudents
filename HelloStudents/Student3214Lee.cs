using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents
{
    class Student3214Lee:StudentBase
    {
        public override string Hello()
        {
            return "안녕하세요~ 저는 " + this + "입니다.";
        }
    }
}
