using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonOp
{
    internal class Sponsor:Person
    {
        private string company;
        private int studentnumber;

        public Sponsor(string nev,int kor,string nem, string company) : base(nev,kor,nem) 
        {
            this.company = company;
        }
        public Sponsor() 
        {
            this.company = "Google";
            this.studentnumber = 0;
        }
        public override string introduce()
        {
            return $"{base.introduce()} {this.company} cégtől vagyok és eddig {this.studentnumber} diákot vettünk fel ";
        }
        public override string getGoal()
        {
            return "Felvenni nagyon jó programozókat";
        }
    }
}
