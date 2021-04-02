using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents
{
    class Student3215Choi : StudentBase
    {
        public override string Hello()
        {
            return this + "는 지금 아주 졸린 상태 입니다.";
        }
    }
}
