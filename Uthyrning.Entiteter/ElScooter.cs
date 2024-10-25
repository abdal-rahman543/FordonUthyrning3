using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UthyrningSystem.Entiteter.Enums;

namespace UthyrningSystem.Entiteter
{
    public class ElScooter: Fordon
    {

        public string FordonID;
        public ElScooter(FordonsTyp fordonTyp, FordonStatus fordonStatus, float kostnad, int batteriNivå = 100)
        : base(fordonTyp, fordonStatus, kostnad, batteriNivå)
        {
            this.FordonID = SkapaFordonID();
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
