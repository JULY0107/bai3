using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bai3.Models
{
    public class categoryController : Controller
    {
        //gia lap co so du lieu
        public static List<Models.category> categorys = new List<Models.category>()
    {
        new category() { Id =1, Name = "Laptop"},
        new category() { Id =2, Name = "Laptop2"},
        new category() { Id =3, Name = "Laptop3"},
    };
        // GET: categoryController

        public ActionResult Index()
        {
            return View(categorys);
        }

        // GET: categoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = categorys.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);

        }

        // GET: categoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: categoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(category category)
        {
            category.Id = categorys.Count + 1;
            categorys.Add(category);
            return RedirectToAction(nameof(Index));
            
        }

        // GET: categoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: categoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(category category)
        {
            var existingCategory = categorys.FirstOrDefault(c => c.Id == category.Id);
            if (existingCategory == null)
            {
                return NotFound();
            }
            existingCategory.Name = category.Name;
            return RedirectToAction(nameof(Index));

        }

        // GET: categoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = categorys.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: categoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var category = categorys.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            categorys.Remove(category);
            return RedirectToAction(nameof(Index));

        }
    }
}
