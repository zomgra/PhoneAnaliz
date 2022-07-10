using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneAnalyze.Data;
using PhoneAnalyze.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneAnalyze.Controllers
{
    public class AnalysisController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int[] id)
        {
            Console.WriteLine($"{id[0]}   {id[1]}");
            var allPhone = DbManager.DB.GetAllPhones();
            var allNeedPhone = new List<PhoneViewModel>();
            foreach (int item in id)
            {
                allNeedPhone.Add(allPhone.Find(p => p.PhoneId == item));
            }
            return View(allNeedPhone);
        }
    }
}
