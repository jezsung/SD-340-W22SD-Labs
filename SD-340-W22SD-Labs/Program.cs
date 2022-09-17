using Microsoft.EntityFrameworkCore;
using SD_340_W22SD_Labs.Data;
using SD_340_W22SD_Labs.Models;
using Route = SD_340_W22SD_Labs.Models.Route;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContext' not found.")));

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    await SeedData.Initialize(services);
}

app.MapGet("/routes/{routeId}", async (int? routeId, ApplicationDbContext db) =>
{
    if (routeId == null)
    {
        throw new BadHttpRequestException("Route number must be provided");
    }

    Route route = await db.Route.Include(r => r.StopSchedules).FirstAsync(r => r.Number == routeId);
    route.StopSchedules = route.StopSchedules.Take(5).ToList();
    foreach (var stopSchedule in route.StopSchedules)
    {
        stopSchedule.Route = null;
        stopSchedule.Stop = null;
    }

    return route;
});

app.MapGet("/stops/{stopId}", async (int? stopId, ApplicationDbContext db) =>
{
    if (stopId == null)
    {
        throw new BadHttpRequestException("Route number must be provided");
    }

    Stop stop = await db.Stop.FirstAsync(r => r.Number == stopId);

    return stop;
});

app.MapGet("/stop-schedules", async (int? number, int? top, ApplicationDbContext db) =>
{
    if (number == null || top == null)
    {
        throw new BadHttpRequestException("Route number must be provided");

    }

    Stop stop = await db.Stop.Include(s => s.StopSchedules).FirstAsync(r => r.Number == number);
    stop.StopSchedules = stop.StopSchedules.Take((int)top).ToList();
    foreach (var stopSchedule in stop.StopSchedules)
    {
        stopSchedule.Route = null;
        stopSchedule.Stop = null;
    }

    return stop;
});

app.Run();
