using System;
using System.Collections.Generic;
using csharplist.Data;
using csharplist.Models;

namespace csharplist.Services
{
  public class CarsService
  {
    public List<Car> GetAll()
    {
      return FakeDb.Cars;
    }

    public Car GetCarById(int id)
    {
      return FakeDb.Cars.Find(car => car.Id == id);
    }

    public Car CreateCar(Car carData)
    {
      var r = new Random();
      carData.Id = r.Next(1000, 9999);
      FakeDb.Cars.Add(carData);
      return carData;
    }
  }
}