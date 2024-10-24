using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UthyrningSystem.Entiteter.Enums;

namespace UthyrningSystem.Entiteter
{
    public class ElCykel: Fordon
    {
        public ElCykel()
        {
            
            this.FordonID = SkapaFordonID();
            this.FordonTyp = FordonsTyp.El_cykel;
            this.FordonStatus = FordonStatus.Ok;
            this.kostnad = 3.5f;
        }

        public override string SkapaFordonID()
        {
            // Generera 4 slumpmässiga siffror
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);

            // Sätt ihop prefix och slumpmässiga siffror för att skapa FordonID
            return $"{"CYK"}-{randomNumber}";
        }
    }
}
