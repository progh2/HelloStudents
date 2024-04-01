namespace HelloStudents
{
    class Student3109Kim : StudentBase  // 추상메소드 추가
    {
        public override string Hello()
        {
            return "안녕? 나는" + this + "님이셔라!";   // this.ToString과 같음
        }
    }
}
