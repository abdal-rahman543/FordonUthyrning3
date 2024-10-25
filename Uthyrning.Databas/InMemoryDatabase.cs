
using UthyrningSystem.Entiteter;
using static UthyrningSystem.Entiteter.Enums;
namespace Uthyrning.Databas
{
    public class InMemoryDatabase
    {
        private static InMemoryDatabase instans = null;
        private static object lockToken = new object();

        public static List<Användare> AllaAnvändare = new List<Användare>();
        public static List<Fordon> fordon = new List<Fordon>();
        public static List<Station> stationer = new List<Station>();

        public InMemoryDatabase()
        {
            AllaAnvändare.Add(new Användare("Abdalrahman","Alhurafa","abooodnote04@gmail.com","123",BehörighetsNivå.Användare));
            Station station1 = new Station("S123", "Centralstation", "Huvudgatan 1", "Stockholm", 5, 10);
            Station station2 = new Station("S124", "Södra Station", "Södergatan 5", "Göteborg", 3, 8);
            Station station3 = new Station("S125", "Norra Station", "Norrgatan 3", "Malmö", 2, 6);
            Station station4 = new Station("S125", "Norra Station", "Norrgatan 3", "Malmö", 2, 6);
            stationer.Add(station1);
            stationer.Add(station2);
            stationer.Add(station3);
            stationer.Add(station4);
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

        public List<Station> HämtaStationer()
        {
            return new List<Station>(stationer);
        }



    }
}
