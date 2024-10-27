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
                    Enums.BehörighetsNivå behörighet = status == "Admin" ? Enums.BehörighetsNivå.Admin : Enums.BehörighetsNivå.Användare;
                    Användare nyAnvändare = new Användare(förnamn, efternamn, epost, lösenord, behörighet);
                    nyAnvändare.ID = SkapaUniktID(nyAnvändare,AnvändareLista);


                    return _repository.Registrera(nyAnvändare);

                }
               

            }


            return null;



        }
        // Kontrollera om användarens ID redan existerar och skapa ett nytt om det behövs
        private string SkapaUniktID(Användare nyAnvändare,List<Användare> AnvändareLista)
        {
            foreach (Användare an in AnvändareLista)
            {
                if (nyAnvändare.ID.Equals(an.ID))
                {
                    nyAnvändare.SkapaID();
                }
            }
            return nyAnvändare.ID;
        }
    }
}


