using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapOpgave
{
    class Program
    {

        public static List<Member> MemberList { get; set; }
        static void Main(string[] args)
        {
            MemberList = new List<Member>();

            Member member1 = new Member("Pyrus", 147);
            Member member2 = new Member("Nicklas", 17);
            Member member3 = new Member("Ditte", 24);

            MemberList.Add(member1);
            MemberList.Add(member2);
            MemberList.Add(member3);

            foreach (Member item in MemberList)
            {
                item.AgePartitioning();
            }
        }
    }
}
