using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMobileBelov.ModelBase
{
    [Table("CategoryAndTraininhAndWorkout")]
    public class CategoryAndTraininhAndWorkout
    {
        [Key]
        public int IdCategoryAndTrainingAndWorkout { get; set; }
        public int IdCategoryAndTraining { get; set; }
        public int IdWorkout { get; set; }
    }
}
