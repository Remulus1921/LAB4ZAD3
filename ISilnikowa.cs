using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_zad3
{
    internal interface ISilnikowa
    {
        string Marka { get; set; }
        string Model { get; set; }
        string NrRej { get; set; }
        int Ladownosc { get; set; }
        string DataPrzegladu { get; set; }
        
    }
}
