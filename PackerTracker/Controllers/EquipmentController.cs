using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
    public class EquipmentController : Controller
    {
        [HttpGet("/equipment")]
        public ActionResult Index()
        {
            List<Equipment> allEquipment = Equipment.GetAll();
            return View(allEquipment);
        }

        [HttpGet("/equipment/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpGet("/equipment/{id}")]
        public ActionResult Show(int Id)
        {
            Equipment packedEquipment = Equipment.Find(Id);
            return View(packedEquipment);
        }

        [HttpPost("/equipment")]
        public ActionResult Create(string itemName, int itemPrice, int itemMass, bool purchaseOrNot, bool packedOrNot)
        {
            Equipment myEquipment = new Equipment(itemName, itemPrice, itemMass, purchaseOrNot, packedOrNot);
            return RedirectToAction("Index");
        }
        
        // [HttpPost("/equipment/delete")]
        // public ActionResult DeleteAll()
        // {
        //     Equipment.ClearAll();
        //     return View();
        // }
    }
}