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
            _repository = Custom_RepostioryContainer.GetRepository<RegistreraRepository>();
        }

        public Användare Registrera(string förnamn, string efternamn, string epost, string lösenord, string status)
        {
            if (förnamn != null && efternamn != null && epost != null && lösenord != null && status != null)
            {

                if (Regex.IsMatch(förnamn, @"^[a-zA-Z]+$") && Regex.IsMatch(efternamn, @"^[a-zA-Z]+$")) 
                {
                    förnamn = förnamn.Trim();
                    efternamn = efternamn.Trim();
                    epost = epost.Trim();
                    lösenord = lösenord.Trim();
                    List<Användare> AnvändareLista = _repository.HämtaAnvändare();
                    if (status == "Admin")
                    {
                        Användare nyAnvändare = new Användare(förnamn, efternamn, epost, lösenord, Enums.BehörighetsNivå.Admin);

                        // Kontrollera om användarens ID redan existerar och skapa ett nytt om det behövs
                        foreach(Användare an in AnvändareLista)
                        {
                            if (nyAnvändare.ID.Equals(an.ID))
                            {
                                nyAnvändare.SkapaID();
                            }
                        }
                      
                        return _repository.Registrera(nyAnvändare);
                    }
                    else if (status == "kund")
                    {
                        Användare nyAnvändare = new Användare(förnamn, efternamn, epost, lösenord, Enums.BehörighetsNivå.Användare);

                        // Kontrollera om användarens ID redan existerar och skapa ett nytt om det behövs
                        foreach (Användare an in AnvändareLista)
                        {
                            if (nyAnvändare.ID.Equals(an.ID))
                            {
                                nyAnvändare.SkapaID();
                            }
                        }
                        return _repository.Registrera(nyAnvändare);
                    }
                }
               

            }


            return null;



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


/*
Användare nyAnvändare = new Användare(förnamn, efternamn, epost, lösenord, status);

            // Kontrollera om användarens ID redan existerar och skapa ett nytt om det behövs
            while (AllaAnvändare.Exists(an => an.ID.Equals(nyAnvändare.ID)))
            {
                nyAnvändare.SkapaID(); // Anropa SkapaID tills ett unikt ID hittas
            }

            // Lägg till den nya användaren till listan när unikt ID är klart
            AllaAnvändare.Add(nyAnvändare);
            return true;

*/