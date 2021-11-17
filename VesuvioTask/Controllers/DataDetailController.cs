using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VesuvioTask.Services;

namespace VesuvioTask.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class DataDetailController : ControllerBase
    {
        private readonly IDataDetailServices _idataservice;

        public DataDetailController(IDataDetailServices idata)
        {
            _idataservice = idata;
        }
        [HttpPost]
        public IActionResult SaveDataDetail([FromBody]DataDetail d)
        {
            if (ModelState.IsValid)
            {
                _idataservice.SaveData(d);
                if (_idataservice.SaveChanges()) return Ok("Successfully Saved");
            }
            return BadRequest("Not Saved");
        }
    }
}
