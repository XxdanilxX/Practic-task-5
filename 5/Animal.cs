using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5
{
    internal abstract class Animal
    {
        string name, vid, home;

        protected Animal(string name, string vid, string home)
        {
            this.name = name;
            this.vid = vid;
            this.home = home;
        }
        public abstract string GetInformation();   
    }
}
