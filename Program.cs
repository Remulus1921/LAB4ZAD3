using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rower1 = new Rower("asd", "123", 20, "12.10.2022");
            var zwyzka = new Zwyżka("zwyzka", "a13", "SW12345", 120, "10.12.2023");
            var samOs = new SamochodOsobowy("Renault", "Megane", "EL13244", 300, "1.1.2024");
            var samCi = new SamochodCiezarowy("MAN", "223", "RU123444", 1500, "15.4.2022");
            var furgon = new Furgonetka("VW", "T4", "SL13142", 500, "1.1.2022");
            Console.WriteLine("Rower:");
            rower1.KiedyPrzeglad();
            rower1.WyswietlObiekt();
            Console.WriteLine("\nZwyzka:");
            zwyzka.KiedyPrzeglad();
            zwyzka.WyswietlObiekt();
            Console.WriteLine("\nSamochod Osobowy:");
            samOs.KiedyPrzeglad();
            samOs.WyswietlObiekt();
            Console.WriteLine("\nSamochod Ciezarowy:");
            samCi.KiedyPrzeglad();
            samCi.WyswietlObiekt();
            Console.WriteLine("\nFurgon:");
            furgon.KiedyPrzeglad();
            furgon.WyswietlObiekt();
            Console.ReadKey();
        }
    }
}
