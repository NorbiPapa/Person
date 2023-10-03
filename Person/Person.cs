using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonOp
{
    internal  class Person
    {
        private string nev;
        private int eletkor;
        private string nem;

        public Person(string nev, int eletkor, string nem)
        {
            this.nev = nev;
            this.eletkor = eletkor;
            this.nem = nem;
        }
        public virtual string getGoal() 
        {
            return $" A célom az hogy jobb legyek, a társam oldalán.";
        }
        public virtual string introduce() 
        {
            return $"A nevem {this.nev}, {this.eletkor} éves vagyok és {this.nem}";
        }
        public Person() 
        {
            this.nev = "Jane Doe";
            this.eletkor = 30;
            this.nem = "nő";
        }
    }
}
