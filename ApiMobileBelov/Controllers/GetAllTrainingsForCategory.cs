using ApiMobileBelov.BaseConnection;
using ApiMobileBelov.ModelBase;
using Microsoft.AspNetCore.Mvc;

namespace ApiMobileBelov.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Тренировки")]
    public class GetAllTrainingsForCategory : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();
        [HttpGet]
        public IActionResult Index(int id)
        {
            var allItems = db.tableCategoryAndTraining.Where(x=>x.IdCategory == id).ToList();
            var allTrainings = db.tableTraining.ToList();
            List<Training>? allTrainingsCurrent = new List<Training>();
            foreach (var item in allItems)
            {
                var element = allTrainings.FirstOrDefault(x => x.IdTraining == item.IdTraining);
                if (element != null)
                {
                    allTrainingsCurrent.Add(element);
                }
            }
            return Ok(allTrainingsCurrent);
        }
    }
}
