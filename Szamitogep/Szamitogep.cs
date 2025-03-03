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
            if (Bekapcsolva && SzabadMemoria >= programMeret)
    {
                SzabadMemoria -= programMeret; // SzabadMemoria = SzabadMemoria - programMeret;
                return true; // Másolás sikeres
            }
            return false; // Másolás sikertelen
        }

        public override string? ToString()
        {
            return $"Ez a gép {SzabadMemoria} MB szabad memóriával rendelkezik és "+(Bekapcsolva ? "be van kapcsolva!" : "ki van kapcsolva!");
        }
    }


}
//azt szeretném hogy ha nincs elég szabad memória vagy a gép ki van kapcsolva akkor írja ki hogy a másolás nem lehetsége mert a gép ki van kapcsolva vagy elfogyott a memória