using ApiMobileBelov.BaseConnection;
using ApiMobileBelov.ModelBase;
using Microsoft.AspNetCore.Mvc;

namespace ApiMobileBelov.Controllers
{
    [Route("api/[controller]/{idCategory}/{idTraining}")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Упражнения")]
    public class GetAllWorkoutForTraining : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();
        [HttpGet]
        public IActionResult Index(int idCategory, int idTraining)
        {
            var allWorkouts = db.tableWorkout.ToList();
            var item = db.tableCategoryAndTraining.FirstOrDefault(x=>x.IdTraining == idTraining && x.IdCategory == idCategory);
            var allItems = db.tableCategoryAndTrainingAndWorkout.ToList();
            var obj = allItems.Where(x=>x.IdCategoryAndTraining == item.IdCategoryAndTraining).ToList();
            List<Workout> workouts = new List<Workout>();
            foreach (var a in obj)
            {
                var element = allWorkouts.FirstOrDefault(x => x.IdWorkout == a.IdWorkout);
                if (element != null)
                {
                    workouts.Add(element);
                }
            }
            return Ok(workouts);
        }
    }
}
