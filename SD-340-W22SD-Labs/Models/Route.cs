using System.ComponentModel.DataAnnotations;

namespace SD_340_W22SD_Labs.Models
{
    public class Route
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; } = null!;
        public Direction Direction { get; set; }
        public bool RampAccessible { get; set; }
        public bool BicycleAccessible { get; set; }
        public virtual ICollection<ScheduledStop> StopSchedules { get; set; } = new List<ScheduledStop>();
    }
}
