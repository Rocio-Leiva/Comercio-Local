using Comercio_Local.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Comercio_Local.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IAdminService _adminService;
        public AdminController(ILogger<AdminController> logger, IAdminService adminService)
        {
            _logger = logger;
            _adminService = adminService;
        }
        [HttpPost(Name = "InsertAdmin")]
        public int Post([FromBody] AdminItem admin)
        {
            return _adminService.InsertAdmin(admin);
        }
        [HttpGet(Name = "GetAdmins")]
        public List<AdminItem> GetAdmins()
        {
            return _adminService.GetAdmins();
        }
    }
}