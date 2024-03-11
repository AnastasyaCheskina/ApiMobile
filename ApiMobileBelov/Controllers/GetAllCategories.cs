using ApiMobileBelov.BaseConnection;
using Microsoft.AspNetCore.Mvc;

namespace ApiMobileBelov.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Категории тренировок")]
    public class GetAllCategories : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(db.tableCategory.ToList());
        }
    }
}
