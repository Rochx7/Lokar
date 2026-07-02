

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
  }
}
