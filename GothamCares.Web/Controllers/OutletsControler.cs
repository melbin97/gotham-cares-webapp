using GothamCares.BLL;
using GothamCares.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCares.Web.Controllers
{    
    [ApiController]
    public class OutletsControler : ControllerBase
    {
        [HttpGet]
        [Route("api/outlets")]
        public async Task<IActionResult> GetOutlets()
        {
            OutletBLL outletBLL = new OutletBLL();
            var outlets = await outletBLL.GetAllOutlets();

            return Ok(outlets);
        }

        [HttpPost]
        [Route("api/outlets")]
        public IActionResult CreateOutlet([FromBody] Outlet outlet)
        {            
            return Ok();
        }

    }
}
