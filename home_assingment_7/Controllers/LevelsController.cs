using home_assingment_7.Models;
using home_assingment_7.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace home_assingment_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelsController : ControllerBase
    {
        private ILevelsData _levelData;
        public LevelsController(ILevelsData levelData)
        {
            _levelData = levelData;
        }

        [HttpGet]
        public IActionResult GetLevels()
        {
            return Ok(_levelData.GetLevels());
        }


        [HttpPost]
        public IActionResult CreateLevel(Levels level)
        {
            _levelData.AddLevel(level);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + level.Id, level);

        }

    }
}
