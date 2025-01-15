using FarmFix.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FarmFix.Controllers
{

    public class HomeController : Controller
    
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly ExpensesFarmFixContext _context;
        public HomeController(ILogger<HomeController> logger, ExpensesFarmFixContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Expenses() {

            var allExpenses = _context.Expense.ToList();
            var totalExpenses = allExpenses.Sum(x=>x.Id);

            ViewBag.Expenses = totalExpenses;

            return View(allExpenses);

           
        
        
        }
        public IActionResult CreateEditExpenses(int? id)
        {

            if (id != null) {
                var expenseInDb = _context.Expense.SingleOrDefault(expense => expense.Id == id);
                return View(expenseInDb);
            }

            return View();

        }

        public IActionResult DeleteExpense(int id) {

            var expenseInDb = _context.Expense.SingleOrDefault(expense => expense.Id == id);

            return RedirectToAction("Expense");       
        
        }

        public IActionResult CreateEditExpensesForm(Expenses model)
        {
            if (model.Id == 0)
            {
                _context.Expense.Add(model);
            }
            else {

                _context.Expense.Update(model);

            }
                          
        
            _context.SaveChanges();

            return RedirectToAction("Expenses");


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
