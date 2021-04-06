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

            students.Add(
                new Student3102Kang()
                {
                    FirstName = "은별",
                    LastName = "강",
                    StudentNumber = 3102,
                    BaseYear = 2020
                });
            // 3103
            students.Add(
               new Student3103Kim()
               {
                   FirstName = "나은",
                   LastName = "김",
                   StudentNumber = 3103,
                   BaseYear = 2021
               });
            // 3104
            students.Add(
                new Student3104Kim()
                {
                    FirstName = "민경",
                    LastName = "김",
                    StudentNumber = 3104,
                    BaseYear = 2021
                });

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
            students.Add(
                 new Student3106Kim()
                 {
                     FirstName = "수현",
                     LastName = "김",
                     StudentNumber = 3106,
                     BaseYear = 2021
                 });
            // 3107
            students.Add(
                new Student3107Kim()
                {
                    FirstName = "정아", LastName = "김",
                    StudentNumber = 3107, BaseYear = 2019
                });
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
            students.Add(          
                new Student3109Kim()
                {
                    FirstName = "TaeYoung",
                    LastName = "Kim",
                    StudentNumber = 3109,
                });
            // 3110
            students.Add(
                new Student3110Ryu()
                {
                    FirstName = "현서",
                    LastName = "류",
                    StudentNumber = 3110,
                    BaseYear = 2021
                });
            // 3111
            students.Add(
                new Student3111Shin()
                {
                    FirstName = "잎새", LastName = "신",
                    StudentNumber = 3111, BaseYear = 2019
                });
            // 3112
            students.Add(
                new Student3112Oh()
                {
                    FirstName = "정민",
                    LastName = "오",
                    StudentNumber = 3112,
                    BaseYear = 2021
                });
            // 3113
            students.Add(
                new Student3113Lee()
                {
                    FirstName = "수빈",
                    LastName = "이",
                    StudentNumber = 3113, 
                    BaseYear = 2019
                });
            // 3114
            students.Add(
                new Student3114Lee()
                {
                    FirstName = "연지",
                    LastName = "이",
                    StudentNumber = 3114,
                    BaseYear = 2019
                });
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
            students.Add(
                new Student3099Ham()
                {
                    FirstName = "MinJung",
                    LastName = "Choi",
                    StudentNumber = 3117,
                    BaseYear = 2021
                });
            students.Add(
                new Student3099Ham()
                {
                    FirstName = "민정",
                    LastName = "최",
                    StudentNumber = 3117,
                    BaseYear = 2021
                });
            // 3118
            students.Add(          
                new Student3118Choi()
                {
                    FirstName = "수민",
                    LastName = "최",
                    StudentNumber = 3118,
                });                  
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
            students.Add(
               new Student3209Kim()
               {
                   FirstName = "진진",
                   LastName = "문",
                   StudentNumber = 3209,
                   BaseYear = 2021
               });
            // 3210
            // 3211
            students.Add(
                new Student3211Son()
                {
                    FirstName = "지우",
                    LastName = "손",
                    StudentNumber = 3211,
                    BaseYear = 2021
                });
            // 3212
            // 3213
            // 3214
            students.Add(
                new Student3214Lee()
                {
                    FirstName = "숙민",
                    LastName = "이",
                    StudentNumber = 3214,
                    BaseYear = 2021
                });
            // 3215
            // 3217
            // 3218
            // 3219
            // 3220
            // 3299
            students.Add(
                new Student3299Ham()
                {
                    FirstName = "기훈",
                    LastName = "함",
                    StudentNumber = 3299,
                    BaseYear = 2021
                });

            // 학번 순으로 정렬
            students.Sort();

            // 명단 출력
            foreach( StudentBase student in students){
                Console.WriteLine(student.Hello());
            }
        }
    }
}
