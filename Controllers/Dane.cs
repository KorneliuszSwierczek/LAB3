using LAB3.Models;
using Microsoft.AspNetCore.Mvc;

public class DaneController : Controller
{
    [HttpGet]
    public IActionResult Form(Dane dane)
    {
        if (ModelState.IsValid)
        {
            return View("Wynik", dane);
        }
        else return View();
    }

    public IActionResult Wynik(Dane dane)
    {
        return View(dane);
    }

}
