// See https://aka.ms/new-console-template for more information
using DecoratorFlightTicket.Ticket;
using DecoratorFlightTicket.Ticket.MealPlan;
using DecoratorFlightTicket.Ticket.PlusServices;

List<ISeat> _seatList = new List<ISeat>()
{
    new Baggage(new Dinner(new Business())),
    new Baggage(new Massage(new Business())),
    new Baggage(new BiggerSeat(new Vip())),
    new Lunch(new Dinner(new Business())),
    new BiggerSeat(new WaterOnly(new Business())),
    new Breakfast(new Massage(new Economy())),
    new WaterOnly(new Massage(new Baggage(new BiggerSeat(new Vip())))),
};

foreach(var ticket in _seatList)
{
    Console.WriteLine("Ticket Description: " + ticket.getDescription());
    Console.WriteLine("Ticket Cost: " + ticket.cost().ToString());
    Console.WriteLine("----");
}