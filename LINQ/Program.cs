using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;

namespace Itvdn_dotnet
{

    class Program
    {
        internal class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }

        }

        internal class Student2
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public List<string> Subjects { get; set; }
        }

        internal class Standard
        {
            public int StandardID { get; set; }
            public string StandardName { get; set; }
        }

        internal class Studenten
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public int StandardID { get; set; }
        }


        static void Main()
        {

            //Linq function

            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            var rez1 = from numbers in Num
                       where numbers > 3
                       select numbers;


            var rez2 = Num.Where(n => n > 3).ToList();

            int minimumNum = Num.Min();

            int MaximumNum = Num.Max();

            int Sum = Num.Sum();

            int Count = Num.Count();

            double Average = Num.Average();

            double AggregateSum = Num.Aggregate((a, b) => a + b);

            double AggregateMultiply = Num.Aggregate((a, b) => a * b);


            //Select


            int[] numbers3 = { 5, 4, 1, 3, 9, 8 };
            var numsPlusOne = from n in numbers3 select n;
            foreach (var i in numsPlusOne)
            {
                i.ToString();
            }

            //---------------------------------------------------------------

            List<Student> ObjStudent = new List<Student>()
            {
                  new Student() { StudentId = 1, Name = "Suresh", Marks = 500 },
                  new Student() { StudentId = 2, Name = "Rohini", Marks = 300 },
                  new Student() { StudentId = 3, Name = "Madhav", Marks = 400 },
                  new Student() { StudentId = 4, Name = "Sateesh", Marks = 550 },
                  new Student() { StudentId = 5, Name = "Praveen", Marks = 600 },
                  new Student() { StudentId = 6, Name = "Sudheer", Marks = 700 },
                  new Student() { StudentId = 7, Name = "Prasad", Marks = 550 }
             };

            var result = from s in ObjStudent
                         select new { SName = s.Name, SID = s.StudentId, SMarks = s.Marks };

            var result2 = ObjStudent.Select(student => new
            {
                SName = student.Name,
                SID = student.StudentId,
                SMarks = student.Marks
            });


            foreach (var item in result)
            {
                Console.WriteLine("The StudentName is {0} ID is {1} Marks is {2}", item.SName, item.SID, item.SMarks);
            }


            //SelectMany 


            List<Student2> ObjStudentMany = new List<Student2>()
             {
                  new Student2() { Name = "Ravi Varma", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
                  new Student2() { Name = "Vikram Sharma", Gender = "Male", Subjects = new List<string> { "Social Studies", "Chemistry" } },
                  new Student2() { Name = "Harish Dutt", Gender = "Male", Subjects = new List<string> { "Biology", "History", "Geography" } },
                  new Student2() { Name = "Akansha Wadhwani", Gender = "Female", Subjects = new List<string> { "English", "Zoology", "Botany" } },
                  new Student2() { Name = "Vikrant Seth", Gender = "Male", Subjects = new List<string> { "Civics", "Drawing" } }
              };

            var Subjects = ObjStudentMany.SelectMany(x => x.Subjects);

            foreach (var Subject in Subjects)
            {
                Console.WriteLine(Subject);
            }

            //---------------------------------------------------------------

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs = from a in numbersA from b in numbersB where a < b select new { a, b };
            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
            }

            //---------------------------------------------------------------

            IList<Studenten> studentList = new List<Studenten>() 
            {
                     new Studenten() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                     new Studenten() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                     new Studenten() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                     new Studenten() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                     new Studenten() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            IList<Standard> standardList = new List<Standard>() 
            {
                     new Standard(){ StandardID = 1, StandardName="Standard 1"},
                     new Standard(){ StandardID = 2, StandardName="Standard 2"},
                     new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };


            var studentNames = studentList.Where(s => s.Age > 18)
                              .Select(s => s)
                              .Where(st => st.StandardID > 0)
                              .Select(s => s.StudentName);

            var teenStudentsName = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select new { StudentName = s.StudentName };

            teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
           

            //------------------------------------------------------------------- 

            //Upper every  first letter in string 

            static string ToJadenCase(string phrase)
            {
                return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));
            }

            static string ToJadenCaseSimpl( string phrase)
            {
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
            }


            //Sum of two smallest numbers in array
            static int sumTwoSmallestNumbers(int[] n) => n.OrderBy(i => i).Take(2).Sum();



            //(6 kyu - https://www.codewars.com/) Splits the string into pairs of two characters. If the string contains an odd number
            //of characters then it should replace the missing second character of the final
            //pair with an underscore('_').
            static string[] Solution(string s)
            {
                return Enumerable.Range(0, (s.Length + 1) / 2)
                                 .Select(i => s[i * 2] + ((i * 2 + 1 < s.Length) ? s[i * 2 + 1].ToString() : "_"))
                                 .ToArray();
            }


            //(7 kyu - https://www.codewars.com/)
            //This function must return another function, which takes a single integer as an argument and returns a new array.
            //The returned array should consist of each of the elements from the first array multiplied by the integer.
            static Func<int, int[]> MultiplyAll(int[] arr) => (number) => { return arr.Select(x => x * number).ToArray(); };


            //(7 kyu - https://www.codewars.com/)
            //A Tidy number is a number whose digits are in non-decreasing order.
            static bool TidyNumber(int n) => $"{n}" == string.Concat($"{n}".OrderBy(c => c));


            //(7 kyu - https://www.codewars.com/)
            //For the given sequence of houses determine the sum that the boy will get. It is guaranteed that there will always be at least one 0 house on the path.            
            static int HouseNumbersSum(int[] inputArray) => inputArray.TakeWhile(x => x != 0).Sum();


            //Calculate Square Of Sum function https://exercism.org/
            static int CalculateSquareOfSum(int max) => (int)Math.Pow(Enumerable.Range(1, max).Sum(), 2);

            static int CalculateSumOfSquares(int max) => Enumerable.Range(1, max).Select(x => (int)Math.Pow(x, 2)).Sum();

        }

    }

    
}
