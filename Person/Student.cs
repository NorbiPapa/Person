using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonOp
{
    internal class Student:Person
    {
        private string previous;
        private int skippeddays;

        public Student(string nev, int eletkor, string nem,string previous, int skippeddays): base(nev, eletkor,nem)
        {
            this.previous = previous;
            this.skippeddays = 0;
        }
        public Student()
        {
            previous = "Az élet iskolája";
            skippeddays=0;
        }
        public override string introduce() 
        {
            return $"{base.introduce()} {this.previous}-tól jöttem és {this.skippeddays} napot hiányoztam ";
        }
        public override string getGoal()
        {
            return "Programozó szeretnék lenni";
        }
        public virtual int skipdays(int numberofdays) 
        {
            this.skippeddays= numberofdays;
            return this.skippeddays;
        }

    }
}
