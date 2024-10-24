using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UthyrningSystem.Entiteter.Enums;
namespace UthyrningSystem.Entiteter
{
    public class Konto
    {
        Användare KontoÄgare;
        public List<HyresHistorik> HyresHistorik;
        public string AnvändareID;
        public List<BetalningsMetod> BetalningsMetod;
        public BehörighetsNivå Behörighet;

        public Konto(Användare ägare) 
        {
            KontoÄgare = ägare;
        }
    }
}
