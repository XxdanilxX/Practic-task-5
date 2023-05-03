using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Fish:Animal
    {
        string name, vid, home, type;
        public Fish(string name, string vid, string home, string type) : base(name, vid, home)
        {
            this.type = type;
            this.name = name;
            this.vid = vid;
            this.home = home;
        }
        public override string GetInformation()
        {
            string information;
            information = "Назва: " + name + " Вид: " + vid + " Місце проживання: " + home + " Тип: " + type;
            return information;
        }
    }
}
