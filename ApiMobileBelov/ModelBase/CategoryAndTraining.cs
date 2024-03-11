using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMobileBelov.ModelBase
{
    [Table("CategoryAngTraining")]
    public class CategoryAndTraining
    {
        [Key]
        public int IdCategoryAndTraining { get; set; }
        public int IdCategory { get; set; }
        public int IdTraining { get; set; }
    }
}
