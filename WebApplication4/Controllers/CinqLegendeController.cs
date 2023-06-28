using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CinqLegendeController : Controller
    {
        private NBAEntities db = new NBAEntities();

        // GET: CinqLegende
        public ActionResult Index()
        {
            var joueurs = db.Joueurs;
            return View(joueurs.ToList());
        }

        // GET: CinqLegende/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Joueurs joueurs = db.Joueurs.Find(id);
            if (joueurs == null)
            {
                return HttpNotFound();
            }
            return View(joueurs);
        }

        // GET: CinqLegende/Create
        public ActionResult Create()
        {
            ViewBag.ID_Equipe = new SelectList(db.Equipes, "ID_Equipe", "NOM_Equipe");
            return View();
        }

        // POST: CinqLegende/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Joueur,NOM_Joueur,PRENOM_Joueur,AGE_Joueur,NUMERO_Joueur,POSTE_Joueur,ID_Equipe")] Joueurs joueurs)
        {
            if (ModelState.IsValid)
            {
                db.Joueurs.Add(joueurs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Equipe = new SelectList(db.Equipes, "ID_Equipe", "NOM_Equipe", joueurs.ID_Equipe);
            return View(joueurs);
        }

        // GET: CinqLegende/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Joueurs joueurs = db.Joueurs.Find(id);
            if (joueurs == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Equipe = new SelectList(db.Equipes, "ID_Equipe", "NOM_Equipe", joueurs.ID_Equipe);
            return View(joueurs);
        }

        // POST: CinqLegende/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Joueur,NOM_Joueur,PRENOM_Joueur,AGE_Joueur,NUMERO_Joueur,POSTE_Joueur,ID_Equipe")] Joueurs joueurs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(joueurs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Equipe = new SelectList(db.Equipes, "ID_Equipe", "NOM_Equipe", joueurs.ID_Equipe);
            return View(joueurs);
        }

        // GET: CinqLegende/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Joueurs joueurs = db.Joueurs.Find(id);
            if (joueurs == null)
            {
                return HttpNotFound();
            }
            return View(joueurs);
        }

        // POST: CinqLegende/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Joueurs joueurs = db.Joueurs.Find(id);
            db.Joueurs.Remove(joueurs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
