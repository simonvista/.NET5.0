using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExpenseController(ApplicationDbContext db)
        {
            // DI
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Expense> objList = _db.Expenses;
            return View(objList);
            //return View();
        }
        // Get by default
        public IActionResult Create()
        {
            return View();
        }
        // Post 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense Expense)
        {
            _db.Expenses.Add(Expense);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
