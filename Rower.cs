using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_zad3
{
    internal class Rower : Pojazd, INieSiknikowe
    {
        public string Marka { get; set; }
        public string Ladownosc { get; set; }
        public int IloscPrzezutek { get; set; }
        public string DataPrzegladu { get; set; }

        public Rower(string marka, string ladownosc, int iloscPrzezutek, string dataPrzegladu)
        {
            Marka = marka;
            Ladownosc = ladownosc;
            IloscPrzezutek = iloscPrzezutek;
            DataPrzegladu = dataPrzegladu;
        }
        public override void KiedyPrzeglad()
        {
            Console.WriteLine("Przeglad jest dnia " + this.DataPrzegladu);
        }

        public override void WyswietlObiekt()
        {
            Console.WriteLine("Marka: " + this.Marka);
            Console.WriteLine("Ladownosc: " + this.Ladownosc);
            Console.WriteLine("Ilosc Przezutek: " + this.IloscPrzezutek);
            Console.WriteLine("Data Przegladu: " + this.DataPrzegladu);
        }
    }
}
