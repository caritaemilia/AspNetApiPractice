﻿using home_assingment_7.Models;
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
    public class PlayersController : ControllerBase
    {
        private IPlayersData _playerData;

        public PlayersController(IPlayersData playerData)
        {
            _playerData = playerData;
        }


        [HttpGet]
        public IActionResult GetPlayers()
        {
            return Ok(_playerData.GetPlayers());
        }

        [HttpPost]
        public IActionResult CreatePlayer(Players player)
        {
           _playerData.AddPlayer(player);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + player.Id, player);

        }


    }
}
