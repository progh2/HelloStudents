using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents
{
    class Student3105Kim : StudentBase
    {
        public override string Hello()
        {
            return "안녕? 나는 " + this + "이야!!!";          // this -> return에 있으면 ToString()을 출력한다.
        }
    }
}
