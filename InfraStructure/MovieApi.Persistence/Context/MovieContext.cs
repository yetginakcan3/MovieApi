using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Persistence.Context
{
    public class MovieContext : DbContext
    {
        // sql baglantı adresini yazmak
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;initial Catalog=ApiMovieDb;integrated Security=true;TrustServerCertificate=true");
                
        }
        //veritabanına yansıtacağımız tabloları yansıtıyoruz

        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags{ get; set; }
        public DbSet<Cast> Casts { get; set; }
        

    }
}
