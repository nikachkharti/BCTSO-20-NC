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
            var result = await _roomRepository.GetAllAsync(includeProperties: "Hotel");
            return View(result);
        }

        public async Task<IActionResult> Create()
        {
            var hotels = await _hotelRepository.GetAllAsync();
            ViewBag.Hotels = new SelectList(hotels, "Id", "Name");

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Room model)
        {
            await _roomRepository.AddAsync(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var result = await _roomRepository.GetAsync(filter: x => x.Id == id, includeProperties: "Hotel");
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id)
        {
            var entityToRemove = await _roomRepository.GetAsync(filter: x => x.Id == id);

            _roomRepository.Remove(entityToRemove);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var result = await _roomRepository.GetAsync(x => x.Id == id, includeProperties: "Hotel");
            var hotels = await _hotelRepository.GetAllAsync();
            ViewBag.Hotels = new SelectList(hotels, "Id", "Name");

            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePOST(Room model)
        {
            await _roomRepository.Update(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
