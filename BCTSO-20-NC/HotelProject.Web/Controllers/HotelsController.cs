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
            var result = await _hotelRepository.GetAllAsync();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePOST(Hotel model)
        {
            await _hotelRepository.AddAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _hotelRepository.GetAsync(x => x.Id == id);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id)
        {
            var result = await _hotelRepository.GetAsync(x => x.Id == id);

            _hotelRepository.Remove(result);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Update(int id)
        {
            var result = await _hotelRepository.GetAsync(x => x.Id == id);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePOST(Hotel model)
        {
            await _hotelRepository.Update(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
