
using UthyrningSystem.Entiteter;
using static UthyrningSystem.Entiteter.Enums;
namespace Uthyrning.Databas
{
    public class InMemoryDatabase
    {
        private static InMemoryDatabase instans = null;
        private static object lockToken = new object();

        public static List<Användare> AllaAnvändare = new List<Användare>();
        public static List<Fordon> fordons = new List<Fordon>();
        public static List<Station> stationer = new List<Station>();

        public InMemoryDatabase()
        {
            AllaAnvändare.Add(new Användare("Abdalrahman","Alhurafa","abooodnote04@gmail.com","123",BehörighetsNivå.Användare));
        }
        public static InMemoryDatabase Instans
        {
            
            get
            {
                lock (lockToken)
                {
                    instans ??= new InMemoryDatabase();
                }
                return instans;
            }
        }

        public bool Registrera(string förnamn, string efternamn, string epost, string lösenord, BehörighetsNivå status)
        {
            Användare nyAnvändare  = new Användare(förnamn, efternamn, epost, lösenord,status);
            AllaAnvändare.Add(nyAnvändare);
            return true;
        }



    }
}
