using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class GuestbookController : Controller
    {
        private GuestbookContext _db = new GuestbookContext();

        public ActionResult Show(int id)
        {
            var existEntry = _db.Entries.Any(e => e.Id == id);
            if (!existEntry)
            {
                return RedirectToAction("Index");
            }
            var entry = _db.Entries.Find(id);
            bool hasPermission = User.Identity.Name == entry.Name;
            ViewData["hasPermission"] = hasPermission;
            return View(entry);
        }

        public ActionResult Index()
        {
            var mostRecentEntries =
                _db.Entries
                .OrderByDescending(g => g.DateAdded)
                .Take(20);

            ViewBag.Entries = mostRecentEntries.ToList();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GuestbookEntry entry)
        {
            entry.DateAdded = DateTime.Now;

            _db.Entries.Add(entry);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
