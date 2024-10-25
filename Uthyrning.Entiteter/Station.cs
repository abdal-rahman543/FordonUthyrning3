﻿using System;
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
        public Station(string stationID, string stationNamn, string adress, string ort, int antalFordon, int kapacitet)
        {
            StationID = stationID;
            StationNamn = stationNamn;
            Adress = adress;
            Ort = ort;
            AntalFordon = antalFordon;
            Kapacitet = kapacitet;

        }
    }
  
}