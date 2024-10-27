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
        
        public List<HyresHistorik> HyresHistorik;
        public List<BetalningsMetod> BetalningsMetod;
        public BehörighetsNivå Behörighet;

        public Konto(BehörighetsNivå status) 
        {
            Behörighet = status;
            HyresHistorik =  new List<HyresHistorik>();
            //borde lägga till betalningsmetod
        }
    }
}
