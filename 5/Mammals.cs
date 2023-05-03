using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5
{
    internal class Mammals:Animal
    {
        string name, vid, home,type;
        public Mammals(string name, string vid, string home, string type): base(name,vid,home)
        {
            this.name = name;
            this.vid = vid;
            this.home = home;
            this.type = type;
        }
        public override string GetInformation()
        {
            string information;
            information = "Назва: " + name + " Вид: " + vid + " Місце проживання: " + home + " Тип: " + type;
            return information;
        }
    }
}
