using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using Gregs_infinity.Models;
using Gregs_infinity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gregs_infinity.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;

    public CarsController(CarsService cs)
    {
      _cs = cs;
    }
    // Get All
    [HttpGet]
    public ActionResult<List<Car>> Get()
    {
      try
      {
        List<Car> cars = _cs.Get();
        return Ok(cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // Get by ID
    [HttpGet("{id}")]
    public ActionResult<Car> Get(int id)
    {
      try
      {
        Car car = _cs.Get(id);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // Create
    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Car>> Create([FromBody] Car carData)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        carData.UserId = userInfo.Id;
        Car newCar = _cs.Create(carData);
        // Note populate creator?
        newCar.Creator = userInfo;
        return Ok(newCar);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // // Put
    // [HttpPut("{id}")]
    // [Authorize]
    // public async Task<ActionResult<Car>> Edit(int id, [FromBody] Car carData)
    // {
    //   try
    //   {
    //     Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
    //     carData.UserId = userInfo.Id;

    //     carData.Id = id;
    //     Car updated = _cs.Edit(carData);
    //     return Ok(updated);

    //   }
    //   catch (Exception e)
    //   {
    //     return BadRequest(e.Message);
    //   }
    // }
    // // Delete
    // [HttpDelete("{id}")]
    // [Authorize]
    // public async Task<ActionResult<String>> Delete(int id)
    // {
    //   try
    //   {
    //     Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
    //     _cs.Delete(id, userInfo.Id);
    //     return Ok("delorted");
    //   }
    //   catch (Exception e)
    //   {
    //     return BadRequest(e.Message);
    //   }
    // }
  }
}