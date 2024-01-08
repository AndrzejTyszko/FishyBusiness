using FishyBuisness_3.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

public class OrderController : Controller
{
    public IActionResult Index()
    {
        // Pobierz dane zamówień (przykładowe dane)
        var orders = GetOrdersFromDatabaseOrOtherSource();

        return View(orders);
    }

    private List<Order> GetOrdersFromDatabaseOrOtherSource()
    {
       
        return new List<Order>
        {
           
            
        };
    }

    public IActionResult AddToCart(int fishId)
    {
        
        return RedirectToAction("Index");
    }
}