using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaSite.DAL.Context;
using LojaSite.Models;

namespace LojaSite.DAL
{
    public class MarcaDAL
    {
        //criação de list utilizando a interface IList
        public IList<Marca> Listar()
        {
            IList<Marca> lista = new List<Marca>();

            //criando classe de contexto
            LojaContext context = new LojaContext();

            //ToList - metodo que força a consulta imediata e retorna a lista
            lista = context.Marca.ToList<Marca>();

            //retorna lista
            return lista;
        }

        public Marca Consultar(int Id)
        {
            //criar classes de contexto
            LojaContext context = new LojaContext();

            //recupera o objeto marca de um determinado ID
            Marca marca = context.Marca.Find(Id);

            return marca;
        }

        public void Inserir (Marca marca)
        {
            //criar classe de contexto
            LojaContext context = new LojaContext();

            //inserir novo objeto na classe marca
            context.Marca.Add(marca);

            //salvar alterações
            context.SaveChanges();
        }

        public void Alterar(Marca marca)
        {
            //criar classe de contexto
            LojaContext context = new LojaContext();

            context.Entry(marca).State = System.Data.Entity.EntityState.Modified;

            //salvar a alteração
            context.SaveChanges();
        }

        public void Excluir(int Id)
        {
            //criar classe de contexto
            LojaContext context = new LojaContext();

            //recuperar o objeto por ID
            Marca marca = context.Marca.Find(Id);

            //informa ao contexto que houve alteração
            context.SaveChanges();

        }
    }
}