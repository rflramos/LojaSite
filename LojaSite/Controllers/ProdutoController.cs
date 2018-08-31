using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaSite.DAL;
using LojaSite.Models;

namespace LojaSite.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        
        public ActionResult Index()
        {
            ProdutoDAL dal = new ProdutoDAL();
            var listaProduto = dal.Listar();
            
            return View(listaProduto);
        }

        [HttpGet]
        public ActionResult Consultar (int Id)
        {
            Produto produto = new Produto();
            produto = new ProdutoDAL().Consultar(Id);
            return View(produto);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View(new Produto());
        }

        [HttpPost]
        public ActionResult Cadastrar(Models.Produto produto)
        {

            // se o ModelState não tem erro
            if (ModelState.IsValid)
            {
                //instancia um novo objeto DAL
                ProdutoDAL dal = new ProdutoDAL();

                //executa o metodo inserir localizado na classe produtoDAL
                dal.Inserir(produto);

                //envia mensagem de sucesso na view
                @TempData["mensagem"] = "Produto cadastrado com sucesso.";

                //redireciona para o Index do produto
                return RedirectToAction("Index", "Produto");

                //Encontrou um erro no preenchimento do campo novo produto
            }
            else
            {
                //retorna para a tela do formulário
                return View(produto);
            }
        }

        [HttpGet]
        public ActionResult Editar(int Id)
        {
            Produto produto = new Produto();
            produto = new ProdutoDAL().Consultar(Id);
            return View(produto);
        }
        [HttpPost]
        public ActionResult Editar(Models.Produto produto)
        {
            // se o ModelState for válido
            if (ModelState.IsValid)
            {
                //instancia um objeto dal
                ProdutoDAL dal = new ProdutoDAL();

                dal.Alterar(produto);

                @TempData["mensagem"] = "Produto alterado com sucesso";
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                //retorna para a tela do formulário
                return View(produto);
            }

        }
        [HttpGet]
        public ActionResult Excluir(int Id)
        {
            ProdutoDAL dal = new ProdutoDAL();
            dal.Excluir(Id);

            @TempData["mensagem"] = "Produto removido com sucesso";

            return RedirectToAction("Index", "Produto");
        }

    }
}