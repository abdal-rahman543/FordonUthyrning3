using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UthyrningSystem.Entiteter
{
    public class Station
    {
        public string StationID { get; set; }
        public string StationNamn { get; set; }
        public string Adress { get; set; }
        public string Ort { get; set; }
        public int AntalFordon { get; set; }
        public int Kapacitet { get; set; }
        public List<Fordon> Fordonlista { get; set; }
        public Station(string stationID, string stationNamn, string adress, string ort, int kapacitet)
        {
            StationID = stationID;
            StationNamn = stationNamn;
            Adress = adress;
            Ort = ort;
            Kapacitet = kapacitet;
            Fordonlista = new List<Fordon>();

        }

        public void UppdateraAntalFordon()
        {
            int x = 0;
            foreach (Fordon fordon in Fordonlista)
            {
                if (fordon.BokningStatus == Enums.BokningStatus.Tillgänglig)
                {
                    x++;
                }
            }
            AntalFordon = x;

        }
    }

}
