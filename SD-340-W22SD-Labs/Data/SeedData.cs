using Microsoft.EntityFrameworkCore;
using SD_340_W22SD_Labs.Models;
using Route = SD_340_W22SD_Labs.Models.Route;

namespace SD_340_W22SD_Labs.Data
{
    public static class SeedData
    {
        public async static Task Initialize(IServiceProvider serviceProvider)
        {
            var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            if(context.Route.FirstOrDefault(r => r.Name == "Route1") != null)
            {
                return;
            }
            if(context.Route.FirstOrDefault(r => r.Name == "Route2") != null)
            {
                return;
            }

            Route route1 = new Route();
            Route route2 = new Route();

            route1.Name = "Route1";
            route1.Direction = Direction.South;
            route1.RampAccessible = true;
            route1.BicycleAccessible = true;

            route2.Name = "Route2";
            route2.Direction = Direction.North;
            route2.RampAccessible = false;
            route2.BicycleAccessible = false;

            await context.Route.AddRangeAsync(route1, route2);
            await context.SaveChangesAsync();

            Stop stop1 = new Stop();
            Stop stop2 = new Stop();
            Stop stop3 = new Stop();
            Stop stop4 = new Stop();
            Stop stop5 = new Stop();
            Stop stop6 = new Stop();
            Stop stop7 = new Stop();
            Stop stop8 = new Stop();
            Stop stop9 = new Stop();
            Stop stop10 = new Stop();

            stop1.Name = "Stop1";
            stop2.Name = "Stop2";
            stop3.Name = "Stop3";
            stop4.Name = "Stop4";
            stop5.Name = "Stop5";
            stop6.Name = "Stop6";
            stop7.Name = "Stop7";
            stop8.Name = "Stop8";
            stop9.Name = "Stop9";
            stop10.Name = "Stop10";

            stop1.Street = "Street1";
            stop2.Street = "Street2";
            stop3.Street = "Street3";
            stop4.Street = "Street4";
            stop5.Street = "Street5";
            stop6.Street = "Street6";
            stop7.Street = "Street7";
            stop8.Street = "Street8";
            stop9.Street = "Street9";
            stop10.Street = "Street10";

            stop1.Direction = Direction.East;
            stop2.Direction = Direction.West;
            stop3.Direction = Direction.South;
            stop4.Direction = Direction.North;
            stop5.Direction = Direction.Southeast;
            stop6.Direction = Direction.Northeast;
            stop7.Direction = Direction.Southwest;
            stop8.Direction = Direction.Northwest;
            stop9.Direction = Direction.East;
            stop10.Direction = Direction.West;

            await context.Stop.AddRangeAsync(stop1, stop2, stop3, stop4, stop5, stop6, stop7, stop8, stop9, stop10);
            await context.SaveChangesAsync();

            ScheduledStop scheduledStop1 = new ScheduledStop();
            ScheduledStop scheduledStop2 = new ScheduledStop();
            ScheduledStop scheduledStop3 = new ScheduledStop();
            ScheduledStop scheduledStop4 = new ScheduledStop();
            ScheduledStop scheduledStop5 = new ScheduledStop();
            ScheduledStop scheduledStop6 = new ScheduledStop();
            ScheduledStop scheduledStop7 = new ScheduledStop();
            ScheduledStop scheduledStop8 = new ScheduledStop();
            ScheduledStop scheduledStop9 = new ScheduledStop();
            ScheduledStop scheduledStop10 = new ScheduledStop();

            scheduledStop1.RouteNumber = route1.Number;
            scheduledStop1.StopNumber = stop1.Number;
            scheduledStop1.ScheduledArrival = new DateTime(2022, 9, 14, 7, 0, 0);

            scheduledStop2.RouteNumber = route1.Number;
            scheduledStop2.StopNumber = stop2.Number;
            scheduledStop2.ScheduledArrival = new DateTime(2022, 9, 14, 7, 12, 0);

            scheduledStop3.RouteNumber = route1.Number;
            scheduledStop3.StopNumber = stop3.Number;
            scheduledStop3.ScheduledArrival = new DateTime(2022, 9, 14, 7, 24, 0);

            scheduledStop4.RouteNumber = route1.Number;
            scheduledStop4.StopNumber = stop4.Number;
            scheduledStop4.ScheduledArrival = new DateTime(2022, 9, 14, 7, 36, 0);

            scheduledStop5.RouteNumber = route1.Number;
            scheduledStop5.StopNumber = stop5.Number;
            scheduledStop5.ScheduledArrival = new DateTime(2022, 9, 14, 7, 48, 0);

            scheduledStop6.RouteNumber = route2.Number;
            scheduledStop6.StopNumber = stop6.Number;
            scheduledStop6.ScheduledArrival = new DateTime(2022, 9, 14, 8, 0, 0);

            scheduledStop7.RouteNumber = route2.Number;
            scheduledStop7.StopNumber = stop7.Number;
            scheduledStop7.ScheduledArrival = new DateTime(2022, 9, 14, 8, 13, 0);

            scheduledStop8.RouteNumber = route2.Number;
            scheduledStop8.StopNumber = stop8.Number;
            scheduledStop8.ScheduledArrival = new DateTime(2022, 9, 14, 8, 26, 0);

            scheduledStop9.RouteNumber = route2.Number;
            scheduledStop9.StopNumber = stop9.Number;
            scheduledStop9.ScheduledArrival = new DateTime(2022, 9, 14, 8, 39, 0);

            scheduledStop10.RouteNumber = route2.Number;
            scheduledStop10.StopNumber = stop10.Number;
            scheduledStop10.ScheduledArrival = new DateTime(2022, 9, 14, 8, 52, 0);

            await context.AddRangeAsync(scheduledStop1, scheduledStop2, scheduledStop3, scheduledStop4, scheduledStop5, scheduledStop6, scheduledStop7, scheduledStop8, scheduledStop9, scheduledStop10);
            await context.SaveChangesAsync();
        }
    }
}
