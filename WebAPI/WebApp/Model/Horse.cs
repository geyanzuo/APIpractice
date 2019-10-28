using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class Horse
    {
        public string Name;
        public string Colour;

        public Horse(string pname, string pcolour)
        {
            Name = pname;
            Colour = pcolour;

        }
    }
}
