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
        public List<Fordon> Fordonlista;
        public Station(string stationID, string stationNamn, string adress, string ort, int kapacitet)
        {
            StationID = stationID;
            StationNamn = stationNamn;
            Adress = adress;
            Ort = ort;
            Kapacitet = kapacitet;
            Fordonlista = new List<Fordon>();
            AntalFordon = Fordonlista.Count();

        }

        public void UppdateraAntalFordon()
        {
            AntalFordon = Fordonlista.Count();
           
        }
    }
  
}
