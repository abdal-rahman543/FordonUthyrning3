using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UthyrningSystem.Entiteter.Enums;

namespace UthyrningSystem.Entiteter
{
    public class Användare
    {
        public string FörNamn;
        string EfterNamn;
        string Epost;
        public string Lösenord;
        Konto konto;
        public Användare(string förNamn,string efterNamn, string epost,string lösenord, BehörighetsNivå status) 
        {
            FörNamn = förNamn.Trim();
            EfterNamn = efterNamn.Trim();
            Epost = epost.Trim();
            Lösenord = lösenord.Trim(); 
            konto = new(this,status);


            
        }
    }

}
