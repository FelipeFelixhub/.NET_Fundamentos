using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}