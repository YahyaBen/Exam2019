using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2019.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Marque> Marques { get; set; }
        public DbSet<Assurance> Assurances { get; set; }
        public MyContext(DbContextOptions<MyContext>options) : base(options) 
        { 
        }

        //Commande Package Manager Console
        //1//   add-migration ExamenCreation
        //2//   update-database
    }
}
