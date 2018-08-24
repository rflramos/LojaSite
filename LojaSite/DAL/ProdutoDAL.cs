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

        public Produto Consultar(int id)
        {
            //criar classe de contexto
            LojaContext context = new LojaContext();

            //recuperar o o bjeto produro de um determinado id
            Produto produto = context.Produto.Find(id);

            return produto;
        }

        public void Inserir(Produto produto)
        {
            //classe de contexto
            LojaContext context = new LojaContext();

            //adicionando um objeto produto
            context.Produto.Add(produto);

            //salvando as alterações no banco
            context.SaveChanges();

        }

        public void Alterar (Produto produto)
        {
            //instanciando a classe de contexto
            LojaContext context = new LojaContext();

            //Informando a classe de contexo o status do produto MODIFIED
            context.Entry(produto).State = System.Data.Entity.EntityState.Modified;

            //salvando as alterações
            context.SaveChanges();
        }

        public void Excluir (int id)
        {
            //Instanciando a classe contexto
            LojaContext context = new LojaContext();

            //Efetuando busca por um ID
            Produto produto = context.Produto.Find(id);

            //Informa ao contexto que um objeto foi deletado
            context.Entry(produto).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();
        }
    }
}