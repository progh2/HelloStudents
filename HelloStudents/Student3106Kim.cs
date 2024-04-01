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
