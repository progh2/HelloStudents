using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents
{
    class Student3106Kim : StudentBase
    {
        public override string Hello()
        {
            //this는 아마도 toString
            return "안녕? 나는 " + this + "이라구!";
        }
    }
}
