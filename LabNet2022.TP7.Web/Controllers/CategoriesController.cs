using LabNet2022.TP7.DataAccess.Commands;
using LabNet2022.TP7.Domain.Entities;
using LabNet2022.TP7.Domain.EntitiesDTO;
using LabNet2022.TP7.Domain.Exceptions;
using LabNet2022.TP7.Logic.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LabNet2022.TP7.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IServiceCategories _service;

        public CategoriesController()
        {
            _service = new ServiceCategories(new CategoriesRepository());
        }



        public ActionResult Index()
        {
            List<LabNet2022.TP7.Domain.Categories> list = _service.VerTodos();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Agregar()
        {
            ViewBag.Message = "Agregar Categoria";

            return View();
        }

        [HttpPost]
        public ActionResult Agregar(CategoryDTO category)
        {
            try
            {
                _service.Agregar(category);
                return RedirectToAction("Index");
            }
            catch (Exception) { return View(category); }
        }

        public ActionResult Editar(int id, string name, string description)
        {
            ViewBag.Message = "Editar Categoria";

            var category = new CategoryDTO() { CategoryID = id, CategoryName = name, Description = description };

            return View(category);
        }

        [HttpPost]
        public ActionResult Editar(CategoryDTO category)
        {
            try
            {
                _service.Modificar(category);
                return RedirectToAction("Index");
            }
            catch (Exception) { return View(category); }
        }

        public ActionResult Eliminar(int id)
        {
            try
            {
                _service.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch (NoEliminaException ex)
            {

                return RedirectToAction("Error");

            }
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Provincias()
        {
            try
            {
                var _service = new ServiceProvincias();
                var model = _service.GetProvincias();
                return View(model);
            }
            catch (Exception) { return RedirectToAction("Index"); }
        }




    }
}