using CinemaWork.Configurations;
using CinemaWork.ModelsDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWork.DBContext
{
    public class CinemaDBContext : DbContext
    {
        public DbSet<Cinema> CinemaList { get; set; }
        public DbSet<CinemaHall> CinemaHall { get; set; }
        public DbSet<CinemaSession> CinemaSession { get; set; }
        public DbSet<CinemaPlaces> CinemaPlaces { get; set; }
        public DbSet<CinemaBook> CinemaBook { get; set; }
        public CinemaDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigHelper.ConnectionString);
        }
    }
}
