using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
    public class ItemsController : Controller
    {

      [HttpGet("/items")]
      public ActionResult Index()
      {
        List<CampingItems> allItems = CampingItems.GetAll(); 
        return View(allItems); 
      }
     

      [HttpGet("/items/new")]
      public ActionResult New()
      {
        return View();
      }

      [HttpPost("/items")]
      public ActionResult Create(string item, int price, int weight, bool packed, string name)
      {
          CampingItems myItem = new CampingItems(item, price, weight, packed, name);
          return RedirectToAction("Index");
      }


      [HttpPost("/items/delete")]
      public ActionResult DeleteAll()
      {
          CampingItems.ClearAll();
          return View();
      }


      [HttpGet("/items/{id}")]
      public ActionResult Show(int id)
      {
          CampingItems foundItem = CampingItems.Find(id);
          return View(foundItem);
      }


    }
}