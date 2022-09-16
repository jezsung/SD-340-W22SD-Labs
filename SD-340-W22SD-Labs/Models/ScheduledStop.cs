namespace SD_340_W22SD_Labs.Models
{
    public class ScheduledStop
    {
        public int Id { get; set; }
        public Stop Stop { get; set; }
        public Route Route { get; set; }
        public DateTime ScheduledArrival { get; set; }
    }
}
