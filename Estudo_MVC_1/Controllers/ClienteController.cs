using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estudo_MVC_1.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        //Lista de Clientes
        public ActionResult Index()
        {
            ViewBag.Title = "Lista de Clientes";
            return View();
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Title = "Detalhes sobre o Clientes";
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Cadastro de Cliente";
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Title = "Editar dados do Clientes";
            return View();
        }

        // POST: Cliente/Edit/5
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Title = "Excluir Cliente";
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
