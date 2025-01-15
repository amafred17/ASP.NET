using ItemListApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class HomeController : Controller
{
    private static List<Item> Items = new List<Item>
    {
        new Item { Id = 1, Name = "Item 1", Price = 10.00m, ImageUrl = "/images/item1.jpg" },
        new Item { Id = 2, Name = "Item 2", Price = 20.00m, ImageUrl = "/images/item2.jpg" },
        new Item { Id = 3, Name = "Item 3", Price = 30.00m, ImageUrl = "/images/item3.jpg" }
    };

    public IActionResult Index()
    {
        return View(Items);
    }

    [HttpPost]
    public IActionResult CalculateTotal(int itemId, int quantity)
    {
        var selectedItem = Items.FirstOrDefault(i => i.Id == itemId);
        if (selectedItem == null)
        {
            return NotFound();
        }

        decimal totalCost = selectedItem.Price * quantity;
        return Json(new { totalCost });
    }
}