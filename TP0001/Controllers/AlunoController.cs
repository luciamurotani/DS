using TP0001.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TP0001.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
      
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Create()
        {
            AlunoViewModel alunoViewModel = new AlunoViewModel();
            return View();
        }

        [HttpPost]
        public ActionResult Create(AlunoViewModel aluno)
        {
            
            return RedirectToAction("Index");
        }

      
    }
}