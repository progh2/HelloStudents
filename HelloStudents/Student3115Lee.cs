namespace HelloStudents
{
    class Student3115Lee : StudentBase
    {
        public override string Hello()
        {
            return "안녕? 나는 " + this + "이야~~~~~~~~~~~~~~!";  //this는 this.ToString()과 같다. 
        }
    }
}
