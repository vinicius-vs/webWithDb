using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webDB.Context;
using webDB.Models;

namespace webDB.Repository
{
    public class LivroRepository
    {

        public void Create(Livros model)
        {
            using (var context = new RestContext())
            {
                context.livros.Add(model);
                context.SaveChanges();
            }
        }

        public List<Livros> Read()
        {
            List<Livros> lista = new List<Livros>();

            using (var context = new RestContext())
            {
                lista = context.livros.ToList();
            }

                return lista;
        }

        public Livros Read(int id)
        {
            Livros livro = new Livros();
            using (var context = new RestContext())
            {
                livro = context.livros.Find(id);
            }

            return livro;
        }

        public void Updade(Livros model)
        {
            using (var context = new RestContext())
            {
                context.Entry<Livros>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new RestContext())
            {
                context.Entry<Livros>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }


    }
}