using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UthyrningSystem.Entiteter;
using static UthyrningSystem.Entiteter.Enums;

namespace Uthyrning.Entiteter
{
    public class PågåendeTurer
    {
        public DateOnly Datum { get; set; }
        public TimeOnly StartTid { get; set; }
        public BetalningsMetod BetalningsMetod { get; set; }
        public string FordonID { get; set; }
        public Fordon _fordon;

        public PågåendeTurer(DateOnly datum, TimeOnly startTid, BetalningsMetod betalningsMetod, string fordonID, Fordon fordon)
        {
            Datum = datum;
            StartTid = startTid;
            BetalningsMetod = betalningsMetod;
            FordonID = fordonID;
            _fordon = fordon;
            _fordon.BokningStatus = BokningStatus.Uthyrd;
        }
    }
}
