using System;
using System.Collections.Generic;
using csharplist.Models;
using csharplist.Services;
using Microsoft.AspNetCore.Mvc;

namespace csharplist.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    // Get request to get all cars
    // Get one car by its Id
    // Create a car / generate a random Id for it
    // Delete a car by its Id
    // Connect to our cars service to handle requests

    private readonly CarsService _cs;
    public CarsController(CarsService cs)
    {
      _cs = cs;
    }

    [HttpGet]
    public List<Car> GetCars()
    {
      return _cs.GetAll();
    }

    [HttpPost]
    public ActionResult<Car> CreateCar([FromBody] Car carData)
    {
      try
      {
        var car = _cs.CreateCar(carData);
        return Created("api/cars/" + car.Id, car);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    private ActionResult<Car> Created(object p, object car)
    {
      throw new NotImplementedException();
    }
  }

}