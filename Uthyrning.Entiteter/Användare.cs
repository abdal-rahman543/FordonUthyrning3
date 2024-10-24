using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UthyrningSystem.Entiteter
{
    public class Användare
    {
        public string FörNamn;
        string EfterNamn;
        string Epost;
        public string Lösenord;

        public Användare(string förNamn,string efterNamn, string epost,string lösenord) 
        {
            FörNamn = förNamn.Trim();
            EfterNamn = efterNamn.Trim();
            Epost = epost.Trim();
            Lösenord = lösenord.Trim(); 
            Konto konto = new Konto(this);

            
        }
    }

}
