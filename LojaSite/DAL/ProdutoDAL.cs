using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaSite.Models;
using LojaSite.DAL.Context;


namespace LojaSite.DAL
{
    public class ProdutoDAL
    {
        public IList<Produto> Listar()
        {
            IList<Produto> lista = new List<Produto>();

            LojaContext context = new LojaContext();

            lista = context.Produto.ToList<Produto>();

            return lista;
        }
    }
}