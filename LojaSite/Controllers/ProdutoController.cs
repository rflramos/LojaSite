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
    }
}