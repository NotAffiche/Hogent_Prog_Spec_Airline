using DataLayer;
using DataLayer.Model;

namespace ConsoleAppTest;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        AirlineContext ctx = new AirlineContext();

        Airline al1 = new Airline();
        al1.Name = "BrusselAirlines";

        Pilot p1 = new Pilot();
        p1.Name = "Adrian B";
        p1.Airline= al1;

        Pilot p2 = new Pilot();
        p2.Name = "Jeremi B";
        p2.Airline = al1;

        CabinMember cm1 = new CabinMember();
        cm1.Name = "Julie H";
        cm1.Airline = al1;

        CabinMember cm2 = new CabinMember();
        cm2.Name = "Patryk G";
        cm2.Airline = al1;

        List<CabinMember> crew = new List<CabinMember>() { cm1, cm2 };

        PassengerInfo pi1 = new PassengerInfo();
        pi1.EconomySeatsOccupied = 100;
        pi1.BusinessSeatsOccupied = 50;

        Airplane ap1 = new Airplane();
        ap1.Name = "V-2";

        Flight f1= new Flight();
        f1.Arrival = "Poznan, Poland";
        f1.Departure = "Zaventem, Belgium";
        f1.Airplane = ap1;
        f1.Flightnumber = "PO47";
        f1.Pilot = p1;
        f1.CoPilot = p2;
        f1.CabinMembers = crew;
        f1.PassengerInfo = pi1;

        ctx.Database.EnsureDeleted();
        ctx.Database.EnsureCreated();

        ctx.Flights.Add(f1);
        ctx.SaveChanges();
    }
}