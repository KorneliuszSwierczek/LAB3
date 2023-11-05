using LAB3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAB3.Controllers
{
    public class DaneController : Controller
    {
        // GET: DaneController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DaneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DaneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DaneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DaneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DaneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DaneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DaneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (dane.Haslo != dane.PotwierdzHaslo)
            {
                ModelState.AddModelError("PotwierdzHaslo", "Hasło i Potwierdź Hasło muszą być takie same.");
            }

            if (ModelState.IsValid)
            {
                ViewBag.SuccessMessage = "Rejestracja zakończona pomyślnie";
                return View("Wynik", dane);
            }

            return View();
        }

    }
}
