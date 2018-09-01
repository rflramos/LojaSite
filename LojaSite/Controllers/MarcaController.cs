using LojaSite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaSite.Models
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            MarcaDAL dal = new MarcaDAL();
            var listaMarca = dal.Listar();
            return View(listaMarca);
        }

        [HttpGet]
        public ActionResult Consultar(int Id)
        {
            Marca marca = new Marca();
            marca = new MarcaDAL().Consultar(Id);

            return View(marca);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View(new Marca());
        }

        [HttpPost]
        public ActionResult Cadastrar(Models.Marca marca)
        {
            if (ModelState.IsValid)
            {
                MarcaDAL dal = new MarcaDAL();

                dal.Inserir(marca);

                @TempData["mensagem"] = "Marca cadastrada com sucesso.";

                return RedirectToAction("Index", "Marca");
            }
            else
            {
                return View(marca);
            }
        }
        [HttpGet]
        public ActionResult Editar(int Id)
        {
            Marca marca = new Marca();
            marca = new MarcaDAL().Consultar(Id);
            return View(marca);
        }

        [HttpPost]
        public ActionResult Editar(Models.Marca marca)
        {
            if (ModelState.IsValid)
            {
                MarcaDAL dal = new MarcaDAL();
                dal.Alterar(marca);

                @TempData["mensagem"] = "Marca alterado com sucesso.";

                return RedirectToAction("Index", "Marca");
            }
            else
            {
                return View(marca);
            }
        }

        [HttpGet]
        public ActionResult Excluir(int Id)
        {
            MarcaDAL dal = new MarcaDAL();
            dal.Excluir(Id);

            @TempData["mensagem"] = "Marca excluido com sucesso";

            return RedirectToAction("Index", "Marca");
        }

    }
}