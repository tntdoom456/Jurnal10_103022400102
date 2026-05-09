using Jurnal10_103022400102.model;
using Microsoft.AspNetCore.Mvc;

namespace Jurnal10_103022400102.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class GameControllers : ControllerBase
    {
        private static List<Game> games = new List<Game>
        {
            new Game(1, "The Legend of Zelda: Breath of the Wild", "Nintendo", 2017, "Action-adventure", 9.5, new string[] { "Nintendo Switch", "Wii U" }, new string[] { "Single-player" }, false, 59),
            new Game(2, "Red Dead Redemption 2", "Rockstar Games", 2018, "Action-adventure", 9.8, new string[] { "PlayStation 4", "Xbox One", "PC" }, new string[] { "Single-player", "Multiplayer" }, true, 59),
            new Game(3, "The Witcher 3: Wild Hunt", "CD Projekt Red", 2015, "Action role-playing", 9.7, new string[] { "PlayStation 4", "Xbox One", "PC" }, new string[] { "Single-player" }, false, 39),
            new Game(4, "Minecraft", "Mojang Studios", 2011, "Sandbox, survival", 9.0, new string[] { "PC", "Console", "Mobile" }, new string[] { "Single-player", "Multiplayer" }, true, 26),
            new Game(5, "Fortnite", "Epic Games", 2017, "Battle royale", 8.5, new string[] { "PC", "Console", "Mobile" }, new string[] { "Multiplayer" }, true, 0)
        };

        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return games;
        }

        [HttpGet("{id}")]
        public Game Get(int id)
        {
            return games[id];
        }

        [HttpPost]
        public void Post([FromBody] Game game)
        {
            games.Add(game);
        }

        [HttpPut]
        public void Put(int id, [FromBody] Game game)
        {
            games[id] = game;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            games.RemoveAt(id);
        }
    }
}
