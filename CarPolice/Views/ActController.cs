using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarPolice.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;
using System.Web.UI;

namespace CarPolice.Views
{

    public class StagesTI
    {

        [Display(Name = "Шумность и токсичность выхлопа в норме")]
        public bool noise { get; set; }

        [Display(Name = "Светотехника в норме")]
        public bool light { get; set; }

        [Display(Name = "Подвеска в норме")]
        public bool pendant { get; set; }

        [Display(Name = "Тормозная система в норме")]
        public bool brake { get; set; }

        [Display(Name = "Кузов в норме")]
        public bool body { get; set; }

    }
    public class  CollectionsModels {
        public Car car1 { get; set; }
        public CarOwner carOwner1 { get; set; }
        public TechnicalInspection technicalInspection1 { get; set; }

        [Display(Name = "Сотрудник ГАИ")]
        public int id_officer { get; set; }

        [Display(Name = "Сотрудник фирмы")]
        public int id_employee { get; set; }

        public StagesTI stagesTI { get; set; }
    }
public class ActController : Controller
    {

        private TRPKEntities db = new TRPKEntities();

        // GET: Cars
        public ActionResult Index(string searchString)
        {
            var results = db.results.Include(r => r.Car).Include(r => r.CarOwner).Include(r => r.CompanyEmployee).Include(r => r.Officer).Include(r => r.TechnicalInspection);
                     
            if (!String.IsNullOrEmpty(searchString))
            {
                results = results.Where(s => s.Car.body_no.Contains(searchString));
            }
            return View(results.ToList());
        }

        // GET: Cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var res = db.results.Find(id);
            if (res == null)
            {
                return HttpNotFound();
            }
            return View(res);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            ViewBag.id_car = new SelectList(db.Car, "id", "body_no");
            ViewBag.id_owner = new SelectList(db.CarOwner, "id", "full_name");
            ViewBag.id_officer = new SelectList(db.Officer, "id", "full_name");
            ViewBag.id_employee = new SelectList(db.CompanyEmployee, "id", "full_name");
            CollectionsModels model = new CollectionsModels();
            return View(model);
        }

        // POST: Cars/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( [Bind(Include = "idOfficer")] int idOfficer, [Bind(Include = "idEmployee")] int idEmployee, CollectionsModels collectionsModels)
        {
            
            if (ModelState.IsValid)
            {
                
                var lastId = (from m in db.Car select m.id).ToList();
                if (lastId.Count == 0)
                {
                    collectionsModels.car1.id = 0;
                }
                else
                {
                    collectionsModels.car1.id = lastId.Last() + 1;
                }
                db.Car.Add(collectionsModels.car1);
                db.SaveChanges();
                var lastIdCarOwner = (from m in db.CarOwner select m.id).ToList();
                if (lastIdCarOwner.Count == 0)
                {
                    collectionsModels.carOwner1.id = 0;
                }
                else
                {
                    collectionsModels.carOwner1.id = lastIdCarOwner.Last() + 1;
                }
                db.CarOwner.Add(collectionsModels.carOwner1);
                db.SaveChanges();
                collectionsModels.technicalInspection1.conclusion = 0;
                if (collectionsModels.stagesTI.body)
                {
                    collectionsModels.technicalInspection1.conclusion++;
                }
                if (collectionsModels.stagesTI.noise)
                {
                    collectionsModels.technicalInspection1.conclusion++;
                }
                if (collectionsModels.stagesTI.pendant)
                {
                    collectionsModels.technicalInspection1.conclusion++;
                }
                if (collectionsModels.stagesTI.brake)
                {
                    collectionsModels.technicalInspection1.conclusion++;
                }
                if (collectionsModels.stagesTI.light)
                {
                    collectionsModels.technicalInspection1.conclusion++;
                }
                var lastIdtechnicalInspection = (from m in db.TechnicalInspection select m.id).ToList();
                if (lastIdtechnicalInspection.Count == 0)
                {
                    collectionsModels.technicalInspection1.id = 0;
                }
                else
                {
                    collectionsModels.technicalInspection1.id = lastIdtechnicalInspection.Last() + 1;
                }
                db.TechnicalInspection.Add(collectionsModels.technicalInspection1);
                db.SaveChanges();
                results res = new results();
                res.id_car= collectionsModels.car1.id;
                res.id_employee = idEmployee;
                res.id_owner= collectionsModels.carOwner1.id;
                res.id_inspection = collectionsModels.technicalInspection1.id;
                res.id_officer = idOfficer;

                var lastIdresults = (from m in db.results select m.id).ToList();
                if (lastIdresults.Count == 0)
                {
                    res.id = 0;
                }
                else
                {
                    res.id = lastIdresults.Last() + 1;
                }

                db.results.Add(res);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(collectionsModels.car1);
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Car.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,body_no,license_plate,mark,color,engine_no,pass_no")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Car.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Car.Find(id);
            db.Car.Remove(car);
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
