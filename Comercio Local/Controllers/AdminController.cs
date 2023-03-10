using Comercio_Local.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Comercio_Local.Controllers
{
    [ApiController]
    [Route("[controller] /[action]")]
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
        public int Post([FromBody] AdminItem adminItem)
        {
            return _adminService.InsertAdmin(adminItem);
        }

        [HttpGet(Name = "GetAllAdmins")]
        public List<AdminItem> GetAllAdmins()
        {
            return _adminService.GetAllAdmins();
        }
       
        [HttpDelete(Name = "DeleteAdminItem")]
        public void DeleteAdminItem([FromQuery] int id)
        {
            _adminService.DeleteAdminItem(id);
        }

        [HttpPatch(Name = "ModifyAdmin")]
        public void Patch([FromBody] AdminItem adminItem)
        {

            
           _adminService.UpdateAdmin(adminItem);
            

        }

    }
}


