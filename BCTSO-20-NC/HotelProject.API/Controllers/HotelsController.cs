using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.API.Controllers
{
    [Route("api/hotels")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly ApplicationDbContext _context;
        public HotelsController(IHotelRepository hotelsController, ApplicationDbContext context)
        {
            _hotelRepository = hotelsController;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHotels()
        {
            var result = await _hotelRepository.GetAllAsync(includeProperties:"Manager");

            if (result.Count == 0)
            {
                return NotFound("Hotels not found");
            }

            return Ok(result);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetSingleHotel([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid parameters passed");
            }

            var result = await _hotelRepository.GetAsync(x => x.Id == id);

            if (result == null)
            {
                return NotFound("Hotels not found");
            }

            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> AddHotel([FromBody] Hotel model)
        {
            if (model == null)
            {
                return BadRequest("Invalid parameters passed");
            }

            await _hotelRepository.AddAsync(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }
    }
}
