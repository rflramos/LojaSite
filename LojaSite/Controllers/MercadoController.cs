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
            //Instanciar um novo objeto da classe Mercado
            Mercado mercado = new Mercado();


            mercado = new MercadoDAL().Consultar(Id);

            //retorna a lista capturada através do DAL, no banco de dados
            return View(mercado);
        }
        //Anotação de uso do verbo HTTP Get
        [HttpGet]
        public ActionResult Cadastrar()
        {
            System.Diagnostics.Debug.Print("Executou a action Cadastrar()");

            return View(new Mercado());
        }
        //anotação de uso do Verbo HTTP Post
        [HttpPost]
        public ActionResult Cadastrar(Models.Mercado mercado)
        {
            //Se o ModelStat não tiver erro, continua
            if (ModelState.IsValid)
            {
                //cria o objeto DAL
                MercadoDAL dal = new MercadoDAL();

                //Executa o método inserir
                dal.Inserir(mercado);

                //mensagem que aparecerá na view
                @TempData["mensagem"] = "Mercado Cadastrado com sucesso!";

                //Volta para o Index Mercado após cadastro
                return RedirectToAction("Index", "Mercado");
                
                //caso ocorra algum erro retorna para a view Index
            }else
            {
                return View(mercado);
            }
        }

        [HttpGet]
        public ActionResult Editar(int Id)
        {
            Mercado mercado = new Mercado();
            mercado = new MercadoDAL().Consultar(Id);
            return View(mercado);
        }

        [HttpPost]
        public ActionResult Editar(Models.Mercado mercado)
        {
            if (ModelState.IsValid)
            {
                MercadoDAL dal = new MercadoDAL();

                dal.Alterar(mercado);

                @TempData["mensagem"] = "Mercado alterado com sucesso.";

                return RedirectToAction("Index", "Mercado");

            }
            else
            {
                return View(mercado);
            }
        }

        [HttpGet]
        public ActionResult Excluir(int Id)
        {
            MercadoDAL dal = new MercadoDAL();
            dal.Excluir(Id);

            @TempData["mensagem"] = "Mercado removido com sucesso.";

            return RedirectToAction("Index", "Mercado");
        }

    }
}