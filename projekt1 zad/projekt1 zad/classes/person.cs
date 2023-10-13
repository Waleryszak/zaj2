using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1_zad.classes
{
    internal class person
    {
        public string firstname;
        public string lastname;
        public float height;
        public float weight;

        public string getData()
        {
            return "Imie i nazwisko:" + firstname + " " + lastname + "\nWzrost:" + height + "cm, waga:" + weight + "KG";
        }
    }
}
