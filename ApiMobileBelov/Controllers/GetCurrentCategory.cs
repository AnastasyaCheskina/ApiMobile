using ApiMobileBelov.BaseConnection;
using Microsoft.AspNetCore.Mvc;

namespace ApiMobileBelov.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Категории тренировок")]
    public class GetCurrentCategory : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();
        [HttpGet]
        public IActionResult Index(int id)
        {
            return Ok(db.tableCategory.FirstOrDefault(x=>x.IdCategory == id));
        }
    }
}
