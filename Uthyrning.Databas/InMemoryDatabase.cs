
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
            //Användare
            AllaAnvändare.Add(new Användare("Abdalrahman","Alhurafa","abooodnote04@gmail.com","123",BehörighetsNivå.Användare));
            //Stationer
            Station station1 = new Station("S123", "Centralstation", "Huvudgatan 1", "Stockholm", 5, 10);
            Station station2 = new Station("S124", "Södra Station", "Södergatan 5", "Göteborg", 3, 8);
            Station station3 = new Station("S125", "Norra Station", "Norrgatan 3", "Malmö", 2, 6);
            Station station4 = new Station("S125", "Norra Station", "Norrgatan 3", "Malmö", 2, 6);
            stationer.Add(station1);
            stationer.Add(station2);
            stationer.Add(station3);
            stationer.Add(station4);
            //Fordon
            Fordon scooter1 = new ElScooter(FordonsTyp.El_Scooter, FordonStatus.Ok, 200);
            Fordon scooter2 = new ElScooter(FordonsTyp.El_Scooter, FordonStatus.Ok, 200);
            Fordon scooter3 = new ElScooter(FordonsTyp.El_Scooter, FordonStatus.Ok, 200);
            Fordon scooter4 = new ElScooter(FordonsTyp.El_Scooter, FordonStatus.Ok, 200);
            Fordon scooter5 = new ElScooter(FordonsTyp.El_Scooter, FordonStatus.Ok, 200);
            Fordon cykel1 = new ElCykel(FordonsTyp.El_cykel, FordonStatus.Ok, 130);
            Fordon cykel2 = new ElCykel(FordonsTyp.El_cykel, FordonStatus.Ok, 130);
            Fordon cykel3 = new ElCykel(FordonsTyp.El_cykel, FordonStatus.Ok, 130);
            Fordon cykel4 = new ElCykel(FordonsTyp.El_cykel, FordonStatus.Ok, 130);
            Fordon cykel5 = new ElCykel(FordonsTyp.El_cykel, FordonStatus.Ok, 130);
            Fordon cykel6 = new ElCykel(FordonsTyp.El_cykel, FordonStatus.Ok, 130);

            // Lägg till fordonen i respektive station
            station1.Fordonlista.Add(scooter1);
            station1.Fordonlista.Add(scooter2);
            station1.Fordonlista.Add(scooter3);
            station1.Fordonlista.Add(scooter4);
            station1.Fordonlista.Add(scooter5);
            station1.Fordonlista.Add(cykel1);
            station1.Fordonlista.Add(cykel2);
            station1.Fordonlista.Add(cykel3);
            station1.Fordonlista.Add(cykel4);
            station1.Fordonlista.Add(cykel5);
            station1.Fordonlista.Add(cykel6);
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
