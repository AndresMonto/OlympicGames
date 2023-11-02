using Microsoft.AspNetCore.Mvc;
using OlympicGames.Data.LogicBussiness;
using OlympicGames.Data.Models;

namespace OlympicGames.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManageResultController : ControllerBase
    {
        private readonly LB_ManageResult<ResultHalterofilia> LB_ManageResult;

        public ManageResultController(DbContextOlympicGames DbContext)
        {
            this.LB_ManageResult = new(DbContext);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetResults()
        {
            ResultBase<ResultHalterofilia> result = LB_ManageResult.GetOrderedData();

            if (!result.StatusBase.Error)
                return Ok(result.ResultList);
            else
                return BadRequest(result.StatusBase);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult InsertResults([FromBody] ResultHalterofilia entity)
        {
            ResultBase<ResultHalterofilia> result = LB_ManageResult.InsertData(entity);
            if (!result.StatusBase.Error)
                return Ok(result.StatusBase);
            else
                return BadRequest(result.StatusBase);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult InsertMultipleResults([FromBody] List<ResultHalterofilia> entity)
        {
            ResultBase<ResultHalterofilia> result = LB_ManageResult.InsertMultipleData(entity);
            if (!result.StatusBase.Error)
                return Ok(result.StatusBase);
            else
                return BadRequest(result.StatusBase);

        }
    }
}
