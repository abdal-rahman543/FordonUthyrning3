using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UthyrningSystem.Entiteter.Enums;


namespace UthyrningSystem.Entiteter
{
    public class HyresHistorik
    {
        public DateOnly UthyrningsDatum;
        public TimeOnly StartTid;
        public TimeOnly SlutTid;
        public float kostnad;
        public BetalningsMetod BetalningsMetod;
        public string FordonID;
        public Användare HyresTagare;

        public HyresHistorik(DateOnly uthyrningsDatum, TimeOnly startTid, TimeOnly slutTid, float Kostnad, BetalningsMetod betalningsMetod, string fordonID, Användare hyresTagare)
        {
            UthyrningsDatum = uthyrningsDatum;
            StartTid = startTid;
            SlutTid = slutTid;
            kostnad = Kostnad;
            BetalningsMetod = betalningsMetod;
            FordonID = fordonID;
            HyresTagare = hyresTagare;
        }
    }
}
