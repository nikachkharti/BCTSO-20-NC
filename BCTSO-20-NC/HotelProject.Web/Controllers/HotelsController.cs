using HotelProject.Models;
using HotelProject.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class HotelsController : Controller
    {
        private readonly HotelRepository _hotelRepository;

        public HotelsController(HotelRepository hotelsController)
        {
            _hotelRepository = hotelsController;
        }

        public async Task<IActionResult> Index()
        {
            List<Hotel> hotels = await _hotelRepository.GetHotels();
            return View(hotels);
        }
    }
}
