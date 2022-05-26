// using Microsoft.AspNetCore.Mvc;
// using gregslist_infinite.Services;
// using gregslist_infinite.Models;

// namespace gregslist_infinite.Controllers
// {
//   [ApiController]
//   [Route("[controller]")]
//   public class JobsController : ControllerBase
//   {
//     private readonly JobsService _js;
//     public JobsController(JobsService js)
//     {
//       _js = js;
//     }

//     [HttpGet]
//     public ActionResult<List<Job>> Get()
//     {
//       try
//       {
//         List<Job> jobs = _js.Get();
//         return Ok(jobs);
//       }
//       catch (Exception e)
//       {
//         return BadRequest(e.Message);
//       }
//     }
//     [HttpGet]
//     public ActionResult<Job> Get(string id)
//     {
//       try
//       {
//         Job job = _js.Get(id);
//         return Ok(job);
//       }
//       catch (Exception e)
//       {
//         return BadRequest(e.Message);
//       }
//     }
//     [HttpPut]
//     public ActionResult<Job> Edit(string id, [FromBody] Job jobData)
//     {
//       try
//       {
//         jobData.Id = id;
//         Job updated = _js.Edit(jobData);
//         return Ok(updated);
//       }
//       catch (Exception e)
//       {
//         return BadRequest(e.Message);
//       }
//     }
//     [HttpDelete("{id}")]
//     public ActionResult<String> Delete(string id)
//     {
//       try
//       {
//         _js.Delete(id);
//         return Ok("delorted");
//       }
//       catch (Exception e)
//       {
//         return BadRequest(e.Message);
//       }
//     }
//   }
// }