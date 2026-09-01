using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Komunikacija
{
    public enum Operacija
    {
        VratiListuSviUdzbenik,
        KreirajUdzbenik,
        PretraziUdzbenik,
        PromeniUdzbenik,
        ObrisiUdzbenik,

        VratiListuSviProdavac, KreirajProdavac, PretraziProdavac, PromeniProdavac, ObrisiProdavac,

        VratiListuSviObuka, KreirajObuka, PretraziObuka, PromeniObuka, ObrisiObuka,

        VratiListuSviOsnovnaSkola, KreirajOsnovnaSkola, PretraziOsnovnaSkola, PromeniOsnovnaSkola, ObrisiOsnovnaSkola,
    }
}
