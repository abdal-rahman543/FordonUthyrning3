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
    public  class PågåendeTurerService
    {

        public void RegistreraTur(PågåendeTurer tur)
        {
            session.Instance.InloggadAnvändare.konto.tur = tur;
        }
    }
}
