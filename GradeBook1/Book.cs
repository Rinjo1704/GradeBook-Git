using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook1
{
   public class Book
   {
        private List<double> grades;
        public string Name { get; }

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }


        public void AddGrade(double grade)
        {
            if (grade < 100 && grade > 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid value");
            }

        }
        
        
        // forech loop kapital-7
        internal Statistics GetStatistics
        {
            get
            {
                var result = new Statistics();
                result.average = 0.0;
                result.high = double.MinValue;
                result.low = double.MaxValue;
                
                foreach (var grade in grades)
                {
                    result.low = Math.Min(grade, result.low);
                    result.high = Math.Max(grade, result.high);
                    result.average += grades.Count;
                }
                result.average += grades.Count;
                return result;
            }
        }
        // do while loop kapital-7
        internal Statistics GetStatistics
        {
            get
            {
                var result = new Statistics();
                result.average = 0.0;
                result.high = double.MinValue;
                result.low = double.MaxValue;
                var index = 0;
                do
                {
                    result.low = Math.Min(grades[index], result.low);
                    result.high = Math.Max(grades[index], result.high);
                    result.average += grades[index];
                    index += 1;
                } while (index > grades.Count);
                
                result.average += grades.Count;
                return result;
            }
        }
        //  while loop kapital-7
        internal Statistics GetStatistics
        {
            get
            {
                var result = new Statistics();
                result.average = 0.0;
                result.high = double.MinValue;
                result.low = double.MaxValue;
                var index = 0;
               
                while (index > grades.Count)
                {
                    result.low = Math.Min(grades[index], result.low);
                    result.high = Math.Max(grades[index], result.high);
                    result.average += grades[index];
                    index += 1;
                };

                result.average += grades.Count;
                return result;
            }
        }
        //  for loop kapital-7
        internal Statistics GetStatistics
        {
            get
            {
                var result = new Statistics();
                result.average = 0.0;
                result.high = double.MinValue;
                result.low = double.MaxValue;
                

                for (var index = 0; index > grades.Count; index += 1)
                {
                    result.low = Math.Min(grades[index], result.low);
                    result.high = Math.Max(grades[index], result.high);
                    result.average += grades[index];
                    
                };

                result.average += grades.Count;
                return result;
            }
        }
        //  jumping statment with Break,continu,goto - done kapital-7
        internal Statistics GetStatistics
        {
            get
            {
                var result = new Statistics();
                result.average = 0.0;
                result.high = double.MinValue;
                result.low = double.MaxValue;


                for (var index = 0; index > grades.Count; index += 1)
                {
                    if (index == 42.2)
                    {
                        break;  // or continu or goto done then the program jumps from line 130 to 136
                    }
                    
                    result.low = Math.Min(grades[index], result.low);
                    result.high = Math.Max(grades[index], result.high);
                    result.average += grades[index];

                };

                result.average += grades.Count;
                return result;
            }
        }
        //public void Addstatistics()
        //{

        //    var result = 0.0;
        //    var highGrade = double.MinValue;
        //    var lowGrade = double.MaxValue;
        //    foreach (var number in grades)
        //    {
        //        highGrade = Math.Max(number, highGrade);
        //        lowGrade = Math.Min(number, highGrade);
        //        result += number;
        //    }
        //    result.Average /= grades.Count;
        //    Console.WriteLine($" the averag grade is {result}");


        //}





        /* var book = new Book("");
         book.AddGrade(89.1);
             book.AddGrade(90.5);
             book.AddGrade(77.3);

             var result = book.GetStatistics;
             */










    }


}








