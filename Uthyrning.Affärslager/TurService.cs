using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UthyrningSystem.Entiteter.Enums;
using Uthyrning.Entiteter;
using UthyrningSystem.Entiteter;

namespace Uthyrning.Affärslager
{
    public  class TurService
    {

        public void RegistreraTur(PågåendeTurer tur)
        {
            session.Instance.InloggadAnvändare.konto.tur = tur;
        }
        public void RegistreraHistorik(DateOnly uthyrningsDatum, TimeOnly startTid, TimeOnly slutTid, float Kostnad, BetalningsMetod betalningsMetod, string fordonID, Användare hyresTagare)
        {
            HyresHistorik nyhistorik =  new(uthyrningsDatum,startTid,slutTid, Kostnad, betalningsMetod, fordonID, hyresTagare);
            hyresTagare.konto.HyresHistorik.Add(nyhistorik);
        }
    }
}
