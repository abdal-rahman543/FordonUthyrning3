﻿
using UthyrningSystem.Entiteter;
using static UthyrningSystem.Entiteter.Enums;
namespace Uthyrning.Databas
{
    public class InMemoryDatabase
    {
        private static InMemoryDatabase instans = null;
        private static object lockToken = new object();

        private static List<Användare> AllaAnvändare = new List<Användare>();
        
        private static List<Station> stationer = new List<Station>();

        public InMemoryDatabase()
        {
            Användare Admin = new Användare("Abdalrahman", "Alhurafa", "abooodnote04@gmail.com", "123", BehörighetsNivå.Admin);
            Användare Användare = new Användare("Alex", "Alexsson", "abooodnote04@gmail.com", "123", BehörighetsNivå.Användare);
            Admin.konto.BetalningsMetod.Add(BetalningsMetod.Swish);
            Admin.konto.BetalningsMetod.Add(BetalningsMetod.Kort);
            Admin.konto.TeleNr = "0705805533";
            Admin.konto.KortNr = "1234567890123456";
            Admin.ID = "ABAL20";

            Användare.konto.BetalningsMetod.Add(BetalningsMetod.Swish);
            Användare.konto.BetalningsMetod.Add(BetalningsMetod.Kort);
            Användare.konto.TeleNr = "0705805533";
            Användare.konto.KortNr = "1234567890123456";
            Användare.ID = "ALAL20";
            //Användare
            AllaAnvändare.Add(Admin);
            AllaAnvändare.Add(Användare);
            //Stationer
            Station station1 = new Station("S123", "Centralstation", "Huvudgatan 1", "Stockholm", 10);
            Station station2 = new Station("S124", "Södra Station", "Södergatan 5", "Göteborg", 8);
            Station station3 = new Station("S125", "Norra Station", "Norrgatan 3", "Malmö", 6);
            Station station4 = new Station("S125", "västra Station", "västgatan 6", "Helsingborg", 6);
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


            // Skapa instanser av fordon
            // Skapa nya instanser av fordon
            Fordon scooter6 = new ElScooter(FordonsTyp.El_Scooter, FordonStatus.Ok, 200);
            Fordon scooter7 = new ElScooter(FordonsTyp.El_Scooter, FordonStatus.Ok, 200);
            Fordon scooter8 = new ElScooter(FordonsTyp.El_Scooter, FordonStatus.Ok, 200);
            Fordon cykel9 = new ElCykel(FordonsTyp.El_cykel, FordonStatus.Ok, 130);
            Fordon cykel7 = new ElCykel(FordonsTyp.El_cykel, FordonStatus.Ok, 130);
            Fordon cykel8 = new ElCykel(FordonsTyp.El_cykel, FordonStatus.Ok, 130);

            // Lägg till fordon i station 2
            station2.Fordonlista.Add(scooter6);
            station2.Fordonlista.Add(cykel9);
            station2.Fordonlista.Add(cykel8);
            station2.UppdateraAntalFordon();

            // Lägg till fordon i station 3
            station3.Fordonlista.Add(scooter7);
            station3.Fordonlista.Add(cykel7);
            station3.Fordonlista.Add(scooter8);
            station3.UppdateraAntalFordon();

            // Lägg till fordon i station 4
            Fordon scooter9 = new ElScooter(FordonsTyp.El_Scooter, FordonStatus.Ok, 200);
            Fordon cykel6 = new ElCykel(FordonsTyp.El_cykel, FordonStatus.Ok, 130);
            station4.Fordonlista.Add(scooter9);
            station4.Fordonlista.Add(cykel3);
            station4.Fordonlista.Add(cykel6);
            station4.UppdateraAntalFordon();


            station1.UppdateraAntalFordon();
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


        public Användare Registrera(Användare user)
        {
            AllaAnvändare.Add(user);
            return user;
        }

        public List<Station> HämtaStationer()
        {
            return new List<Station>(stationer);
        }

        public List<Användare> HämtaAnvändare()
        {
            return new List<Användare>(AllaAnvändare);
        }
        public void LäggTillStation(Station nyStation)
        {
            stationer.Add(nyStation);
        }

    }
}
