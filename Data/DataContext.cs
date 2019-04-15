using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data
{
    public class DataContext:DbContext
    {
        public DataContext() : base(@"data source=localhost/sqlexpress; Initial Catalog=ContatoDb; User Id=sa; Password=sipef@adm; integrated security=false;")
        {
            //sqlservr  || @"data source=192.168.25.248\sqlexpress; Initial Catalog=ContatoDb; User Id=sa; Password=Sipefadm1; integrated security=true;"
        }

        public DbSet<Documento> Contatos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
