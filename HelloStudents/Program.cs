using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStudents     // namespace  패키지
{
    class Program
    {
        static void Main(string[] args)             // 메서드 이름 대문자
        {
            List<StudentBase> students = new List<StudentBase>();

            /*
             *  1. StudentBase를 상속받은 Student3099Ham.cs 같은 클래스를 생성 후 Hello 메서드를 자신의 스타일로 수정해보세요.
             *  2. Program.cs의 Main 메서드에 자신의 학번 위치에 1.에서 생성한 클래스의 
             *     객체를 생성해서 추가하는 코드를 넣으세요.
             */
            // 3099
            students.Add(
                new Student3099Ham()
                {
                    FirstName = "기훈", LastName = "함",
                    StudentNumber = 3099, BaseYear = 2020
                });
            // 3101
            // 3102
            // 3103
            // 3104
            // 3105
            students.Add(
                new Student3105Kim()
                {
                    FirstName = "솔민",
                    LastName = "김",
                    StudentNumber = 3105,
                    BaseYear = 2021
                });
            // 3106
            // 3107
            // 3108
            // 3109
            // 3110
            // 3111
            // 3112
            // 3113
            // 3114
            // 3115
            // 3117
            // 3118
            // 3119
            // 3120

            // 3201
            // 3202
            // 3203
            // 3204
            // 3205
            // 3206
            // 3207
            // 3208
            // 3209
            // 3210
            // 3211
            // 3212
            // 3213
            // 3214
            // 3215
            // 3217
            // 3218
            // 3219
            // 3220

            // 학번 순으로 정렬
            students.Sort();

            // 명단 출력
            foreach( StudentBase student in students){
                Console.WriteLine(student.Hello());
            }
        }
    }
}
