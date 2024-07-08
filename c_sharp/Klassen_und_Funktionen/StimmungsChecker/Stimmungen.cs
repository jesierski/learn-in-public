using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StimmungsChecker
{
    internal class Stimmung
    {
        public Stimmung()
        {
        }

        public string Name { get; set; } 
    }

    internal class Gluecklich : Stimmung
    {

        public Gluecklich()
        {
            this.Name = "Gluecklich";
        }

        public string ausgeben()
        {
            return "Glücklich";
        }

    }

    internal class Traurig : Stimmung
    {
        public Traurig()
        {
            this.Name = "Traurig";
        }

        public string ausgeben()
        {
            return "Traurig";
        }

    }

    internal class Aufgeregt : Stimmung
    {
        public Aufgeregt()
        {
            this.Name = "Aufgeregt";
        }

        public string ausgeben()
        {
            return "Aufgeregt";
        }

    }

    internal class Neutral : Stimmung
    {
        public Neutral()
        {
            this.Name = "Neutral";
        }

        public string ausgeben()
        {
            return "Neutral";
        }

    }
}
