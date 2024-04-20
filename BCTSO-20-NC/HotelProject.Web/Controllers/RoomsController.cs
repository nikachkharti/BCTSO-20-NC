using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using HotelProject.Repository.MicrosoftDataSQLClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Web.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IHotelRepository _hotelRepository;
        private readonly ApplicationDbContext _context;

        public RoomsController(IRoomRepository roomRepository, IHotelRepository hotelRepository, ApplicationDbContext context)
        {
            _roomRepository = roomRepository;
            _hotelRepository = hotelRepository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _roomRepository.GetRooms();
            return View(result);
        }

        public async Task<IActionResult> Create()
        {
            var hotels = await _hotelRepository.GetHotels();
            ViewBag.Hotels = new SelectList(hotels, "Id", "Name");

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Room model)
        {
            await _roomRepository.AddRoom(model);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var result = await _roomRepository.GetSingleRoom(id);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id)
        {
            await _roomRepository.DeleteRoom(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var result = await _roomRepository.GetSingleRoom(id);
            var hotels = await _hotelRepository.GetHotels();
            ViewBag.Hotels = new SelectList(hotels, "Id", "Name");

            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePOST(Room model)
        {
            await _roomRepository.UpdateRoom(model);
            return RedirectToAction("Index");
        }
    }
}
