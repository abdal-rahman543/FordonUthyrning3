using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Uthyrning.Databas;
using UthyrningSystem.Entiteter;

namespace Uthyrning.Affärslager
{
    public class RegistreraService
    {
        private readonly RegistreraRepository _repository;

        public RegistreraService()
        {
            _repository = new RegistreraRepository();
        }

        public bool Registrera(string förnamn, string efternamn, string epost, string lösenord, string status)
        {
            if (förnamn != null && efternamn != null && epost != null && lösenord != null && status != null)
            {

                if (Regex.IsMatch(förnamn, @"^[a-zA-Z]+$") && Regex.IsMatch(efternamn, @"^[a-zA-Z]+$")) 
                {
                    förnamn = förnamn.Trim();
                    efternamn = efternamn.Trim();
                    epost = epost.Trim();
                    lösenord = lösenord.Trim();
                    if (status == "Admin")
                    {
                        return _repository.Registrera(förnamn, efternamn, epost, lösenord, Enums.BehörighetsNivå.Admin);
                    }
                    else if (status == "Användare")
                    {
                        return _repository.Registrera(förnamn, efternamn, epost, lösenord, Enums.BehörighetsNivå.Användare);
                    }
                }
               

            }


            return false;



        }
    }
}


/*
    förnamn = förnamn.Trim();
efternamn = efternamn.Trim();
epost = epost.Trim();
lösenord = lösenord.Trim();
if (status == "Admin")
{
    _repository.Registrera(förnamn, efternamn, epost, lösenord, Enums.BehörighetsNivå.Admin);
}
else if (status == "Användare")
{
    _repository.Registrera(förnamn, efternamn, epost, lösenord, Enums.BehörighetsNivå.Användare);
}*/
