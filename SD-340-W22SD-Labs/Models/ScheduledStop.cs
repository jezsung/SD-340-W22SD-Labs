using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SD_340_W22SD_Labs.Models
{
    public class ScheduledStop
    {
        [Key]
        public int Id { get; set; }
        public int StopNumber { get; set; }
        public int RouteNumber { get; set; }

        [ForeignKey("StopNumber")]
        public Stop Stop { get; set; } = null!;

        [ForeignKey("RouteNumber")]
        public Route Route { get; set; } = null!;
        public DateTime ScheduledArrival { get; set; }
    }
}
