using core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
  
        public class ContextProgest : DbContext
        {
            public ContextProgest() : base("Name=Mycnx")
            {

            }
            public DbSet<action> action { get; set; }
            public DbSet<client> client { get; set; }
            public DbSet<consommable> consommable { get; set; }
            public DbSet<doc_inspection> doc_inspection { get; set; }
            public DbSet<doc_projet> doc_projet { get; set; }
            public DbSet<equipe_tache> equipe_tache { get; set; }
            public DbSet<instalation> instalation { get; set; }
            public DbSet<mail> mail { get; set; }
            public DbSet<materiel> materiel { get; set; }
            public DbSet<modules> modules { get; set; }
            public DbSet<projet> projet { get; set; }
            public DbSet<relation> relation { get; set; }
            public DbSet<reunions> reunions { get; set; }
            public DbSet<roles> roles { get; set; }
            public DbSet<service> service { get; set; }
            public DbSet<sprint> sprint { get; set; }
            public DbSet<tache_consommable> tache_consommable { get; set; }
            public DbSet<tache_logistique> tache_logistique { get; set; }
            public DbSet<tache_materiel> tache_materiel { get; set; }
            public DbSet<taches> taches { get; set; }
            public DbSet<utilisateur> utilisateur { get; set; }
            public DbSet<vehicule> vehicule { get; set; }



            //protected override void OnModelCreating(DbModelBuilder modelBuilder)
            //{

            //    //modelBuilder.Conventions.Add(new DateTime2Convention());
            //    //modelBuilder.Configurations.Add(new ProductConfiguration());
            //}

        }
        //public class MyFinanceContextInitialiser : DropCreateDatabaseIfModelChanges<Context>
        //{
        //    protected override void Seed(Context context)
        //    {
        //        Product p = new Product();
        //        p.Name = "def prod";
        //        p.Description = "def desc";
        //        p.fullprice = new FullPrice { Price = 15, Quantity = 17 };
        //        p.DateProd = DateTime.Now;
        //        context.product.Add(p);
        //        context.SaveChanges();

        //    }

        //}


    
}
