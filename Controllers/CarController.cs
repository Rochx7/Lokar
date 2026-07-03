

using Lokar.Data;
using Lokar.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarController.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CarController : ControllerBase
  {
    private readonly AppDbContext _context;
    public CarController(AppDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public ActionResult<List<CarModel>> GetCars()
    {
      var cars = _context.Cars.ToList();
      return Ok(cars);
    }

    [HttpPost]
    public ActionResult<CarModel> RegisterCar(CarModel car)
    {

      if (car == null || string.IsNullOrEmpty(car.Name))
      {
        return BadRequest("Invalid car data.");
      }

      _context.Cars.Add(car);
      _context.SaveChanges();
      return CreatedAtAction(nameof(GetCars), new { id = car.Id }, car);
    }

    [HttpPut("{id}")]
    public ActionResult<CarModel> UpdateCar(int id, CarModel updatedCar)
    {

      var car = _context.Cars.Find(id);

      if (car == null)
      {
        return NotFound("Car not found.");
      }

      car.Name = updatedCar.Name;
      car.Brand = updatedCar.Brand;
      car.Description = updatedCar.Description;
      car.Category = updatedCar.Category;
      car.Transmission = updatedCar.Transmission;
      car.FuelType = updatedCar.FuelType;
      car.Year = updatedCar.Year;
      car.Color = updatedCar.Color;
      car.Seats = updatedCar.Seats;
      car.DailyRate = updatedCar.DailyRate;
      car.ImageUrl = updatedCar.ImageUrl;

      _context.SaveChanges();

      _context.Cars.Update(car);
      _context.SaveChanges();
      return Ok(car);
    }
  }
}
