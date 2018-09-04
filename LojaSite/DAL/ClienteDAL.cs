using LojaSite.DAL.Context;
using LojaSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaSite.DAL
{
    public class ClienteDAL
    {
        //criar lista utilizando interface IList
        public IList<Cliente> Listar()
        {
            IList<Cliente> lista = new List<Cliente>();

            LojaContext context = new LojaContext();

            lista = context.Cliente.ToList<Cliente>();

            return lista;
        }

        public Cliente Consultar(int id)
        {
            LojaContext context = new LojaContext();

            Cliente cliente = context.Cliente.Find(id);

            return cliente;
        }

        public void Inserir(Cliente cliente)
        {
            LojaContext context = new LojaContext();

            context.Cliente.Add(cliente);

            context.SaveChanges();
        }

        public void Alterar(Cliente cliente)
        {
            LojaContext context = new LojaContext();

            context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            LojaContext context = new LojaContext();

            Cliente cliente = context.Cliente.Find(id);

            context.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();
        }

    }
}