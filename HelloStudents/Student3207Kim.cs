using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents
{
    class Student3207Kim : StudentBase
    {
        public override string Hello()
        {
            return "안녕 나는 " + this + "입니다.";
        }
    }
}
