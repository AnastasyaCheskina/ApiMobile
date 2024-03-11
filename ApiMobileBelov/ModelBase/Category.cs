using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMobileBelov.ModelBase
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
    }
}
