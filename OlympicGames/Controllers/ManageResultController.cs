using OlympicGames.Models;
using Microsoft.AspNetCore.Mvc;

namespace OlympicGames.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManageResultController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        public IActionResult GetResults([FromBody] List<ResultHalterofilia> results)
        {
            results = results.GroupBy(r => new { r.Pais, r.Nombre })
            .Select(group => new ResultHalterofilia
            {
                Pais = group.Key.Pais,
                Nombre = group.Key.Nombre,
                Arranque = group.Max(r => r.Arranque),
                Envion = group.Max(r => r.Envion),
            }).OrderByDescending(r => r.TotalPeso).ToList();

            return Ok(results);
        }
    }
}
