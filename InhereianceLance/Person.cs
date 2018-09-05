using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhereianceLance
{
    public abstract class Person
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
             
        public string LastName { get; set; }

        public Person(string firstName,string mid,string last)
        {
            this.FirstName = firstName;
            MiddleName = mid;
            LastName = last;
        }

        public virtual void SayFullName()
        {
            Console.WriteLine($"{FirstName}, {MiddleName} ,{LastName}");
        }

        public void SayFirstName()
        {
            Console.WriteLine($"{FirstName}");
        }

        //abstract - ключ. слово что метод обязан переопереленныым
        // отдельно у каждого наследника
        public abstract void SayPosition();



    }
}
