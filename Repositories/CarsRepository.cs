using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Gregs_infinity.Models;

namespace Gregs_infinity.Repositories
{
  public class CarsRepository
  {
    private readonly IDbConnection _db;

    public CarsRepository(IDbConnection db)
    {
      _db = db;
    }
    // GET
    internal List<Car> Get()
    {
      string sql = @"
      SELECT
        a.*,
        c.*
        FROM cars c
        JOIN accounts a On c.userId = a.id;";
      return _db.Query<Account, Car, Car>(sql, (account, car) =>
      {
        car.Creator = account;
        return car;
      }).ToList();
    }
    // GET BY ID
    internal Car Get(int id)
    {
      string sql = @"
      SELECT
      a.*,
      c.*
      FROM cars c
      JOIN accounts a ON c.userId = a.Id
      WHERE c.id = @id";
      return _db.Query<Account, Car, Car>(sql, (account, car) =>
      {
        car.Creator = account;
        return car;
      }, new { id }).FirstOrDefault();
    }
    // CREATE
    internal Car Create(Car carData)
    {
      string sql = @"
      INSERT INTO cars
      (make, model, price, userId, body, imgUrl)
      VALUES
      (@Make, @Model, @Price, @UserId, @Body, @ImgUrl);
      SELECT LAST_INSERT_ID();
      ";
      carData.Id = _db.ExecuteScalar<int>(sql, carData);
      return carData;
    }
    // EDIT
    // DELETE
  }
}