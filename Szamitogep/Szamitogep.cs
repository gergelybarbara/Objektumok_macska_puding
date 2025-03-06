using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamitogepek
{
    internal class Szamitogep
    {
        public double SzabadMemoria {  get; set; }
        public bool Bekapcsolva {  get; set; }

        public Szamitogep(double szabadMemoria, bool bekapcsolva)
        {
            SzabadMemoria = szabadMemoria;
            Bekapcsolva = bekapcsolva;
        }

        public Szamitogep() //mivel megadjuk az alap paramétereket ez üresen marad
        {
            SzabadMemoria = 1024;
            Bekapcsolva = false;
        }

        public void Kapcsol()
        {
            Bekapcsolva = !Bekapcsolva;
            //if (Bekapcsolva) Bekapcsolva = false; else Bekapcsolva = true; ugyan az csak a másik rövidebb
        }

       public bool ProgramMasol(double programMeret)
       {
            if (!Bekapcsolva) //kikapcsolt gép
            {
                Console.WriteLine($"A {programMeret} MB méretű program másolása sikertelen, mert a számítógép ki van kapcsolva!");
                return false;
            }

            if (SzabadMemoria < programMeret) //nincs elég hely
            {
                Console.WriteLine($"A {programMeret} MB méretű program másolása sikertelen, mert nincs elég szabad memória! (Csak {SzabadMemoria} MB érhető el)");
                return false;
            }

            SzabadMemoria -= programMeret; //minden ok
            Console.WriteLine($"A program másolása sikeres! {programMeret} MB átmásolva, fennmaradó memória: {SzabadMemoria} MB.");
            return true;
        }

        public override string? ToString()
        {
            return $"Ez a gép {SzabadMemoria} MB szabad memóriával rendelkezik és "+(Bekapcsolva ? "be van kapcsolva!" : "ki van kapcsolva!");
        }
    }


}