using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UthyrningSystem.Entiteter.Enums;
namespace UthyrningSystem.Entiteter
{
    
    public abstract class Fordon
    {
        
       
        public  FordonsTyp FordonTyp;
        public  BokningStatus BokningStatus = BokningStatus.Tillgänglig;
        public  FordonStatus FordonStatus;
        public float kostnad;
        public int BatteriNivå = 100;
        public string FordonID;
        public Fordon(FordonsTyp fordonTyp, FordonStatus fordonStatus, float Kostnad, int batteriNivå = 100)
        {
            FordonID = SkapaFordonID();
            FordonTyp = fordonTyp;
            FordonStatus = fordonStatus;
            kostnad = Kostnad;
            BatteriNivå = batteriNivå;
            BokningStatus = BokningStatus.Tillgänglig;
        }


        public abstract string SkapaFordonID();
       
    }
}
