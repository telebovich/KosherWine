using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using KosherWine.Logging;
using KosherWine.Models;

namespace KosherWine.Controllers
{
    public class CategoriesController : Controller
    {
        //
        // GET: /Categories/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Categories/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Categories/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Categories/Create

        [HttpPost]
        public ActionResult Create(Category category)
        {
            // This is the subcategories setup
            // if (category.ParentCategory == null)
            // {
            //     throw new NotImplementedException();
            // }

            // The following code works without subcategories
            try
            {
                // TODO: Add insert logic here
                               
                try
                {
                    Repository.Add<Category>(category);
                }
                catch (Exception exception)
                {
                    Logger.Log.Error(string.Format("Unable to create Category: {0};{1}", 
                        exception.Message, exception.InnerException));
                }

                return View("Index", Repository.GetAllItems<Category>());
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Categories/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Categories/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Categories/Delete/5
 
        public ActionResult Delete(int id)
        {
            Category category = Repository.GetItemById<Category>(id);
            Repository.Delete<Category>(category);
            return RedirectToAction("Index", "Administration");
            //return View(category);
        }

        //
        // POST: /Categories/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            /*try
            {
                // TODO: Add delete logic here
                
                Category category = Repository.GetItemById<Category>(id);
                Repository.Delete<Category>(category);
                
                return RedirectToAction("Index", "Administration");
                // return View("Index", Repository.GetAllItems<Category>());
            }
            catch (Exception exception)
            {
                Logger.Log.Error(string.Format("{0}\n{1}", exception.Message, exception.InnerException));
                return View();
            }*/
            return View();
        }

        public ActionResult Administer()
        {
            return View();
        }
    }
}
