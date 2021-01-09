namespace TennisSystem.Web.Features
{
    using Microsoft.AspNetCore.Mvc;
    using TennisSystem.Application.Contracts;
    using TennisSystem.Domain.Models.Players;

    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ApiController
    {
        private readonly IRepository<Player> players;

        public PlayerController(IRepository<Player> players)
            => this.players = players;

    }
}
