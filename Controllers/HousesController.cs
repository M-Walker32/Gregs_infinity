// using Microsoft.AspNetCore.Mvc;
// using gregslist_infinite.Services;
// using gregslist_infinite.Models;

// namespace gregslist_infinite.Controllers
// {
//   [ApiController]
//   [Route("api/[controller]")]
//   public class HousesController : ControllerBase
//   {
//     private readonly HousesService _hs;
//     public HousesController(HousesService hs)
//     {
//       _hs = hs;
//     }
//     // Get All
//     [HttpGet]
//     public ActionResult<List<House>> Get()
//     {
//       try
//       {
//         List<House> houses = _hs.Get();
//         return Ok(houses);
//       }
//       catch (Exception e)
//       {
//         return BadRequest(e.Message);
//       }
//     }
//     // get by Id
//     [HttpGet("{id}")]
//     public ActionResult<House> Get(string id)
//     {
//       try
//       {
//         House house = _hs.Get(id);
//         return Ok(house);
//       }
//       catch (Exception e)
//       {
//         return BadRequest(e.Message);
//       }
//     }
//     // Create
//     [HttpPost]
//     public ActionResult<House> Create([FromBody] House houseData)
//     {
//       try
//       {
//         House newHouse = _hs.Create(houseData);
//         return Ok(newHouse);
//       }
//       catch (Exception e)
//       {
//         return BadRequest(e.Message);
//       }
//     }
//     // Edit
//     [HttpPut]
//     public ActionResult<House> Edit(string id, [FromBody] House houseData)
//     {
//       try
//       {
//         houseData.Id = id;
//         House updated = _hs.Edit(houseData);
//         return Ok(updated);
//       }
//       catch (Exception e)
//       {
//         return BadRequest(e.Message);
//       }
//     }
//     // Delete
//     [HttpDelete("{id}")]
//     public ActionResult<String> Delete(string id)
//     {
//       try
//       {
//         _hs.Delete(id);
//         return Ok("delorted");
//       }
//       catch (Exception e)
//       {
//         return BadRequest(e.Message);
//       }
//     }
//   }
// }