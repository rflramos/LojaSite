using LojaSite.Models;
using System;
using LojaSite.DAL.Context;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaSite.DAL
{
    public class MercadoDAL
    {
        public IList<Mercado> Listar()
        {
            IList<Mercado> lista = new List<Mercado>();

            //criar a classe de contexto
            LojaContext context = new LojaContext();

            lista = context.Mercado.ToList<Mercado>();

            //retorna a lista
            return lista;

        }
        
        public Mercado Consultar(int id)
        {
            // cria a classe de contexto
            LojaContext context = new LojaContext();

            //recupera o objeto mercado de um determinado ID
            Mercado mercado = context.Mercado.Find(id);

            return mercado;
        }

        public void Inserir(Mercado mercado)
        {
            //criar classe de contexto
            LojaContext context = new LojaContext();

            //inserir novo objeto na classe Mercado
            context.Mercado.Add(mercado);

            //Salver as alterações na tabela
            context.SaveChanges();
        }

        public void Alterar(Mercado mercado)
        {
            //criar a classe de contexto
            LojaContext context = new LojaContext();

            //informar ao context que um objeto foi alterado
            context.Entry(mercado).State = System.Data.Entity.EntityState.Modified;

            //salvar as alterações
            context.SaveChanges();

        }

        public void Excluir (int id)
        {
            //criar classe de contexto
            LojaContext context = new LojaContext();

            //recuperar o objeto mercado de um determinado id
            Mercado mercado = context.Mercado.Find(id);

            //informar ao context que um objeto foi alterado
            context.Entry(mercado).State = System.Data.Entity.EntityState.Deleted;

            //salvar as alterações
            context.SaveChanges();
        }
    }
}