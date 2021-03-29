using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents 
{
    class Student3112Oh : StudentBase // 상속
    {
        public override string Hello()
        {
            return "안녕? 나는 " + this.ToString() + "이야~ 만나서 반가워"; // this.ToString()을 this라고만 써도 괜찮다.
        }
    }
}
