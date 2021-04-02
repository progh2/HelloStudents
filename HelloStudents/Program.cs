// using은 java의 import 같은 역할
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //import

// namespace는 java의 패키지 같은 역할
namespace HelloStudents
{
    class Program
    {
        static void Main(string[] args)
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
            students.Add(
                new Student3199Ham()
                {
                    FirstName = "Gihun",
                    LastName = "Ham",
                    StudentNumber = 3199,
                    BaseYear = 2021
                });
            // 3101
            // 3102
            // 3103
            students.Add(
               new Student3103Kim()
               {
                   FirstName = "나은",
                   LastName = "김",
                   StudentNumber = 3103,
                   BaseYear = 2020
               });
            // 3104
            // 3105     
            // 3106
            // 3107
            // 3108
            students.Add(
                new Student3108Kim()
                {
                    FirstName = "지영",
                    LastName = "김",
                    StudentNumber = 3108,
                    BaseYear = 2021
                });
            // 3109
            // 3110
            // 3111
            // 3112
            // 3113
            // 3114
            // 3115
            students.Add(
                new Student3115Lee()
                {
                    FirstName = "지민",
                    LastName = "이",
                    StudentNumber = 3115,
                    BaseYear = 2021
                });
            // 3116
            students.Add(
                new Student3116JO()
                {
                    FirstName = "서영", LastName = "조",
                    StudentNumber = 3116, BaseYear = 2020
                });
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
            students.Add(
                new Student3208Kim()
                {
                    FirstName = "연희",
                    LastName = "김",
                    StudentNumber=3208,
                    BaseYear=2021
                }
            );
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
