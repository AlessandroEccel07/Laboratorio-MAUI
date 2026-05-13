using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.GetStudents();

            var es1 = students.Where(n => n.Grade >= 70).ToList();
            var es2 = students.Where(n => n.Branch=="Informatica").ToList();
            var es3 = students.Any(n => n.Grade == 100);
            var es4 = students.All(n => n.Grade > 40);
            var es5 = students.FirstOrDefault(n=> n.Branch=="Telecomunicazioni").ToString();
            var es6 = students.SingleOrDefault(n=>n.ID==1001).ToString();

            var es7 = students.Select(n=>n.Name).ToList();
            var es8 = students.Select(n => n.Name).ToList();
            foreach(String x in es8)
            {
                Console.Write(x);
            }

        }
    }
}
