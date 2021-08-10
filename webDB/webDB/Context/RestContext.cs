using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using webDB.Models;

namespace webDB.Context 
{
    public class RestContext: DbContext
    {

        public DbSet<Livros> livros { get; set; }

        public RestContext() : base("RestConnection")
        {
                
        }

    }
}