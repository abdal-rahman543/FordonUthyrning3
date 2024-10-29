using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uthyrning.Entiteter;
using static UthyrningSystem.Entiteter.Enums;
namespace UthyrningSystem.Entiteter
{
    public class Konto
    {
        
        public List<HyresHistorik> HyresHistorik;
        public List<BetalningsMetod> BetalningsMetod;
        public BehörighetsNivå Behörighet;
        public PågåendeTurer tur;
        public Användare KontoÄgare;
        public string TeleNr;
        public string KortNr;
        public Konto(BehörighetsNivå status, Användare ägare) 
        {
            Behörighet = status;
            HyresHistorik =  new List<HyresHistorik>();
            KontoÄgare = ägare;
            BetalningsMetod = new List<BetalningsMetod>();


        }

       
    }
}
