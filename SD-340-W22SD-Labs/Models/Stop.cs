using System.ComponentModel.DataAnnotations;

namespace SD_340_W22SD_Labs.Models
{
    public class Stop
    {
        [Key]
        public int Number { get; set; }
        public string Street { get; set; } = null!;
        public string Name { get; set; } = null!;
        public Direction Direction { get; set; }
        public virtual ICollection<ScheduledStop> StopSchedules { get; set; } = new List<ScheduledStop>();
    }
}
