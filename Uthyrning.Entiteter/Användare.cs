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
        public string EfterNamn;
        public string Epost;
        public string Lösenord;
        public string ID;
        public Konto konto;
        public Användare(string förNamn,string efterNamn, string epost,string lösenord, BehörighetsNivå status) 
        {
            FörNamn = förNamn.Trim();
            EfterNamn = efterNamn.Trim();
            Epost = epost.Trim();
            Lösenord = lösenord.Trim(); 
            konto = new(status,this);
            ID = SkapaID();
            Console.WriteLine(ID);


            
        }
        
        public string SkapaID()
        {
            Random random = new Random();
            string förnamnInitialer = FörNamn.Length >= 2 ? FörNamn.Substring(0, 2).ToUpper() : FörNamn.ToUpper();
            string efternamnInitialer = EfterNamn.Length >= 2 ? EfterNamn.Substring(0, 2).ToUpper() : EfterNamn.ToUpper();
            int randomSiffror = random.Next(10, 99); // Två slumpmässiga siffror mellan 10 och 99


            return $"{förnamnInitialer}{efternamnInitialer}{randomSiffror}";
        }
    }

}
