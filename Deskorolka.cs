using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_zad3
{
    internal class Deskorolka : Pojazd
    {
        public int Rozmiar { get; set; }
        public string Marka { get; set; }
        public string DataPrzegladu { get; set; }
        public override void KiedyPrzeglad()
        {
            Console.WriteLine("Przeglad dnia: " + DataPrzegladu);
        }

        public override void WyswietlObiekt()
        {
            throw new NotImplementedException();
        }
    }
}
