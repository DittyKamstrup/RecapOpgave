using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapOpgave
{
    public class Member
    {

        //PROPERTIES
        public string Name { get; set; }
        public int Age { get; set; }
        public string Team { get; set; }

        //CONSTRUCTOR
        public Member(string name, int age)
        {
            Name = name;
            Age = age;

        }

        //METHODS
        public void AgePartitioning()
        {
            if (Age < 18)
            {
                Team = "Pandaholdet";
            }
            else
            {
                Team = "Drageoldet";
            }

            Console.WriteLine(Name + " skal begynde på " + Team);
        }



    }
}
