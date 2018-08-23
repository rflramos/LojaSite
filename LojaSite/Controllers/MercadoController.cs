using LojaSite.DAL;
using LojaSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaSite.Controllers
{
    public class MercadoController : Controller
    {
        // GET: Mercado
        public ActionResult Index()
        {

            IList<Models.Mercado> listaMercado = new List<Models.Mercado>();

            MercadoDAL dal = new MercadoDAL();

            listaMercado = dal.Listar();

            return View(listaMercado);
        }

        [HttpGet]
        public ActionResult Consultar(int Id)
        {
            Mercado mercado = new Mercado();
            mercado = new MercadoDAL().Consultar(Id);

            return View(mercado);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            System.Diagnostics.Debug.Print("Executou a action Cadastrar()");

            return View(new Mercado());
        }

        [HttpPost]
        public ActionResult Cadastrar(Models.Mercado mercado)
        {
            if (ModelState.IsValid)
            {
                MercadoDAL dal = new MercadoDAL();

                dal.Inserir(mercado);

                TempData["mensagem"] = "Mercado Cadastrado com sucesso!";

                return RedirectToAction("Index", "Mercado");
                
            }else
            {
                return View(mercado);
            }
        }
    }
}