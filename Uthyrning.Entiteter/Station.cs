using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UthyrningSystem.Entiteter
{
    public class Station
    {
        public string StationID;
        public string StationNamn;
        public string Adress;
        public string Ort;
        public int AntalFordon;
        public int Kapacitet;
        public List<Fordon>? Fordon;
    }
}
