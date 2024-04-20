using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Web.Controllers
{
    public class ManagersController : Controller
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IHotelRepository _hotelRepository;
        private readonly ApplicationDbContext _context;

        public ManagersController(IHotelRepository hotelRepository, IManagerRepository managerRepository, ApplicationDbContext context)
        {
            _managerRepository = managerRepository;
            _hotelRepository = hotelRepository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Manager> managers = await _managerRepository.GetManagers();
            return View(managers);
        }


        public async Task<IActionResult> Create()
        {
            var hotels = await _hotelRepository.GetHotelsWithoutManager();
            ViewBag.HotelId = new SelectList(hotels, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Manager model)
        {
            await _managerRepository.AddManager(model);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var result = await _managerRepository.GetSingleManager(id);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id)
        {
            await _managerRepository.DeleteManager(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var result = await _managerRepository.GetSingleManager(id);
            var hotels = await _hotelRepository.GetHotelsWithoutManager();
            ViewBag.HotelsWithoutManagers = new SelectList(hotels, "Id", "Name");

            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePOST(Manager model)
        {
            await _managerRepository.UpdateManager(model);
            return RedirectToAction("Index");
        }
    }
}
