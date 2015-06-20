using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadeMeuMedico.Models;
using System.Data.Entity.Core;
using System.Data.Entity.SqlServer;

namespace CadeMeuMedico.Controllers
{
    public class MedicosController : Controller
    {    // GET: /Medicos/

        private CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities();
 
        public ActionResult Index()
        {
            var medicos = db.Medicos.Include("Cidades").Include("Especialidades").ToList();
            
            return View(medicos);
        }

        public ActionResult Adicionar()
        {
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome");
         
              ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade", "Nome");
            return View();
        }


       
        [HttpPost]
        public ActionResult Adicionar(Medicos medicos)
        {
            if (ModelState.IsValid)
            {
                db.Medicos.Add(medicos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade","Nome",medicos.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade", "Nome",medicos.IDEspecialidade);
            return View(medicos);
        }

    
    }
}
