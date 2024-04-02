using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents
{
    internal class Student3212Lee : StudentBase
    {
        public override string Hello()
        {
            return "알로라! 나는 " + this + "라고 해.";
        }
    }
}
