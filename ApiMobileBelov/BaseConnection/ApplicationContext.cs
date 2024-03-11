using ApiMobileBelov.ModelBase;
using Microsoft.EntityFrameworkCore;

namespace ApiMobileBelov.BaseConnection
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Category> tableCategory { get; set; }
        public DbSet<Training> tableTraining { get; set; }
        public DbSet<CategoryAndTraining> tableCategoryAndTraining { get; set; }
        public DbSet<Workout> tableWorkout { get; set; }
        public DbSet<CategoryAndTraininhAndWorkout> tableCategoryAndTrainingAndWorkout { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constans.SqlConnection);
        }
    }
}
