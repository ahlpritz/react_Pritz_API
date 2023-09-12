using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pritz_API.Data;

namespace Pritz_API.Controllers
{
    [Route("api/MenuItem")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public MenuItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetMenuItems()
        {
            return Ok(_db.MenuItems);
        }
    }
}
