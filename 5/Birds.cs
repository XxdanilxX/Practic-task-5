using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Birds:Animal
    {
        string name, vid, home, type1,type2;
        public Birds(string name, string vid, string home, string type1,string type2) : base(name, vid, home)
        {
            this.type1 = type1;
            this.type2 = type2;
            this.name = name;
            this.vid = vid;
            this.home = home;
        }
        public override string GetInformation()
        {
            string information;
            information = "Назва: " + name + " Вид: " + vid + " Місце проживання: " + home + " Тип: " + type1 + " Перелітня: " + type2;
            return information;
            
        }
    }
}
