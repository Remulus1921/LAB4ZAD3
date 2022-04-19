using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_zad3
{
    internal interface INieSiknikowe
    {
        string Marka { get; set; }
        string Ladownosc { get; set; }
        string DataPrzegladu { get; set; }
        int IloscPrzezutek { get; set; }

    }
}
