using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents
{
    class Student3104Kim : StudentBase
    {
        public override string Hello()
        {
            return "안녕? 나는 " + this + "님이셔라!";
        }
    }
}
