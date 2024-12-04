using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uthyrning.Databas;
using UthyrningSystem.Entiteter;
using static System.Collections.Specialized.BitVector32;
using static UthyrningSystem.Entiteter.Enums;

namespace Uthyrning.Affärslager
{
    public class FordonService
    {
       

        public FordonService()
        {
           
        }

       
        public Fordon SkapaFordon(FordonsTyp valdTyp, FordonStatus valdStatus, int pris, int valdBatteriNivå)
        {
            


            if (valdTyp == FordonsTyp.El_Scooter)
            {
                return new ElScooter(valdTyp, valdStatus, pris, valdBatteriNivå);
            }
            else
            {
                return new ElCykel(valdTyp, valdStatus, pris, valdBatteriNivå);
            }
        }

        public void RegistreraFordon(Fordon fordon, Station station)
        {
            station.Fordonlista.Add(fordon);
            station.UppdateraAntalFordon();
        }
    }
}
