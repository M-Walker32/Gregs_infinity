using System;
using System.Collections.Generic;
using Gregs_infinity.Models;
using Gregs_infinity.Repositories;

namespace Gregs_infinity.Services
{
  public class CarsService
  {
    private readonly CarsRepository _repo;
    public CarsService(CarsRepository repo)
    {
      _repo = repo;
    }
    // GET
    internal List<Car> Get()
    {
      return _repo.Get();
    }
    // GET BY ID
    internal Car Get(int id)
    {
      Car car = _repo.Get(id);
      if (car == null)
      {
        throw new Exception("invalid Id");
      }
      return car;
    }
    // CREATE
    internal Car Create(Car carData)
    {
      return _repo.Create(carData);
    }
    // EDIT
    // internal Car Edit(Car carData)
    // {
    //   Car original = Get(carData.Id);
    //   if (original.UserId != carData.UserId)
    //   {
    //     throw new Exception("You cannot edit this");
    //   }
    //   original.Make = carData.Make ?? original.Make;
    //   original.Model = carData.Model ?? original.Model; ;
    //   original.ImgUrl = carData.ImgUrl ?? original.ImgUrl;
    //   _repo.Edit(original);
    //   return Get(original.Id);
    // }
    // DELETE
    // internal void Delete(int id, string userId)
    // {
    //   Car car = Get(id);
    //   if (car.UserId != userId)
    //   {
    //     throw new Exception("You cannot delete this");
    //   }
    //   _repo.Delete(id);
    // }
  }
}