using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UthyrningSystem.Entiteter
{
    public class Enums
    {
        public enum FordonsTyp
        {
            El_Scooter,
            El_cykel,
        }

        public enum BokningStatus
        {
            Tillgänglig,
            Uthyrd,
        }

        public enum FordonStatus
        {
            Ok,
            Trasig,
            Låg_Batteri_Nivå
        }

        public enum BetalningsMetod
        {
            Swish,
            Kort,
            kredit,
            Faktura,

        }

        public enum BehörighetsNivå
        {
            Admin,
            Användare,
        }
    }
}
