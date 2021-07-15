using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VAT.api.AbstractServices;
using VAT.api.Models;

namespace VAT.api.Controllers
{
   [Route("api/v1/[controller]")]
   public class ActivityTrackerController : ControllerBase
   {
      private readonly IActivityTracker<VMT_County> _tracker;
      public ActivityTrackerController(IActivityTracker<VMT_County> tracker)
      {
         _tracker = tracker;
      }

      [HttpGet("getall")]
      public async Task<IActionResult> GetAllData()
      {
          var result = await _tracker.Get_All_dataAsync();
          return Ok(result);
      }

      [HttpGet]
      public async Task<IActionResult> Get(int id=0)
      {
          if(id == 0)
            return BadRequest("An ID must be provide.");
          
          var result = await _tracker.GetDataAsync(id);
          return Ok(result);
      }

      [HttpPost("create")]
      public async Task<IActionResult> Add([FromBody] VMT_County model)
      {
          if(string.IsNullOrEmpty(model.state_name) && model.county_vmt == 0)
            return BadRequest("The state name and the county VMT are required");

          var result = await _tracker.AddDataAsync(model);
          if(result)
            return Created("Data created",null);
          
          return BadRequest("Something went wrong. Ask to customer support for help.");          
      }

      [HttpDelete("delete")]
      public async Task<IActionResult> Delete(int id)
      {
          if(id == 0)
            return BadRequest("An ID must be provide.");
          
          var result = await _tracker.DeleteDataAsync(id);
          if(result)
            return Ok(result);
          
          return BadRequest("Something went wrong. Ask to customer support for help.");
      }

      [HttpPut("update")]
      public async Task<IActionResult> Put(int id, [FromBody] VMT_County model)
      {
          if(string.IsNullOrEmpty(model.state_name) && model.county_vmt == 0)
            return BadRequest("The state name and the county VMT are required");

          var result = await _tracker.UpdateDataAsync(model);
          if(result)
            return Ok(result);
          
          return BadRequest("Something went wrong. Ask to customer support for help.");
      }
   }
}