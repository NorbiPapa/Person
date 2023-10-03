using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonOp
{
    internal class Mentor:Person
    {
        private string level;


        public Mentor(string nev,int kor, string nem, string level): base(nev,kor,nem) 
        {
            this.level = level;
        }
        public Mentor() 
        {
            this.level = "haladó";
        }
        public override string introduce()
        {
            return $"{base.introduce()} {this.level} mentor vagyok ";
        }
        public override string getGoal()
        {
            return "Tanítani szeretném a következő generációt";
        }
    }

}
