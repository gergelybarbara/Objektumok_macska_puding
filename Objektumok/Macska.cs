using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektumok
{
    internal class Macska
    {
        public static int macskaSzam = 0;
        public string Nev { get; set; }
        public double Suly { get; set; }
        public bool EhesE { get; set; }

        public Macska(string nev, double suly, bool ehesE) //onnan tudja hogy melyiket hívjuk meg hogy mennyi paramétert adok neki
        {
            Nev = nev;
            Suly = suly;
            EhesE = ehesE;
            macskaSzam++;
        }

        //public Macska(string nev, double suly) 
        //{
        //      Nev = nev;
        //      Suly = suly;
        //      EhesE = true;
        // }

        public Macska(string nev, double suly) : this(nev, suly, true) //ez ugyan az mint az előző csak rövidebben
        {

        }

        public Macska() : this("Luna", 4) { }

        public override string? ToString()
        {
            return $"A nevem {Nev}, {Suly} kg vagyok és " + (EhesE ? "éhes vagyok!" : "nem vagyok éhes!");
        }
        public bool Eszik(double kaja) //eszik eljárás 
        {
            if (!EhesE) return false;

            Suly += kaja;
            EhesE = false;
            return true;
        }
        public void Futkos()
        {
            Suly -= 0.1;
            EhesE = true;
        }
    }


}