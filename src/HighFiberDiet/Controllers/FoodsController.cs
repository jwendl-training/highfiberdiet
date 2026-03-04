using Microsoft.AspNetCore.Mvc;
using HighFiberDiet.Data;

namespace HighFiberDiet.Controllers;

public class FoodsController : Controller
{
    private readonly FoodRepository _foodRepository;

    public FoodsController(FoodRepository foodRepository)
    {
        _foodRepository = foodRepository;
    }

    public IActionResult Index(string? search)
    {
        var foods = _foodRepository.GetAll(search);
        ViewData["Search"] = search;
        return View(foods);
    }

    public IActionResult Details(int id)
    {
        var food = _foodRepository.GetById(id);
        if (food is null)
        {
            return NotFound();
        }

        return View(food);
    }
}
