using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_zad3
{
    internal class SamochodCiezarowy : Pojazd, ISilnikowa
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string NrRej { get; set; }
        public int Ladownosc { get; set; }
        public string DataPrzegladu { get; set; }

        public SamochodCiezarowy(string marka, string model, string nrRej, int ladownosc, string dataPrzegladu)
        {
            Marka = marka;
            Model = model;
            NrRej = nrRej;
            Ladownosc = ladownosc;
            DataPrzegladu = dataPrzegladu;
        }

        public override void KiedyPrzeglad()
        {
            Console.WriteLine("Przeglad jest dnia " + this.DataPrzegladu);
        }

        public override void WyswietlObiekt()
        {
            Console.WriteLine("Marka: " + this.Marka);
            Console.WriteLine("Model: " + this.Model);
            Console.WriteLine("Numer Rejestracyjny: " + this.NrRej);
            Console.WriteLine("Ladownosc: " + this.Ladownosc);
            Console.WriteLine("Data Przegladu:" + this.DataPrzegladu);
        }
    }
}
