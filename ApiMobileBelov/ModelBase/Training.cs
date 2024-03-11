using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMobileBelov.ModelBase
{
    [Table("Training")]
    public class Training
    {
        [Key]
        public int IdTraining { get; set; }
        public string? Name { get; set; }
        public int DurationInMin { get; set; }
    }
}
