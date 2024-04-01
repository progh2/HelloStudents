namespace HelloStudents
{
    class Student3102Kang : StudentBase
    {
        public override string Hello()
        {
            //this 는 this.Tostring이랑 같음
            return "하이 나는 " + this + "이지렁 ㅋ";
        }
    }
}
