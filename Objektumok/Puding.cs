using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektumok
{
    internal class Puding
    {
        public int Hofok { get; set; }

        private int mennyiseg; //nem látható mert privát, tehát a Programcs-ben nem fogja feldobni EGY PRIVÁT VÁLTOZÓ   
        public int Mennyiseg // ELJÁRÁS megegyezik ezzel = public int Hofok {  get; set; } 
        {
            get { return mennyiseg; } //itt ugyan a privát mennyisére hivatkozok, de mivel a public Mennyiségben hivatkozok rá így van rendben
            set { mennyiseg = value >= 0 ? value : 0; } // if (value>=0) mennyiseg = value; else mennyiseg =0; nem tud negatív értéket adni a mennyiség 


        }
        // nyomok egy alt+entert eljáráson kívül! generate override

        public override string? ToString()
        {
            if (Mennyiseg == 0) return "Engem mind megettek!";
            return $"Én egy {this.Hofok} °C hőmérsékletű, {Mennyiseg} db mennyiségű puding vagyok"; //base a szülő a this saját magam, a this akkor kell ha pontosítani akarom, mondjuk van egy ilyen nevű változóm is
        }

        public Puding() // a konstruktor az az eljárás amit ha meghívunk akkor magát az objektumot hívom meg
        {
            Console.WriteLine("Pudingot főztünk!");
        }

        public Puding(int hofok, int mennyiseg) //generate contructor
        {
            Console.WriteLine("Pudingot főztünk paraméterekkel!");
            Hofok = hofok;
            Mennyiseg = mennyiseg;
            //this.mennyiseg = mennyiseg; akkor megkerülöm a fenti kikötésemet és lehet negatív a mennyiségem mert másik változót írok
        }

        //Public void Eves()
        //{
        //mennyiseg--; //= Mennyiseg=Mennyiseg-1; nem lehet negatívba enni a pudingot mert Mennyiség nem pedig mennyiseg
        //}

        public bool Eves()
        {
            if (Mennyiseg > 0)
            {
                Mennyiseg--;
                return true;
            }
            return false;
        }
    }
}