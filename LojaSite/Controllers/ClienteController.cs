using LojaSite.DAL;
using LojaSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaSite.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {

            ClienteDAL dal = new ClienteDAL();
            var listaCliente = dal.Listar();
            return View(listaCliente);
        }

        [HttpGet]
        public ActionResult Consultar(int id)
        {
            Cliente cliente = new Cliente();
            cliente = new ClienteDAL().Consultar(id);

            return View(cliente);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View(new Cliente());
        }

        [HttpPost]
        public ActionResult Cadastrar(Models.Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                ClienteDAL dal = new ClienteDAL();

                dal.Inserir(cliente);

                @TempData["message"] = "Cliete inserido com sucesso.";

                return RedirectToAction("Index", "Cliente");

            }
            else
            {
                return View(cliente);
            }
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Cliente cliente = new Cliente();
            cliente = new ClienteDAL().Consultar(id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Editar(Models.Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                ClienteDAL dal = new ClienteDAL();
                dal.Alterar(cliente);

                @TempData["mensagem"] = "Cliente alterado com sucesso.";

                return RedirectToAction("Index", "Cliente");
            }
            else
            {
                return View(cliente);
            }
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            ClienteDAL dal = new ClienteDAL();
            dal.Excluir(id);

            @TempData["mensagem"] = "Cliente alterado com sucesso.";

            return RedirectToAction("Index", "Cliente");
        }
    }
}