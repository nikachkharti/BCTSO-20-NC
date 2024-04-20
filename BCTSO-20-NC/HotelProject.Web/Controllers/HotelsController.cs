using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using HotelProject.Repository.MicrosoftDataSQLClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Web.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly ApplicationDbContext _context;

        public HotelsController(IHotelRepository hotelsController, ApplicationDbContext context)
        {
            _hotelRepository = hotelsController;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Hotel> hotels = await _hotelRepository.GetHotels();
            return View(hotels);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePOST(Hotel model)
        {
            await _hotelRepository.AddHotel(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _hotelRepository.GetSingleHotel(id);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id)
        {
            await _hotelRepository.DeleteHotel(id);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Update(int id)
        {
            var result = await _hotelRepository.GetSingleHotel(id);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePOST(Hotel model)
        {
            await _hotelRepository.UpdateHotel(model);
            return RedirectToAction("Index");
        }

    }
}
