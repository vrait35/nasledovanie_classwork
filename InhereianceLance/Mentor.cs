using System;

namespace InhereianceLance
{
    public class Mentor:Person
    {       
        public string SubjectName { get; set; }

        public Mentor() : base("", "", "") { }

        public Mentor(string firstName, string mid, string last,string subj)
            :base(firstName,mid,last)
        {
            SubjectName = subj;
        }

        public override void SayFullName()
        {
            Console.WriteLine($"{FirstName}, {MiddleName} ,{LastName}");
        }
        
        //new -типа  уточняем  что он переопередяет метод  virtual
        public new void SayFirstName()
        {
            Console.WriteLine($"{FirstName}");
        }

        public override void SayPosition(){
            base.FirstName = "Oleg";
            base.SayFirstName();            
        }
    }
}
