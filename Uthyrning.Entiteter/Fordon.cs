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
        
        public  string FordonID;
        public  FordonsTyp FordonTyp;
        public  BokningStatus BokningStatus = BokningStatus.Tillgänglig;
        public  FordonStatus FordonStatus;
        public float kostnad;
        public int BatteriNivå = 100;

      

        public abstract string SkapaFordonID();
       
    }
}
