namespace TennisSystem.Web.Features
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using TennisSystem.Application.Contracts;
    using TennisSystem.Domain.Models.Players;

    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly IRepository<Player> players;

        public PlayerController(IRepository<Player> players)
            => this.players = players;

        [HttpGet]
        public IEnumerable<Player> Get()
            => this.players.All();
    }
}
