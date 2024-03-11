using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMobileBelov.ModelBase
{
    [Table("Workout")]
    public class Workout
    {
        [Key]
        public int IdWorkout { get; set; }
        public string? Name { get; set; }
        public int DurationInSec { get; set; }
        public string? Description { get; set; }
        public string? VideoURL { get; set; }
    }
}
