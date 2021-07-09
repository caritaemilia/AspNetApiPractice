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
    public class ScoreController : ControllerBase
    {

        private IScoreData _scoreData;
        public ScoreController(IScoreData scoreData)
        {
            _scoreData = scoreData;
        }


        [HttpGet]
        public IActionResult GeScores()
        {
            return Ok(_scoreData.GetScores());
        }


        [HttpGet("{id}")]
        public IActionResult GetScores(int id)
        {
            var score = _scoreData.GetScore(id);
            if (score != null)
            {
                return Ok(score);
            }

            return NotFound($"Score with Id :{id} was not found");
        }

        [HttpPost]
        public IActionResult GetScore(Score score)
        {
            _scoreData.AddScore(score);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + score.Id, score);

        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteScore(int id)
        {
            var score = _scoreData.GetScore(id);
            if (score != null)
            {
                _scoreData.DeleteScore(score);
                return Ok("Score has been deleted");
            }
            return NotFound($"Score with Id: {id} was not found");
        }

    }
}
