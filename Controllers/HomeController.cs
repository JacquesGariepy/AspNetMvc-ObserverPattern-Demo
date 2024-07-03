using Microsoft.AspNetCore.Mvc;
using ObserverPatternPoC.Observers;
using ObserverPatternPoC.Services;
using System.Collections.Generic;

public class HomeController : Controller
{
    private readonly DataService _dataService;
    private readonly IObserver _consoleObserver;

    public HomeController(DataService dataService, IObserver consoleObserver)
    {
        _dataService = dataService;
        _consoleObserver = consoleObserver;

        // Enregistrer l'observateur
        _dataService.RegisterObserver(_consoleObserver);
    }

    // Liste pour stocker les éléments
    private static List<string> _items = new List<string>();

    public IActionResult Index()
    {
        ViewBag.Items = _items;
        ViewBag.Message = TempData["LastMessage"] as string ?? "Initial message from Controller";
        return View();
    }

    [HttpPost]
    public IActionResult AddItem(string newItem)
    {
        if (!string.IsNullOrEmpty(newItem))
        {
            _items.Add(newItem);
            _dataService.ChangeData($"Item added: {newItem}");
            TempData["LastMessage"] = $"Item added: {newItem}";
        }
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult UpdateItem(int index, string updatedItem)
    {
        if (index >= 0 && index < _items.Count && !string.IsNullOrEmpty(updatedItem))
        {
            _items[index] = updatedItem;
            _dataService.ChangeData($"Item updated: {updatedItem}");
            TempData["LastMessage"] = $"Item updated: {updatedItem}";
        }
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult DeleteItem(int index)
    {
        if (index >= 0 && index < _items.Count)
        {
            var deletedItem = _items[index];
            _items.RemoveAt(index);
            _dataService.ChangeData($"Item deleted: {deletedItem}");
            TempData["LastMessage"] = $"Item deleted: {deletedItem}";
        }
        return RedirectToAction("Index");
    }
}
