using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using J_J_Beauty_Studio.Models;
using Microsoft.AspNetCore.Mvc;

namespace J_J_Beauty_Studio.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new DbConnect())
            {
                var preservation = db.preservation.ToList();
                return View(preservation);
            }
        }
    }
}