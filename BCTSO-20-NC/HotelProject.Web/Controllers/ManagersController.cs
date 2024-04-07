using HotelProject.Models;
using HotelProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelProject.Web.Controllers
{
    public class ManagersController : Controller
    {
        private readonly ManagerRepository _managerRepository;
        private readonly HotelRepository _hotelRepository;
        public ManagersController(HotelRepository hotelRepository, ManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
            _hotelRepository = hotelRepository;
        }

        public async Task<IActionResult> Index()
        {
            List<Manager> managers = await _managerRepository.GetManagers();
            return View(managers);
        }


        //TODO GetHotelsWithoutManager method.
        //public async Task<IActionResult> Create()
        //{
        //    var hotels = await _hotelRepository.GetHotelsWithoutManager();
        //    ViewBag.HotelId = new SelectList(hotels, "Id", "Name");
        //    return View();
        //}


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
