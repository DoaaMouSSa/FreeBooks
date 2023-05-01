using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBooks.Areas.Admin.Controllers
{
    public class AccountsController : Controller
    {
        [Area("Admin")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
