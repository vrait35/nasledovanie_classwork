using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhereianceLance
{
    public class Student:Person
    {      
        public string Group { get; set; }

        public Student() : base("1", "2", "3"){}

        public double AverageMark { get; set; }

        public Student(string firstName, string mid, string last, string gr,double avg)
           : base(firstName, mid, last)
        {
            Group = gr;
            AverageMark = avg;
        }

        public override string ToString()
        {
            return ($"{FirstName}    {MiddleName}{LastName}");
        }

        public override void SayPosition(){}
    }
}
