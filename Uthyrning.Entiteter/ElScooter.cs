using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UthyrningSystem.Entiteter.Enums;

namespace UthyrningSystem.Entiteter
{
    internal class ElScooter: Fordon
    {

        public ElScooter() 
        {
            
            this.FordonID = SkapaFordonID();
            this.FordonTyp = FordonsTyp.El_Scooter;
            this.FordonStatus = FordonStatus.Ok;
            this.kostnad =  4.5f;
        }

        public override string SkapaFordonID()
        {
            // Generera 4 slumpmässiga siffror
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);

            // Bestäm prefix baserat på fordonstyp
           

            // Sätt ihop prefix och slumpmässiga siffror för att skapa FordonID
            return $"{"SCO"}-{randomNumber}";
        }
    }
}
